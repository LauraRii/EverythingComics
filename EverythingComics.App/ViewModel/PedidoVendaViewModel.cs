using System;

namespace EverythingComics.App.ViewModel
{
    public class PedidoVendaViewModel
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataEntrega { get; set; }
        public string Status { get; set; }
        public string ObservacaoStatus { get; set; }

        public int ClienteId { get; set; }
        public int FuncionarioId { get; set; }

        public string ClienteNome { get; set; }
        public string FuncionarioNome { get; set; }
    }
}