using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_proj.Models.Validations.Error
{
    public class AgendaValidationFailure
    {
        public AgendaValidationFailure(string propertyName, string errorMessage)
        {
            PropertyName = propertyName;
            ErrorMessage = errorMessage;
        }

        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }
}