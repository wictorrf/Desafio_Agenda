using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agenda_api.Models;
using Agenda_proj.Models;
using Agenda_proj.Models.Validations;
using Agenda_proj.Models.Validations.Error;
using Agenda_proj.Repositories.Interfaces;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Agenda_proj.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendaController : ControllerBase
    {
        private readonly IAgendaRepository _agendaRepository;
        private readonly IValidator<AgendaModel> _validator;
        private readonly IMapper _mapper;
        public AgendaController(IAgendaRepository agendaRepository, IValidator<AgendaModel> validator, IMapper mapper)
        {
            _agendaRepository = agendaRepository;
            _validator = validator;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<AgendaModel>> RegisterContact([FromBody] AgendaInputModel model)
        {
            var agenda = _mapper.Map<AgendaModel>(model);
            var validationResult = _validator.Validate(agenda);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors.ToAgendaValidationFailure());
            }
            AgendaModel createuser = await _agendaRepository.Create(agenda);
            return Ok(createuser);
        }

        [HttpGet]
        public async Task<ActionResult<List<AgendaModel>>> GetAllContacts()
        {
            List<AgendaModel> users = await _agendaRepository.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AgendaModel>> GetContactById(int id)
        {
            AgendaModel user = await _agendaRepository.GetById(id);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AgendaModel>> UpdateContact([FromBody] AgendaModel agendaModel, int id)
        {
            var validationResult = _validator.Validate(agendaModel);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors.ToAgendaValidationFailure());
            }
            AgendaModel userUpdated = await _agendaRepository.Update(agendaModel, id);
            return userUpdated;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<AgendaModel>> DeleteContact(int id)
        {
            bool contactDeleted = await _agendaRepository.Delete(id);
            return Ok(contactDeleted);
        }
    }
}