using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agenda_proj.Data;
using Agenda_proj.Models;
using Agenda_proj.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Agenda_proj.Repositories
{
    public class AgendaRepository : IAgendaRepository
    {
        private readonly AgendaDbContext _dbcontext;

        public AgendaRepository(AgendaDbContext agendaDbContext)
        {
            _dbcontext = agendaDbContext;
        }

        public async Task<AgendaModel> Create(AgendaModel agenda)
        {
            await _dbcontext.Agenda.AddAsync(agenda);
            await _dbcontext.SaveChangesAsync();
            return agenda;
        }

        public async Task<List<AgendaModel>> GetAll()
        {
            return await _dbcontext.Agenda.ToListAsync();
        }

        public async Task<AgendaModel> GetById(int id)
        {
            return await _dbcontext.Agenda.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<AgendaModel> Update(AgendaModel agendaModel, int id)
        {
            AgendaModel userById = await GetById(id);
            if (userById == null) throw new Exception($"O Usuario com o id: {id} não foi encontrado!");
            userById.Name = agendaModel.Name;
            userById.Email = agendaModel.Email;
            userById.Cellphone = agendaModel.Cellphone;
            await _dbcontext.SaveChangesAsync();
            return userById;
        }

        public async Task<bool> Delete(int id)
        {
            AgendaModel userById = await GetById(id);
            if (userById == null) throw new Exception($"O Usuario com o id: {id} não foi encontrado!");
            _dbcontext.Agenda.Remove(userById);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
    }
}