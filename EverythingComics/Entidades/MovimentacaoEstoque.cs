using EverythingComics.Domain.Base;

namespace EverythingComics.Domain.Entities
{
    public class MovimentacaoEstoque : BaseEntity<int>
    {
        public MovimentacaoEstoque() : base(0)
        {
        }

        public MovimentacaoEstoque(int id, Produto produto, DateTime dataMovimentacao, bool tipoMovimentacao, int quantidade, string observacao) : base(id)
        {
            Produto = produto;
            DataMovimentacao = dataMovimentacao;
            TipoMovimentacao = tipoMovimentacao;
            Quantidade = quantidade;
            Observacao = observacao;
        }

        public Produto Produto { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public bool TipoMovimentacao { get; set; }
        public int Quantidade { get; set; }
        public string Observacao { get; set; }
    }
}