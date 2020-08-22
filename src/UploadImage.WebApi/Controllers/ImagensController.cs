using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UploadImage.WebApi.Data;
using UploadImage.WebApi.ViewModel;

namespace UploadImage.WebApi.Controllers
{
    [Route("/")]
    [ApiController]
    public class ImagensController : ControllerBase
    {
        public readonly ApiContext _context;

        public ImagensController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet("/")]
        public ActionResult Index()
        {
            try
            {
                var imagens = _context.Imagens.ToList();
                return Ok(imagens);
            }
            catch (System.Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost("/novo")]
        public ActionResult Create(ImagemViewModel imagem)
        {
            _context.Imagens.Add(imagem);
            _context.SaveChanges();
            var response = imagem;
            return Ok(response);
        }

        [HttpDelete("/remover/{id:int}")]
        public ActionResult Delete(int id)
        {
            var imagem = _context.Imagens.First(e => e.Id == id);
            if (imagem == null)
            {
                return BadRequest();
            }
            _context.Imagens.Remove(imagem);
            _context.SaveChanges();

            return Ok();
        }
    }
}