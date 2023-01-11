using Aplicacion.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApiServices.Api;

namespace WebApiServices.Api.v1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : BaseApiController<UsuarioController>
    {


        [HttpGet("GetUsuarioAll")]
        public async Task<IActionResult> GetUsuarioAll()
        {
            var usuarios = await Mediator.Send(new GetUsuarioQuery());
            return Ok(usuarios);
        }


    }
}
