using FluentValidation;
using EverythingComics.Domain.Entities;

namespace EverythingComics.Service.Validations
{
    public class ItemVendaValidator : AbstractValidator<ItemVenda>
    {
        public ItemVendaValidator()
        {
            RuleFor(c => c.Produto)
                .NotNull().WithMessage("Informe o produto.");

            RuleFor(c => c.Quantidade)
                .GreaterThan(0).WithMessage("A quantidade do item deve ser maior que zero.");

            RuleFor(c => c.PrecoUnitario)
                .GreaterThan(0).WithMessage("O preço unitário deve ser maior que zero.");
        }
    }
}