using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace Agenda_proj.Models.Validations.Error
{
    public static class ValidationFailureExtension
    {
        public static IList<AgendaValidationFailure> ToAgendaValidationFailure(this IList<ValidationFailure> failures)
        {
            return failures.Select(f => new AgendaValidationFailure(f.PropertyName, f.ErrorMessage)).ToList();
        }
    }
}