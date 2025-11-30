using EverythingComics.Domain.Base;
using EverythingComics.Domain.Entities;
using EverythingComics.Service.Validations;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;

namespace EverythingComics.App.Cadastros
{
    public partial class CadastroFuncionario : CadastroBase
    {
        private readonly IBaseService<Funcionario> _funcionarioService;
        private readonly FuncionarioValidator _validator;
        private Funcionario? _funcionarioAtual;

        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        public CadastroFuncionario(IBaseService<Funcionario> service, FuncionarioValidator validator)
        {
            InitializeComponent();
            _funcionarioService = service;
            _validator = validator;
        }

        protected override void CarregarGrid()
        {
            var lista = _funcionarioService.Get();
            dataGridViewBase.DataSource = lista;
            dataGridViewBase.Columns["Id"].Visible = false;
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            int id = (int)row.Cells["Id"].Value;
            _funcionarioAtual = _funcionarioService.GetById(id);

            txtId.Text = _funcionarioAtual.Id.ToString();
            txtNome.Text = _funcionarioAtual.Nome;
            txtCpf.Text = _funcionarioAtual.Cpf;
            txtCargo.Text = _funcionarioAtual.Cargo;
            txtDepartamento.Text = _funcionarioAtual.Departamento;
            txtCelular.Text = _funcionarioAtual.Celular;
            txtStatus.Text = _funcionarioAtual.Status;

            dtpDataNasc.Value = _funcionarioAtual.DataNascimento;

            txtSalario.Text = _funcionarioAtual.Salario.ToString("N2"); 
        }

        protected override bool Salvar()
        {
            if (_funcionarioAtual == null) _funcionarioAtual = new Funcionario();

            _funcionarioAtual.Nome = txtNome.Text;
            _funcionarioAtual.Cpf = txtCpf.Text;
            _funcionarioAtual.Cargo = txtCargo.Text;
            _funcionarioAtual.Departamento = txtDepartamento.Text;
            _funcionarioAtual.Celular = txtCelular.Text;
            _funcionarioAtual.Status = txtStatus.Text;
            _funcionarioAtual.DataNascimento = dtpDataNasc.Value;
            if (decimal.TryParse(txtSalario.Text, out decimal salario))
            {
                _funcionarioAtual.Salario = salario;
            }
            else
            {
                MessageBox.Show("Valor de salário inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }

            if (IsUpdate)
                _funcionarioService.Update<FuncionarioValidator>(_funcionarioAtual);
            else
                _funcionarioService.Add<FuncionarioValidator>(_funcionarioAtual);

            return true;
        }

        protected override void Deletar(int id)
        {
            _funcionarioService.Delete(id);
        }

        protected override void LimparCampos()
        {
            _funcionarioAtual = null;
            txtId.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtCargo.Clear();
            txtDepartamento.Clear();
            txtCelular.Clear();
            txtSalario.Clear();
            txtStatus.Clear();
            dtpDataNasc.Value = DateTime.Now;
        }
    }
}