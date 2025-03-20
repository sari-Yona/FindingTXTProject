using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tanach : ControllerBase
    {
        BLL.Funcs f = new BLL.Funcs();

        [HttpGet("{word},{index}")]
        public List<DOT.Pasuk> Get(string word,int index)
        {
            return f.findPsukim(word,index);
        }

 
    }
}
