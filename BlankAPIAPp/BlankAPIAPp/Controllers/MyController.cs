using Microsoft.AspNetCore.Mvc;

namespace BlankAPIAPp.Controllers
{
    [ApiController]
    [Route ("api/my")]
    public class MyController : ControllerBase
    {
        //HTTP verb: HTTPGet, HTTPPost,HTTPPut, HTTPPatch, HTTPDelete
                        
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(
                new List<object>()
                {
                    new {id = 1, Name = "MK Hasan" },
                    new {id = 2, Name = "Homaiyen Kabir" },
                    new {id = 3, Name = "Ruhul Amin" },
                    new {id = 4, Name = "Rashedul Islam" },
                    new {id = 5, Name = "Topu Bishaw" },
                    new {id = 6, Name = "Shahrier Kabir" },
                    
                }
                );
        }
    }
}
