using MaterialSkin;
using MaterialSkin.Controls;
using EverythingComics.App.Cadastros;
using EverythingComics.App.Infra;
using EverythingComics.Domain.Base;
using EverythingComics.Domain.Entities;
using EverythingComics.Service.Validations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms; 

namespace EverythingComics.App
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Yellow800, Primary.Yellow900, Primary.Yellow500,
                Accent.Orange700, TextShade.WHITE
            );

            this.Resize += new EventHandler(MainForm_Resize);

            ConfigurarImagemFundo();
        }

        private void MainForm_Resize(object? sender, EventArgs e)
        {
            CentralizarCard();
        }

        private void CentralizarCard()
        {
            if (materialCard1 != null)
            {
                int x = (this.ClientSize.Width - materialCard1.Width) / 2;

                int y = (this.ClientSize.Height - materialCard1.Height) / 2 + 30;

                materialCard1.Location = new System.Drawing.Point(x, y);
            }
        }


        private void btnClientes_Click(object sender, EventArgs e)
        {
            var service = ConfigureDI.ServicesProvider!.GetService<IBaseService<Cliente>>();
            var validator = new ClienteValidator();
            if (service != null) new CadastroCliente(service, validator).ShowDialog();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            var service = ConfigureDI.ServicesProvider!.GetService<IBaseService<Funcionario>>();
            var validator = new FuncionarioValidator();
            if (service != null) new CadastroFuncionario(service, validator).ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            var service = ConfigureDI.ServicesProvider!.GetService<IBaseService<Produto>>();
            var validator = new ProdutoValidator();
            if (service != null) new CadastroProduto(service, validator).ShowDialog();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            var movService = ConfigureDI.ServicesProvider!.GetService<IBaseService<MovimentacaoEstoque>>();
            var prodService = ConfigureDI.ServicesProvider!.GetService<IBaseService<Produto>>();
            var validator = new MovimentacaoEstoqueValidator();

            if (movService != null && prodService != null)
            {
                new CadastroMovimentacao(movService, prodService, validator).ShowDialog();
            }
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            var srvVenda = ConfigureDI.ServicesProvider!.GetService<IBaseService<PedidoVenda>>();
            var srvItem = ConfigureDI.ServicesProvider!.GetService<IBaseService<ItemVenda>>();
            var srvCliente = ConfigureDI.ServicesProvider!.GetService<IBaseService<Cliente>>();
            var srvFunc = ConfigureDI.ServicesProvider!.GetService<IBaseService<Funcionario>>();
            var srvProd = ConfigureDI.ServicesProvider!.GetService<IBaseService<Produto>>();

            var srvMov = ConfigureDI.ServicesProvider!.GetService<IBaseService<MovimentacaoEstoque>>();

            var validator = new PedidoVendaValidator();

            if (srvVenda != null && srvMov != null) 
            {
                new CadastroPedidoVenda(srvVenda, srvItem, srvCliente, srvFunc, srvProd, srvMov, validator).ShowDialog();
            }
            else
            {
                MessageBox.Show("Erro ao carregar serviços.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarImagemFundo()
        {
            PictureBox fundo = new PictureBox();

            var imagemOriginal = Properties.Resources.Everything_Comics_Menu;
            fundo.Image = imagemOriginal;

            fundo.SizeMode = PictureBoxSizeMode.StretchImage;

            fundo.Dock = DockStyle.Fill;
            this.Controls.Add(fundo);
            fundo.SendToBack();
        }
    }
}