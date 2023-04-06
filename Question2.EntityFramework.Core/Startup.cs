using Furion;
using Microsoft.Extensions.DependencyInjection;

namespace Question2.EntityFramework.Core
{
    public class Startup : AppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseAccessor(options =>
            {
                options.AddDbPool<DefaultDbContext>();
            }, "Question2.Database.Migrations");
        }
    }
}