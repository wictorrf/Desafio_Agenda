using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_proj.Models
{
    public class AgendaModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Cellphone { get; set; }
    }
}