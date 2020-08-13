using Microsoft.AspNetCore.Http;

namespace UploadImage.WebApi.ViewModel
{
    public class ObraViewModel
    {
        public string Nome;
        public IFormFile Imagem;   
    }
}