using EverythingComics.Domain.Base;
using EverythingComics.Domain.Entities;
using EverythingComics.Service.Validations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EverythingComics.App.Cadastros
{
    public partial class CadastroPedidoVenda : CadastroBase
    {
        private readonly IBaseService<PedidoVenda> _vendaService;
        private readonly IBaseService<ItemVenda> _itemService;
        private readonly IBaseService<Cliente> _clienteService;
        private readonly IBaseService<Funcionario> _funcService;
        private readonly IBaseService<Produto> _produtoService;

        private readonly PedidoVendaValidator _validator;
        private PedidoVenda? _vendaAtual;

        public CadastroPedidoVenda(
            IBaseService<PedidoVenda> vendaService,
            IBaseService<ItemVenda> itemService,
            IBaseService<Cliente> clienteService,
            IBaseService<Funcionario> funcService,
            IBaseService<Produto> produtoService,
            PedidoVendaValidator validator)
        {
            InitializeComponent();
            _vendaService = vendaService;
            _itemService = itemService;
            _clienteService = clienteService;
            _funcService = funcService;
            _produtoService = produtoService;
            _validator = validator;

            CarregarCombos();
        }

        private void CarregarCombos()
        {
            cboCliente.DataSource = _clienteService.Get();
            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "Nome";

            cboFuncionario.DataSource = _funcService.Get();
            cboFuncionario.ValueMember = "Id";
            cboFuncionario.DisplayMember = "Nome";

            cboProduto.DataSource = _produtoService.Get();
            cboProduto.ValueMember = "Id";
            cboProduto.DisplayMember = "Nome";
        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProduto.SelectedValue != null && int.TryParse(cboProduto.SelectedValue.ToString(), out int id))
            {
                var produto = _produtoService.GetById(id);
                if (produto != null)
                    txtPrecoUnit.Text = produto.Preco.ToString("N2");
            }
        }

        protected override void CarregarGrid()
        {
            var lista = _vendaService.Get();
            dataGridViewBase.DataSource = lista;
            dataGridViewBase.Columns["Id"].Visible = false;
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            int id = (int)row.Cells["Id"].Value;
            _vendaAtual = _vendaService.GetById(id);

            txtId.Text = _vendaAtual.Id.ToString();
            dtpDataVenda.Value = _vendaAtual.DataCriacao;
            dtpDataEntrega.Value = _vendaAtual.DataEntrega ?? DateTime.Now;

            cboCliente.SelectedValue = _vendaAtual.Cliente.Id;
            cboFuncionario.SelectedValue = _vendaAtual.Funcionario.Id;

            groupBoxItens.Enabled = true;
            AtualizarGridItens();
        }

        private void AtualizarGridItens()
        {
            var todosItens = _itemService.Get();
            var itensDestaVenda = todosItens.Where(x => x.Pedido.Id == _vendaAtual!.Id).ToList();

            gridItens.DataSource = null;
            gridItens.DataSource = itensDestaVenda;

            decimal total = itensDestaVenda.Sum(x => x.ValorTotal ?? 0);
            txtTotal.Text = total.ToString("C2");
        }

        protected override bool Salvar()
        {
            if (_vendaAtual == null) _vendaAtual = new PedidoVenda();

            _vendaAtual.DataCriacao = dtpDataVenda.Value;
            _vendaAtual.DataEntrega = dtpDataEntrega.Value;
            _vendaAtual.Status = "Aberta"; 

            var idCliente = (int)cboCliente.SelectedValue!;
            _vendaAtual.Cliente = _clienteService.GetById(idCliente);

            var idFunc = (int)cboFuncionario.SelectedValue!;
            _vendaAtual.Funcionario = _funcService.GetById(idFunc);

            if (IsUpdate)
                _vendaService.Update<PedidoVendaValidator>(_vendaAtual);
            else
            {
                _vendaService.Add<PedidoVendaValidator>(_vendaAtual);
                IsUpdate = true;
                groupBoxItens.Enabled = true;
                MessageBox.Show("Venda iniciada! Agora adicione os itens abaixo.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; 
            }

            return true;
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_vendaAtual == null || _vendaAtual.Id == 0)
                {
                    MessageBox.Show("Salve a venda antes de adicionar itens!");
                    return;
                }

                var item = new ItemVenda();
                item.Pedido = _vendaAtual;

                var idProd = (int)cboProduto.SelectedValue!;
                item.Produto = _produtoService.GetById(idProd);

                item.Quantidade = int.Parse(txtQtdItem.Text);
                item.PrecoUnitario = decimal.Parse(txtPrecoUnit.Text);
                item.ValorTotal = item.Quantidade * item.PrecoUnitario;

                _itemService.Add<ItemVendaValidator>(item);

                AtualizarGridItens();
                txtQtdItem.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar item: " + ex.Message);
            }
        }

        protected override void LimparCampos()
        {
            _vendaAtual = null;
            txtId.Clear();
            txtTotal.Clear();
            groupBoxItens.Enabled = false; 
            gridItens.DataSource = null;
        }
    }
}