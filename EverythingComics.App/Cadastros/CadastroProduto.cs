using EverythingComics.Domain.Base;
using EverythingComics.Domain.Entities;
using EverythingComics.Service.Validations;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;

namespace EverythingComics.App.Cadastros
{
    public partial class CadastroProduto : CadastroBase
    {
        private readonly IBaseService<Produto> _produtoService;
        private readonly ProdutoValidator _validator;
        private Produto? _produtoAtual;

        public CadastroProduto()
        {
            InitializeComponent();
        }

        public CadastroProduto(IBaseService<Produto> service, ProdutoValidator validator)
        {
            InitializeComponent();
            _produtoService = service;
            _validator = validator;
        }

        protected override void CarregarGrid()
        {
            var lista = _produtoService.Get();
            dataGridViewBase.DataSource = lista;
            dataGridViewBase.Columns["Id"].Visible = false;
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            int id = (int)row.Cells["Id"].Value;
            _produtoAtual = _produtoService.GetById(id);

            txtId.Text = _produtoAtual.Id.ToString();
            txtNome.Text = _produtoAtual.Nome;

            txtPreco.Text = _produtoAtual.Preco.ToString("N2");
            txtQtdEstoque.Text = _produtoAtual.QuantidadeEstoque.ToString();

            dtpDataCriacao.Value = _produtoAtual.DataCriacao ?? DateTime.Now;
        }

        protected override bool Salvar()
        {
            if (_produtoAtual == null) _produtoAtual = new Produto();

            _produtoAtual.Nome = txtNome.Text;
            _produtoAtual.DataCriacao = dtpDataCriacao.Value;

            if (decimal.TryParse(txtPreco.Text, out decimal preco))
            {
                _produtoAtual.Preco = preco;
            }
            else
            {
                MessageBox.Show("Preço inválido! Digite apenas números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (int.TryParse(txtQtdEstoque.Text, out int estoque))
            {
                _produtoAtual.QuantidadeEstoque = estoque;
            }
            else
            {
                _produtoAtual.QuantidadeEstoque = 0;
            }

            if (IsUpdate)
                _produtoService.Update<ProdutoValidator>(_produtoAtual);
            else
                _produtoService.Add<ProdutoValidator>(_produtoAtual);

            return true;
        }

        protected override void Deletar(int id)
        {
            _produtoService.Delete(id);
        }

        protected override void LimparCampos()
        {
            _produtoAtual = null;
            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            txtQtdEstoque.Clear();
            dtpDataCriacao.Value = DateTime.Now;
        }
    }
}