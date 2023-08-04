using CouncilVoting.Application.Repositories;
using CouncilVoting.Infrastructure.Persistance;
using CouncilVoting.Infrastructure.Respositories;
using Microsoft.EntityFrameworkCore;
using SampleAssignment.Api.Containers;

namespace CouncilVoting.Api.Containers
{
    /// <summary>
    ///     Persistence service registartion
    /// </summary>
    public class RegisterPersistanceService : IServiceRegistration
    {
        /// <summary>
        ///     Register persistance to service collection
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public void RegisterAppServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CouncilVotingContext>(options =>
            {
                options.UseSqlServer(configuration["ConnectionStrings:SqlDb"]);
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IMeasureRepository, MeasureRepository>();
            services.AddScoped<IVotingRepository, VotingRepository>();
        }
    }
}
