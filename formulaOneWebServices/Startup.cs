using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace formulaOneWebServices
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Le possibili api per tabella sono:\n\nCOUNTRY\n/api/country --> restituisce l'intera tabella country\n/api/country/{id} --> Restituisce il record corrispondente all'ID inserito\n" +
                        "\nTEAM\n/api/team --> restituisce l'intera tabella team\n/api/team/{id} --> Restituisce il record corrispondente all'ID inserito\n" +
                        "\nDRIVER\n/api/driver --> restituisce l'intera tabella driver\n/api/driver/{id} --> Restituisce il record corrispondente all'ID inserito\n");
                });
                endpoints.MapControllers();
            });
        }
    }
}
