using Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DadosEmpresaController : ControllerBase
    {
        private readonly IDadosEmpresa _dadosEmpresa;

        public DadosEmpresaController(IDadosEmpresa dadosEmpresa)
        {
            _dadosEmpresa = dadosEmpresa;
        }

        [HttpGet("busca/empresa/{cnpj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscaEmpresa([FromRoute] string cnpj) 
        {
            var empresa = await _dadosEmpresa.BuscaEmpresa(cnpj);

            if (empresa.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(empresa.DadosRetornados);
            }
            else
            {
                return StatusCode((int)empresa.CodigoHttp, empresa.ErroRetornado);
            }
        }

    }
}