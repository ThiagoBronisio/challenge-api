using ChallengeHackathon.Domain.Interfaces.Services;
using ChallengeHackathon.Domain.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeHackathon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancaController : ControllerBase
    {
        private readonly IFinancaDomainService _financaDomainService;

        public FinancaController(IFinancaDomainService financaDomainService)
        {
            _financaDomainService = financaDomainService;
        }

        [HttpGet]
        [Route("dashboard")]
        public IActionResult GetDashboard()
        {
            try
            {
                _financaDomainService.GetData();

                return Ok();
            }
            catch(Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }
    }
}
