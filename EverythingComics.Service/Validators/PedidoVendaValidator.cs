using FluentValidation;
using EverythingComics.Domain.Entities;

namespace EverythingComics.Service.Validations
{
    public class PedidoVendaValidator : AbstractValidator<PedidoVenda>
    {
        public PedidoVendaValidator()
        {
            RuleFor(c => c.Cliente)
                .NotNull().WithMessage("É necessário informar o cliente da venda.");

            RuleFor(c => c.Funcionario)
                .NotNull().WithMessage("É necessário informar o funcionário responsável.");

            RuleFor(c => c.DataCriacao)
                .NotEmpty().WithMessage("A data da venda é obrigatória.");
        }
    }
}