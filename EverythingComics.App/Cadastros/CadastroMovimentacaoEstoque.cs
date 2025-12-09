using AutoMapper;
using EverythingComics.App.Infra;
using EverythingComics.App.ViewModel;
using EverythingComics.Domain.Base;
using EverythingComics.Domain.Entities;
using EverythingComics.Service.Validations;
using Microsoft.Extensions.DependencyInjection; 

namespace EverythingComics.App.Cadastros
{
    public partial class CadastroMovimentacao : CadastroBase
    {
        private readonly IBaseService<MovimentacaoEstoque> _movService;
        private readonly IBaseService<Produto> _produtoService;
        private readonly MovimentacaoEstoqueValidator _validator;

        private MovimentacaoEstoque? _movAtual;

        public CadastroMovimentacao()
        {
            InitializeComponent();
            CarregarGrid();
        }
        public CadastroMovimentacao(
            IBaseService<MovimentacaoEstoque> movService,
            IBaseService<Produto> produtoService,
            MovimentacaoEstoqueValidator validator)
        {
            InitializeComponent();
            _movService = movService;
            _produtoService = produtoService;
            _validator = validator;

            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            cboProduto.DataSource = _produtoService.Get();
            cboProduto.ValueMember = "Id";
            cboProduto.DisplayMember = "Nome";
        }

        protected override void CarregarGrid()
        {
            var lista = _movService.Get();
            var mapper = ConfigureDI.ServicesProvider!.GetService<IMapper>();

            var listaViewModel = mapper?.Map<List<MovimentacaoEstoqueViewModel>>(lista);

            //dataGridViewBase.DataSource = lista;
            dataGridViewBase.DataSource = listaViewModel;
            dataGridViewBase.Columns["Id"].Visible = false;
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            int id = (int)row.Cells["Id"].Value;
            _movAtual = _movService.GetById(id);

            txtId.Text = _movAtual.Id.ToString();
            txtQuantidade.Text = _movAtual.Quantidade.ToString();
            txtObs.Text = _movAtual.Observacao;
            dtpData.Value = _movAtual.DataMovimentacao;

            cboProduto.SelectedValue = _movAtual.Produto.Id;

            if (_movAtual.TipoMovimentacao)
                radioEntrada.Checked = true;
            else
                radioSaida.Checked = true;
        }

        protected override void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        protected override bool Salvar()
        {
            if (_movAtual == null) _movAtual = new MovimentacaoEstoque();

            _movAtual.DataMovimentacao = dtpData.Value;
            _movAtual.Quantidade = int.Parse(txtQuantidade.Text);
            _movAtual.Observacao = txtObs.Text;

            _movAtual.TipoMovimentacao = radioEntrada.Checked;

            var idProduto = (int)cboProduto.SelectedValue!;
            _movAtual.Produto = _produtoService.GetById(idProduto);

            if (_movAtual.TipoMovimentacao == true)
            {
                var produto = _movAtual.Produto;
                produto.QuantidadeEstoque += _movAtual.Quantidade;
                _produtoService.Update<ProdutoValidator>(produto);
            }
            else
            {
                var produto = _movAtual.Produto;
                produto.QuantidadeEstoque -= _movAtual.Quantidade;
                _produtoService.Update<ProdutoValidator>(produto);
            }

            if (IsUpdate)
                _movService.Update<MovimentacaoEstoqueValidator>(_movAtual);
            else
                _movService.Add<MovimentacaoEstoqueValidator>(_movAtual);

            return true;
        }

        protected override void Deletar(int id)
        {
            _movService.Delete(id);
        }

        protected override void LimparCampos()
        {
            _movAtual = null;
            txtId.Clear();
            txtQuantidade.Clear();
            txtObs.Clear();
            radioEntrada.Checked = true;
            if (cboProduto.Items.Count > 0) cboProduto.SelectedIndex = 0;
            dtpData.Value = DateTime.Now;
        }

    }
}