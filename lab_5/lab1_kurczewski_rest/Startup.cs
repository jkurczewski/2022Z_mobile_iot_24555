using Microsoft.EntityFrameworkCore;

namespace lab1_kurczewski_rest {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) {
            services.AddMvc();
            services.AddDbContext<AzureDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("AzureDb")));
        }
    }
}
