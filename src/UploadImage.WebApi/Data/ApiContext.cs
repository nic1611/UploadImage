using Microsoft.EntityFrameworkCore;
using UploadImage.WebApi.ViewModel;

namespace UploadImage.WebApi.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
          : base(options)
        { }

        public DbSet<ImagemViewModel> Usuarios { get; set; }
    }
}