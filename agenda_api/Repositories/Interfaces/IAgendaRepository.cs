using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agenda_proj.Models;

namespace Agenda_proj.Repositories.Interfaces
{
    public interface IAgendaRepository
    {
        Task<List<AgendaModel>> GetAll();
        Task<AgendaModel> GetById(int id);
        Task<AgendaModel> Create(AgendaModel agendaModel);
        Task<AgendaModel> Update(AgendaModel agendaModel, int id);
        Task<bool> Delete(int id);
    }
}