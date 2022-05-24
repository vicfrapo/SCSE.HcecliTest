//using IBM.EntityFrameworkCore;
using IBM.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SCSE.HcecliTest.ORM
{
    public static class DependencyContainers
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, ApplicationContext settings)
        {
            var provider = settings.Provider;
            string? connectionString = settings.ConnectionString;

            switch (provider)
            {
                case "Oracle":
                    services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseOracle(connectionString, b => b.UseOracleSQLCompatibility("11")));
                    break;

                case "Informix":
                    services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseDb2(connectionString, p =>
                    {
                        p.SetServerInfo(IBMDBServerType.IDS, IBMDBServerVersion.IDS_11_70_7300);
                        p.MaxBatchSize(1);
                    }));
                    break;

                case "SqlServer":
                    services.AddDbContext<ApplicationDbContext>(options =>
                  options.UseSqlServer(connectionString));
                    break;

                case "PostgreSQL":
                    services.AddDbContext<ApplicationDbContext>(options =>
                 options.UseNpgsql(connectionString));
                    break;
                case "NoSql":
                    break;
            }

            services.AddScoped<DbContext, ApplicationDbContext>();
            //services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

            // ToDo: Inject your repositories

            //services.AddScoped<IYourRepository, YourRepository>();


            return services;
        }
    }
}
