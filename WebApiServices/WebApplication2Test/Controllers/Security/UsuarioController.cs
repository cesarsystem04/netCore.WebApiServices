using Microsoft.AspNetCore.Mvc;
using CARSO.AppService;
using CARSO.AppService.ServiceDataContainers;
using CARSO.AppService.Provider.Service;
using CARSO.AppService.Provider.Service.Operations.Request;
using CARSO.LogLibrary.AppService;
using CARSO.LogLibrary.ServiceOperations;
using System.Configuration;

namespace WebApplication2Test.Controllers.Security
{

    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {

        private readonly ILogger<UsuarioController> _logger;
        private readonly AppService _app;


        public UsuarioController(ILogger<UsuarioController> logger)
        {

            _logger = logger;
            _app = new AppService();
        }



        [HttpPost("GetUsuariosTest")]
        public IActionResult GetUsuariosTest(UsuarioRequest request)
        {
            CARSO.AppService.ServiceDataContainers.Usuario usuarioTest = new CARSO.AppService.ServiceDataContainers.Usuario();
            //AppService app = new AppService();
            _app.GetUsuarioByKey(request.nbAliasUsuario, ref usuarioTest);
            return Ok(usuarioTest);

        }


        [HttpPost("GetFuncionalidadByUsuario")]
        public IActionResult GetFuncionalidadByUsuario(UsuarioRequest request)
        {
            string appCode = System.Configuration.ConfigurationManager.AppSettings["AppCode"];
            try
            {
                CARSO.AppService.ServiceDataContainers.FuncionalidadList oFuncionalidadList = new CARSO.AppService.ServiceDataContainers.FuncionalidadList();
                _app.GetFuncionalidadByUsuario(request.nbAliasUsuario, request.codAplicacion, ref oFuncionalidadList);
                List<CARSO.AppService.ServiceDataContainers.Funcionalidad> funcionalidad = new List<CARSO.AppService.ServiceDataContainers.Funcionalidad>();

                oFuncionalidadList.lstFuncionalidad.ForEach(f => 
                {
                    funcionalidad.Add(f);
                });

                return Ok(funcionalidad);
            }
            catch (Exception ex)
            {
                _app.Log("GetFuncionalidadByUsuario", ex.Message, appCode);
                return BadRequest(ex.Message);
            }

        }






    }
}

