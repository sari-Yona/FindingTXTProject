using DOT;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class lastSearch : ControllerBase
    {
        BLL.Funcs f=new BLL.Funcs();
        [HttpGet]
        public ActionResult Get()
        {
            List<Search> searches = f.showLastSearches();

            if (searches != null)
            {
                return Ok(searches);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
