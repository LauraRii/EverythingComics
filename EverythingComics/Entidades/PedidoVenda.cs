using EverythingComics.Domain.Base;

namespace EverythingComics.Domain.Entities
{
    public class PedidoVenda : BaseEntity<int>
    {
        public PedidoVenda() : base(0)
        {
        }

        public PedidoVenda(int id, DateTime dataCriacao, DateTime? dataEntrega, string status, string observacaoStatus, Funcionario funcionario, Cliente cliente) : base(id)
        {
            DataCriacao = dataCriacao;
            DataEntrega = dataEntrega;
            Status = status;
            ObservacaoStatus = observacaoStatus;
            Funcionario = funcionario;
            Cliente = cliente;
        }

        public DateTime DataCriacao { get; set; }
        public DateTime? DataEntrega { get; set; }
        public string Status { get; set; }
        public string? ObservacaoStatus { get; set; }
        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }
    }
}