using EverythingComics.Domain.Base;

namespace EverythingComics.Domain.Entities
{
    public class Cliente : BaseEntity<int>
    {
        public Cliente() : base(0)
        {
        }

        public Cliente(int id, string nome, string cnpj, string cep, string rua, string bairro, string cidade, string estado) : base(id)
        {
            Nome = nome;
            Cnpj = cnpj;
            Cep = cep;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}