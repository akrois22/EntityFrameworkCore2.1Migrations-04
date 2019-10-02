using Festify.MobileRepository.Explore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Festify.MobileRepository
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection serviceCollection,
            string connectionString)
        {
            serviceCollection.AddDbContext<ExploreContext>(opt => 
                opt.UseSqlite(connectionString));
        }
    }
}
