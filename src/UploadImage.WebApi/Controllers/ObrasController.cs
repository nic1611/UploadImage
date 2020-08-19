using Microsoft.AspNetCore.Mvc;
using UploadImage.WebApi.ViewModel;

namespace UploadImage.WebApi.Controllers
{
    public class ObrasController : ControllerBase
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return Ok(new {nome="Quadro A"});
        }

        [HttpPost("/novo")]
        public ActionResult Create([FromBody] ObraViewModel obra)
        {
            return Ok(new {nome="Quadro A"});
        }

        [HttpDelete("/remover/{id:int}")]
        public ActionResult Delete(int id)
        {
            return Ok(new {nome="Quadro A"});
        }
    }
}