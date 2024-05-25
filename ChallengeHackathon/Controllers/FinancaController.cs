using ChallengeHackathon.Domain.Interfaces.Services;
using ChallengeHackathon.Domain.Service;
using ChallengeHackathon.DTOs;
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
        [Route("Despesas")]
        [ProducesResponseType(typeof(List<DespesaGetResponseDTO>), 200)]
        public IActionResult GetDespesas()
        {
            try
            {
                var model = _financaDomainService.GetDataDespesa();

                return Ok(model);
            }
            catch(Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        [HttpGet]
        [Route("ClienteData")]
        [ProducesResponseType(typeof(List<ClienteGetResponseDTO>), 200)]
        public IActionResult GetPessoaData()
        {
            try
            {
                var model = _financaDomainService.GetData();

                return Ok(model);
            }
            catch (Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }
    }
}
