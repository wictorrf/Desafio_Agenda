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
            RuleFor(a => a.Name).NotEmpty();
            RuleFor(a => a.Email).EmailAddress();
            RuleFor(a => a.Cellphone).NotEmpty();
        }
    }
}