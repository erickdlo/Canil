using Microsoft.AspNetCore.Mvc;
using System;
using Canil_Eduardo.Modelos;
using Canil_Eduardo.Services;

namespace Canil_Eduardo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CanilController : ControllerBase
    {
        [HttpGet]
        [Route("melhor-canil")]
        public ActionResult ObterMelhorCanil([FromQuery] string data, [FromQuery] int caesP, [FromQuery] int caesG)
        {
            CanilNegocio negCanil = new CanilNegocio();
            try
            {   
                MelhorCanil retorno = negCanil.BuscarMelhorCanil(data, caesP, caesG);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                Erro error = new Erro
                {
                    Mensagem = ex.Message
                };
                return BadRequest(error);
            }
        }

    }
}
