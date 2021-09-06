using API.Dtos;
using API.Interfaces;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;
        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }

        [HttpPost("weapon")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> WeaponAttack(WeaponAttackDto request)
        {
            return (await _fightService.WeaponAttack(request));
        }

        [HttpPost("skill")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> SkillAttack(SkillAttackDto request)
        {
            return (await _fightService.SkillAttack(request));
        }

        [HttpPost("fight")]
        public async Task<ActionResult<ServiceResponse<FightResultDto>>> Fight(FightRequestDto request)
        {
            return (await _fightService.Fight(request));
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<HighScoreDto>>>> GetHighscores()
        {
            return (await _fightService.GetHighScore());
        }
    }
}
