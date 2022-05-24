using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvajal.generate.Application
{
    public static class DependencyContainers
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //ToDo: Inject your inputports and usecases

            return services;
        }
    }
}
