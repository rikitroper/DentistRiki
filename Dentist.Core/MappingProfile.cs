using AutoMapper;
using Dentist.Core.DTOs;
using System;
using System.Collections.Generic;
using Dentist.Core.Entities;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using dentist;

namespace Dentist.Core
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Patient, PatientDto>().ReverseMap();
            CreateMap<turn,TurnPatientDto>().ReverseMap();
        }
    }
}
