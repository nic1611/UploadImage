
using System.ComponentModel.DataAnnotations;

namespace UploadImage.WebApi.ViewModel
{
    public class ImagemViewModel
    {
        [Key]
        public int Id {get; set;}
        public string Nome { get; set; }
        public string Imagem { get; set; }
    }
}