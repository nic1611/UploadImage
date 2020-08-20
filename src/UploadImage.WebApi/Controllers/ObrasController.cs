using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UploadImage.WebApi.ViewModel;

namespace UploadImage.WebApi.Controllers
{
    [Route("/")]
    [ApiController]
    public class ObrasController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return Ok(new { nome = "Quadro A" });
        }

        [HttpPost("/novo")]
        public ActionResult Create(ObraViewModel obra)
        {
            return Ok(obra);
        }

        [HttpDelete("/remover/{id:int}")]
        public ActionResult Delete(int id)
        {
            return Ok(new { nome = "Quadro A" });
        }
    }
}