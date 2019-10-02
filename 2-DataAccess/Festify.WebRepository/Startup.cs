using Festify.WebRepository.Explore;
using Festify.WebRepository.Plan;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Festify.WebRepository
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection serviceCollection,
            string connectionString)
        {
            serviceCollection.AddDbContext<ExploreContext>(opt =>
                opt.UseSqlServer(connectionString));
            serviceCollection.AddDbContext<PlanContext>(opt =>
                opt.UseSqlServer(connectionString));
        }
    }
}
