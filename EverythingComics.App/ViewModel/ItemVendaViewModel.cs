using System;

namespace EverythingComics.App.ViewModel
{
    public class ItemVendaViewModel
    {
        public int Id { get; set; }

        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public string ProdutoNome { get; set; } 

        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal? ValorTotal { get; set; }
    }
}