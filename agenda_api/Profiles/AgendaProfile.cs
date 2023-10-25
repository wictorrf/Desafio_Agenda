using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agenda_api.Models;
using Agenda_proj.Models;
using AutoMapper;

namespace agenda_api.Profiles
{
    public class AgendaProfile : Profile
    {
        public AgendaProfile()
        {
            CreateMap<AgendaInputModel, AgendaModel>();
            CreateMap<AgendaModel, AgendaViewModel>();
        }
    }
}