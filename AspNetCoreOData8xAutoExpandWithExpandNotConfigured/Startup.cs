using AspNetCoreOData8xAutoExpandWithExpandNotConfigured.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.OData;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OData.ModelBuilder;

namespace AspNetCoreOData8xAutoExpandWithExpandNotConfigured
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var modelBuilder = new ODataConventionModelBuilder();
            modelBuilder.EntitySet<Customer>("Customers");
            modelBuilder.EntitySet<Order>("Orders");

            services.AddControllers().AddOData(
                options => options.AddRouteComponents("odata", modelBuilder.GetEdmModel()));
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
