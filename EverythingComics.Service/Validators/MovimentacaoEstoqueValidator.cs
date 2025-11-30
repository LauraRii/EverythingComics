using FluentValidation;
using EverythingComics.Domain.Entities;

namespace EverythingComics.Service.Validations
{
    public class MovimentacaoEstoqueValidator : AbstractValidator<MovimentacaoEstoque>
    {
        public MovimentacaoEstoqueValidator()
        {
            RuleFor(c => c.Produto)
                .NotNull().WithMessage("Informe o produto da movimentação.");

            RuleFor(c => c.Quantidade)
                .GreaterThan(0).WithMessage("A quantidade movimentada deve ser maior que zero.");

            RuleFor(c => c.Observacao)
                .MaximumLength(100).WithMessage("A observação deve ter no máximo 100 caracteres.");
        }
    }
}