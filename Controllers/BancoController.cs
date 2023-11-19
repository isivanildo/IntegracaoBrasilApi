using Microsoft.AspNetCore.Mvc;
using System.Net;
using Services;
using System.ComponentModel.DataAnnotations;
using Interfaces;

namespace Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BancoController : ControllerBase
    {
        private readonly IBanco _bancoService;
        
        public BancoController(IBanco bancoService)
        {
            _bancoService = bancoService;
        }

        [HttpGet("busca/todosbancos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscaTodosBancos()
        {
            var banco = await _bancoService.BuscaTodosBancos();

            if (banco.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(banco.DadosRetornados);
            }
            else
            {
                return StatusCode((int)banco.CodigoHttp, banco.ErroRetornado);
            }
        }

        [HttpGet("busca/banco/{codigoBanco}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarBanco([RegularExpression("^[0-9]*$")]string codigoBanco)
        {
            var banco = await _bancoService.BuscarBanco(codigoBanco);
            
            if (banco.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(banco.DadosRetornados);
            }
            else
            {
                return StatusCode((int)banco.CodigoHttp, banco.ErroRetornado);
            }
        }
    }
}