using EverythingComics.Domain.Base;

namespace EverythingComics.Domain.Entities
{
    public class Produto : BaseEntity<int>
    {
        public Produto() : base(0)
        {
        }

        public Produto(int id, string nome, int quantidadeEstoque, DateTime? dataCriacao, decimal preco) : base(id)
        {
            Nome = nome;
            QuantidadeEstoque = quantidadeEstoque;
            DataCriacao = dataCriacao;
            Preco = preco;
        }

        public string Nome { get; set; }
        public int QuantidadeEstoque { get; set; }
        public DateTime? DataCriacao { get; set; }
        public decimal Preco { get; set; }
    }
}