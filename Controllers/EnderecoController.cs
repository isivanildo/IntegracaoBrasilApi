using Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEndereco _endereco;

        public EnderecoController(IEndereco endereco)
        {
            _endereco = endereco;
        }

        [HttpGet("busca/{cep}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscaEndereco([FromRoute] string cep) 
        {
            var response = await _endereco.BuscarEndereco(cep);

            if (response.CodigoHttp == HttpStatusCode.OK) 
            {
                return Ok(response.DadosRetornados);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetornado);
            }
        }
    }
}