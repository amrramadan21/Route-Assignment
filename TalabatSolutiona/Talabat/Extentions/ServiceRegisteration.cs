using Microsoft.AspNetCore.Mvc;
using Talabat.Factories;

namespace Talabat.Extentions
{
    public static class ServiceRegisteration
    {
        public static IServiceCollection AddSwaggerService(this IServiceCollection Services)
        {

            Services.AddEndpointsApiExplorer();
            Services.AddSwaggerGen();
            return Services;
        }

        //private static void ConfigureJWT(this IServiceCollection services,IConfiguration configuration)
        //{
        //    var jwt = configuration.GetSection("JwtOtions").Get<JWTOptions>;
        //}

        public static IServiceCollection AddWebApplicationService(this IServiceCollection Services)
        {
            Services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = ApiResponseFactory.GenerateApiValidationErrorRequest;

            });
            return Services;
        }
    }
}
