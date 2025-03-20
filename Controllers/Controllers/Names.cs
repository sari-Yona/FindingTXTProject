using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Names : ControllerBase
    {
        BLL.Funcs f = new BLL.Funcs();
        [HttpGet("{word}")]
        public List<DOT.Pasuk> GetName(string word)
        {
            return f.findPsukimForNames(word);
        }
    }
}
