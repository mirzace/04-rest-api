using API.Dtos;
using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using API.Models;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighScoreDto>();
        }
    }
}
