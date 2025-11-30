using System;

namespace EverythingComics.App.ViewModel
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeEstoque { get; set; }
        public decimal Preco { get; set; }
        public DateTime? DataCriacao { get; set; }
    }
}