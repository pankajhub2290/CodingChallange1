using Microsoft.OpenApi.Models;
using SampleAssignment.Api.Containers;

namespace CouncilVoting.Api.Containers
{
    /// <summary>
    ///     Register swagger
    /// </summary>
    public class RegisterSwagger : IServiceRegistration
    {
        /// <summary>
        ///     Swagger registration to service collection
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public void RegisterAppServices(IServiceCollection services, IConfiguration configuration)
        {
            //Register Swagger
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Council Voting API", Version = "v1" });
                options.CustomSchemaIds(type => type.ToString());

            });
        }
    }
}
