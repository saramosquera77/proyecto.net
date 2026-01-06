using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.feautres.clientes.commands.CreateClienteCommand
{
    public class CreateClienteCommandValidator : AbstractValidator<CreateClienteCommand>
    {
        public CreateClienteCommandValidator()
        {
            RuleFor(p => p.Nombre)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
                .MaximumLength(80).WithMessage("{PropertyName} no debe exeder de {MaxLength} caracteres");

            RuleFor(c => c.Apellido)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
                .MaximumLength(80).WithMessage("{PropertyName} no debe exeder de {MaxLength} caracteres");

            RuleFor(c => c.FechaNacimiento)
                .NotEmpty().WithMessage("La fecha de nacimiento no puede ir vacia.");
                
            RuleFor(c => c.Telefono)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
                .Matches(@"^\+?[1-9]\d{1,14}$").WithMessage("{PropertyName} debe cumplir el formato 000-000-00-00")
                .MaximumLength(80).WithMessage("{PropertyName} no debe exeder de {MaxLength} caracteres");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
                .EmailAddress().WithMessage("{PropertyName} debe ser una direccion de email valida")
                .MaximumLength(100).WithMessage("{PropertyName} no debe exeder de {MaxLength} caracteres");

            RuleFor(c => c.Direccion)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
                .MaximumLength(120).WithMessage("{PropertyName} no debe exeder de {MaxLength} caracteres");
        }

        private object MaximumLength(int v)
        {
            throw new NotImplementedException();
        }
    }
}
