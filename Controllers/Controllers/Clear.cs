using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Clear : ControllerBase
    {
        Funcs funcs = new Funcs();
        [HttpGet]
        public void Get()
        {
            funcs.on_close();
        }
    }
}
