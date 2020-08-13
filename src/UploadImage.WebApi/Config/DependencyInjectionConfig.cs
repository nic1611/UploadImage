using Microsoft.Extensions.DependencyInjection;

namespace UploadImage.WebApi.Config
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            return services;
        }
    }
}