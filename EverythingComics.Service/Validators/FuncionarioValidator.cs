using FluentValidation;
using EverythingComics.Domain.Entities;

namespace EverythingComics.Service.Validations
{
    public class FuncionarioValidator : AbstractValidator<Funcionario>
    {
        public FuncionarioValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor, informe o nome do funcionário.")
                .NotNull().WithMessage("Por favor, informe o nome do funcionário.")
                .MaximumLength(40).WithMessage("O nome deve ter no máximo 40 caracteres.");

            RuleFor(c => c.Cpf)
                .NotEmpty().WithMessage("Por favor, informe o CPF.")
                .Length(11).WithMessage("O CPF deve ter exatamente 11 caracteres (apenas números).");

            RuleFor(c => c.Cargo)
                .NotEmpty().WithMessage("Por favor, informe o cargo.")
                .MaximumLength(40).WithMessage("O cargo deve ter no máximo 40 caracteres.");

            RuleFor(c => c.Salario)
                .GreaterThan(0).WithMessage("O salário deve ser maior que zero.");

            RuleFor(c => c.DataNascimento)
                .NotEmpty().WithMessage("A data de nascimento é obrigatória.");
        }
    }
}