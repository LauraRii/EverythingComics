using EverythingComics.Domain.Base;

namespace EverythingComics.Domain.Entities
{
    public class ItemVenda : BaseEntity<int>
    {
        public ItemVenda() : base(0)
        {
        }

        public ItemVenda(PedidoVenda pedido, Produto produto, int quantidade, decimal precoUnitario, decimal? valorTotal) : base(0)
        {
            Pedido = pedido;
            Produto = produto;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
            ValorTotal = valorTotal;
        }

        public PedidoVenda Pedido { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal? ValorTotal { get; set; }
    }
}