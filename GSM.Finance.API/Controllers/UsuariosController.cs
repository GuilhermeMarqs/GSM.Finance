using Microsoft.AspNetCore.Mvc;

namespace GSM.Finance.API.Controllers
{
    [ApiController]
    [Route("Usuarios")]
    public class UsuariosController : ControllerBase
    {
        public ActionResult Get() 
        {
            return Ok(true);
        }
    }
}
