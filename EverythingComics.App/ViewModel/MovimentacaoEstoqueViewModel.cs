using System;

namespace EverythingComics.App.ViewModel
{
    public class MovimentacaoEstoqueViewModel
    {
        public int Id { get; set; }
        public string? ProdutoNome { get; set; } 
        public DateTime DataMovimentacao { get; set; }
        public bool TipoMovimentacao { get; set; } 
        public int Quantidade { get; set; }
        public string? Observacao { get; set; }
    }
}