using EverythingComics.Domain.Base;

namespace EverythingComics.Domain.Entities
{
    public class Funcionario : BaseEntity<int>
    {
        public Funcionario() : base(0)
        {
        }

        public Funcionario(int id, string nome, string cargo, string departamento, string cpf, string celular, DateTime dataNascimento, decimal salario, string status) : base(id)
        {
            Nome = nome;
            Cargo = cargo;
            Departamento = departamento;
            Cpf = cpf;
            Celular = celular;
            DataNascimento = dataNascimento;
            Salario = salario;
            Status = status;
        }

        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Salario { get; set; }
        public string Status { get; set; }
    }
}