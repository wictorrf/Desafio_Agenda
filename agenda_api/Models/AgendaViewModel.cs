using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agenda_api.Models
{
    public class AgendaViewModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Cellphone { get; set; }
    }
}