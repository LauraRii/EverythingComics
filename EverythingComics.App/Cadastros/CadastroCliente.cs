using EverythingComics.Domain.Base;
using EverythingComics.Domain.Entities;
using EverythingComics.Service.Validations;
using System.Windows.Forms;

namespace EverythingComics.App.Cadastros
{
    public partial class CadastroCliente : CadastroBase
    {
        private readonly IBaseService<Cliente> _clienteService;
        private Cliente? _clienteAtual;

        public CadastroCliente()
        {
            InitializeComponent();
        }

        public CadastroCliente(IBaseService<Cliente> clienteService, ClienteValidator validator)
        {
            InitializeComponent();
            _clienteService = clienteService;

            CarregarEstados();
        }

        private void CarregarEstados()
        {
            cboEstado.Items.Clear();
            cboEstado.Items.AddRange(new object[] {
                "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA",
                "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"
            });
            cboEstado.SelectedIndex = 0; 
        }

        // --- MÉTODOS SOBRESCRITOS ---

        protected override void CarregarGrid()
        {
            if (_clienteService != null)
            {
                var clientes = _clienteService.Get();
                dataGridViewBase.DataSource = clientes;
                if (dataGridViewBase.Columns["Id"] != null) dataGridViewBase.Columns["Id"].Visible = false;
            }
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            if (row.Cells["Id"].Value != null)
            {
                int id = (int)row.Cells["Id"].Value;
                _clienteAtual = _clienteService.GetById(id);

                if (_clienteAtual != null)
                {
                    txtId.Text = _clienteAtual.Id.ToString();
                    txtNome.Text = _clienteAtual.Nome;
                    txtCnpj.Text = _clienteAtual.Cnpj;
                    txtRua.Text = _clienteAtual.Rua;
                    txtBairro.Text = _clienteAtual.Bairro;
                    txtCidade.Text = _clienteAtual.Cidade;

                    cboEstado.SelectedItem = _clienteAtual.Estado;

                    txtCep.Text = _clienteAtual.Cep;
                }
            }
        }

        protected override bool Salvar()
        {
            if (_clienteAtual == null) _clienteAtual = new Cliente();

            _clienteAtual.Nome = txtNome.Text;
            _clienteAtual.Cnpj = txtCnpj.Text;
            _clienteAtual.Rua = txtRua.Text;
            _clienteAtual.Bairro = txtBairro.Text;
            _clienteAtual.Cidade = txtCidade.Text;

            _clienteAtual.Estado = cboEstado.SelectedItem?.ToString();

            _clienteAtual.Cep = txtCep.Text;

            if (IsUpdate)
                _clienteService.Update<ClienteValidator>(_clienteAtual);
            else
                _clienteService.Add<ClienteValidator>(_clienteAtual);

            return true;
        }

        protected override void Deletar(int id)
        {
            _clienteService.Delete(id);
        }

        protected override void LimparCampos()
        {
            _clienteAtual = null;
            txtId.Clear();
            txtNome.Clear();
            txtCnpj.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();

            if (cboEstado.Items.Count > 0) cboEstado.SelectedIndex = 0;

            txtCep.Clear();
        }
    }
}