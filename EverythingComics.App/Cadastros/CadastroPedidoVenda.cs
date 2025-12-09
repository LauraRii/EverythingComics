using EverythingComics.App.ViewModel;
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
        private readonly IBaseService<MovimentacaoEstoque> _movService;

        private readonly PedidoVendaValidator _validator;
        private PedidoVenda? _vendaAtual;

        public CadastroPedidoVenda(
            IBaseService<PedidoVenda> vendaService,
            IBaseService<ItemVenda> itemService,
            IBaseService<Cliente> clienteService,
            IBaseService<Funcionario> funcService,
            IBaseService<Produto> produtoService,
            IBaseService<MovimentacaoEstoque> movService, 
            PedidoVendaValidator validator)
        {
            InitializeComponent();
            _vendaService = vendaService;
            _itemService = itemService;
            _clienteService = clienteService;
            _funcService = funcService;
            _produtoService = produtoService;
            _movService = movService; 
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
            var lista = _vendaService.Get()
                .Select(v => new PedidoVendaViewModel
                {
                    Id = v.Id,
                    DataCriacao = v.DataCriacao,
                    DataEntrega = v.DataEntrega,
                    ClienteNome = v.Cliente.Nome,
                    FuncionarioNome = v.Funcionario.Nome,
                    Status = v.Status
                })
                .ToList();
            dataGridViewBase.DataSource = lista;
            if (dataGridViewBase.Columns["Id"] != null) dataGridViewBase.Columns["Id"].Visible = false;
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

            if (gridItens.Columns["Pedido"] != null) gridItens.Columns["Pedido"].Visible = false;
            if (gridItens.Columns["Produto"] != null) gridItens.Columns["Produto"].Visible = false;

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
                var produto = _produtoService.GetById(idProd);
                item.Produto = produto;

                item.Quantidade = int.Parse(txtQtdItem.Text);
                item.PrecoUnitario = decimal.Parse(txtPrecoUnit.Text);
                item.ValorTotal = item.Quantidade * item.PrecoUnitario;

                _itemService.Add<ItemVendaValidator>(item);

                var mov = new MovimentacaoEstoque();
                mov.Produto = produto;
                mov.Quantidade = item.Quantidade;
                mov.TipoMovimentacao = false; 
                mov.DataMovimentacao = DateTime.Now;
                mov.Observacao = $"Venda #{_vendaAtual.Id}";

                _movService.Add<MovimentacaoEstoqueValidator>(mov);

                produto.QuantidadeEstoque -= item.Quantidade;
                _produtoService.Update<ProdutoValidator>(produto);

                AtualizarGridItens();
                txtQtdItem.Clear();
                MessageBox.Show("Item adicionado e estoque atualizado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar item: " + ex.Message);
            }
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            if (gridItens.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja remover este item e devolver ao estoque?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        var itemSelecionado = (ItemVenda)gridItens.SelectedRows[0].DataBoundItem;

                        var mov = new MovimentacaoEstoque();
                        mov.Produto = itemSelecionado.Produto;
                        mov.Quantidade = itemSelecionado.Quantidade;
                        mov.TipoMovimentacao = true; 
                        mov.DataMovimentacao = DateTime.Now;
                        mov.Observacao = $"Estorno Venda #{_vendaAtual!.Id}";
                        _movService.Add<MovimentacaoEstoqueValidator>(mov);

                        var produto = _produtoService.GetById(itemSelecionado.Produto.Id);
                        produto.QuantidadeEstoque += itemSelecionado.Quantidade;
                        _produtoService.Update<ProdutoValidator>(produto);

                        _itemService.Delete(itemSelecionado.Id);

                        AtualizarGridItens();
                        MessageBox.Show("Item removido e estoque estornado.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao remover: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um item na lista para remover.");
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