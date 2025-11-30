using FluentValidation;
using EverythingComics.Domain.Entities;

namespace EverythingComics.Service.Validations
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor, informe o nome do cliente.")
                .NotNull().WithMessage("Por favor, informe o nome do cliente.")
                .MaximumLength(40).WithMessage("O nome deve ter no máximo 40 caracteres.");

            RuleFor(c => c.Cnpj)
                .NotEmpty().WithMessage("Por favor, informe o CNPJ.")
                .Length(14).WithMessage("O CNPJ deve ter exatamente 14 caracteres (apenas números).");

            RuleFor(c => c.Cep)
                .Length(8).WithMessage("O CEP deve ter 8 caracteres.");

            RuleFor(c => c.Estado)
                .MaximumLength(2).WithMessage("Use a sigla do estado (ex: SP).");
        }
    }
}