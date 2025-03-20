using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tanach : ControllerBase
    {
        BLL.Funcs f = new BLL.Funcs();

        [HttpGet]
        public List<DOT.Location> Get(string word)
        {
            return f.findLocations(word);
        }
    }
}
