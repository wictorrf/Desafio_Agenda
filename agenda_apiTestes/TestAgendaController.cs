using Agenda_proj.Controllers;
using Agenda_proj.Repositories.Interfaces;
using Agenda_proj.Models.Validations;
using Agenda_proj.Models.Validations.Error;
using Agenda_proj.Models;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using Xunit;

namespace agenda_apiTestes
{
    public class TestAgendaController
    {
        private AgendaController _agendaControl;
        public TestAgendaController()
        {
            var agendaRepositoryMock = new Mock<IAgendaRepository>();
            var validatorMock = new Mock<IValidator<AgendaModel>>();
            
            _agendaControl = new AgendaController(agendaRepositoryMock.Object, validatorMock.Object);
        }

        [Fact]
        public async Task TestGetAllContacts()
        {
            var resultado = await _agendaControl.GetAllContacts();
            Assert.IsType<ActionResult<List<AgendaModel>>>(resultado);
            Assert.True((resultado.Result as ObjectResult).StatusCode == 200);
        }
    }
}
