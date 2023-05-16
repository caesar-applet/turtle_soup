using Furion;
using Microsoft.Extensions.DependencyInjection;

namespace turtle_soup.EntityFramework.Core
{
    public class Startup : AppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseAccessor(options =>
            {
                options.AddDbPool<DefaultDbContext>();
            }, "turtle_soup.Database.Migrations");
        }
    }
}