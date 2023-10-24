using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace Agenda_proj.Models.Validations
{
    public class AgendaValidator : AbstractValidator<AgendaModel>
    {
        public AgendaValidator()
        {
            RuleFor(a => a.Name).NotEmpty().NotNull();
            RuleFor(a => a.Email).NotEmpty().EmailAddress();
            RuleFor(a => a.Cellphone).NotEmpty().Length(11);
        }
    }
}