using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GimatriB : ControllerBase
    {
        BLL.Funcs g = new BLL.Funcs();
        [HttpGet("{word}")]
        public List<DOT.Pasuk> Get(string word)
        {
            return g.listGimatri(word);
        }
    }
}
