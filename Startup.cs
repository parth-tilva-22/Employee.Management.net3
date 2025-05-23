using Employee.Management.dotnet3.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Management.dotnet3 {
  public class Startup {
    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services) {
      services.AddMvc(options => options.EnableEndpointRouting = false)
        .AddXmlSerializerFormatters();
      services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
      if (env.IsDevelopment()) {
        app.UseDeveloperExceptionPage();
      }

      app.UseStaticFiles();

      //app.UseMvcWithDefaultRoute();

      app.UseMvc(routes => {
          routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
      });


      app.UseRouting();


      app.UseEndpoints(endpoints => {
        endpoints.MapGet("/", async context => {
          //throw new Exception("exception manually throwing");
          await context.Response.WriteAsync("Hello World!");
        });
      });
    }
  }
}
