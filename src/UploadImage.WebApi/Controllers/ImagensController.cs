using Microsoft.AspNetCore.Mvc;
using UploadImage.WebApi.ViewModel;

namespace UploadImage.WebApi.Controllers
{
    [Route("/")]
    [ApiController]
    public class ImagensController : ControllerBase
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return Ok(new { nome = "Quadro A" });
        }

        [HttpPost("/novo")]
        public ActionResult Create(ImagemViewModel imagem)
        {
            return Ok(imagem);
        }

        [HttpDelete("/remover/{id:int}")]
        public ActionResult Delete(int id)
        {
            return Ok(new { nome = "Quadro A" });
        }
    }
}