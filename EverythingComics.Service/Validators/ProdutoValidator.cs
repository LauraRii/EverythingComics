using FluentValidation;
using EverythingComics.Domain.Entities;

namespace EverythingComics.Service.Validations
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor, informe o nome do produto.")
                .NotNull().WithMessage("Por favor, informe o nome do produto.")
                .MaximumLength(40).WithMessage("O nome deve ter no máximo 40 caracteres.");

            RuleFor(c => c.Preco)
                .GreaterThan(0).WithMessage("O preço do produto deve ser maior que zero.");

            RuleFor(c => c.QuantidadeEstoque)
                .GreaterThanOrEqualTo(0).WithMessage("A quantidade em estoque não pode ser negativa.");
        }
    }
}