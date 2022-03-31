using FluentValidation;
using Order.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Validations
{
    public class ClientValidation : AbstractValidator<ClientModel>
    {
        public ClientValidation()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Nome é obrigatório!")
                .NotEmpty()
                .Length(3, 50);
            RuleFor(x => x.Email)
                .NotNull().WithMessage("Email é obrigatório!")
                .NotEmpty()
                .EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible);
            RuleFor(x => x.PhoneNumber)
                .NotNull().WithMessage("Número telefone é obrigatório!")
                .NotEmpty();
        }
    }
}
