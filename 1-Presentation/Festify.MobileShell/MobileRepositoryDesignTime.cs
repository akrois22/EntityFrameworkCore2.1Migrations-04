using Festify.MobileRepository;
using Festify.MobileRepository.Explore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Festify.MobileShell
{
    public class MobileRepositoryDesignTime : IDesignTimeDbContextFactory<ExploreContext>
    {
        public ExploreContext CreateDbContext(string[] args)
        {
            // Configure a service provider.
            var serviceCollection = new ServiceCollection();
            Startup.ConfigureServices(serviceCollection, "Data Source=Festify.db3");
            var serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider.GetService<ExploreContext>();
        }
    }
}
