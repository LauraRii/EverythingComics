using System;

namespace EverythingComics.App.ViewModel
{
    public class FuncionarioViewModel
    {
        public int Id { get; set; }
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