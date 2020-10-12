using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OdeToFood.Data;

namespace OdeToFood
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContextPool<OdeToFoodDbContext>(options =>
      {
        options.UseSqlServer(Configuration.GetConnectionString("OdeToFoodDb"));
      });

      //Below is with an actual database
      services.AddScoped<IRestaurantData, SqlRestaurantData>();
      //This is for IIS purposes
      //services.AddScoped<IRestaurantData, InMemoryRestaurantData>();

      services.Configure<CookiePolicyOptions>(options =>
      {
        // This lambda determines whether user consent for non-essential cookies is needed for a given request.
        options.CheckConsentNeeded = context => true;
        options.MinimumSameSitePolicy = SameSiteMode.None;
      });

      //aspnetcore 2.0
      //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
      // aspnetcore30
      services.AddRazorPages();
      services.AddControllers();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler("/Error");
        app.UseHsts();
      }


      app.Use(SayHelloMiddleware);
      app.UseHttpsRedirection();
      app.UseStaticFiles();
      app.UseNodeModules();
      app.UseCookiePolicy();

      //app.UseMvc();
      // aspnetcore30
      app.UseRouting();
      app.UseEndpoints(e =>
      {
        e.MapRazorPages();
        e.MapControllers();
      });
    }

    private RequestDelegate SayHelloMiddleware(RequestDelegate next)
    {
      return async ctx =>
      {
        if (ctx.Request.Path.StartsWithSegments("/hello"))
        {
          await ctx.Response.WriteAsync("Hello, World!");
        }
        else
        {
          await next(ctx);
        }
      };
    }
  }
}
