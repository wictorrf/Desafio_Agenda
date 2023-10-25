using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agenda_api.Models;
using Agenda_proj.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda_proj.Data
{
    public class AgendaDbContext : DbContext
    {
        public AgendaDbContext(DbContextOptions<AgendaDbContext> options) : base(options)
        {

        }
        public DbSet<AgendaModel> Agenda { get; set; }

    }
}