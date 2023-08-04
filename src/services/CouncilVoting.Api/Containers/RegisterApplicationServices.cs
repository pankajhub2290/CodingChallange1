using CouncilVoting.Application.Commands.CreateMeasure;
using SampleAssignment.Api.Containers;
using System.Reflection;

namespace CouncilVoting.Api.Containers
{
    /// <summary>
    ///     Application service registration
    /// </summary>
    public class RegisterApplicationServices : IServiceRegistration
    {
        /// <summary>
        ///     Register application to service collection
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public void RegisterAppServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(serviceConfiguration =>
            serviceConfiguration.RegisterServicesFromAssemblies(new[] { typeof(CreateMeasureCommandHandler).Assembly }));
        }
}
}
