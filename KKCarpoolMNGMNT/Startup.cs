using Carpool.Application.Services;
using KKCarpoolMNGMNT.Interfaces;
using KKCarpoolMNGMNT.Models;
using KKCarpoolMNGMNT.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;

namespace KKCarpoolMNGMNT
{
	public class Startup
	{
		private readonly IConfiguration _config;

		public Startup(IConfiguration config)
		{
			_config = config;
		}
		public void ConfigureServices(IServiceCollection services)
		{
			services.Configure<CookiePolicyOptions>(options =>
			{
				options.CheckConsentNeeded = context => true;
				options.MinimumSameSitePolicy = SameSiteMode.None;
			});

			services.AddScoped<IEmployeeRepo, MockEmployeeRepo>();
			services.AddScoped<IEmployeeService, EmployeeService>();

			services.AddScoped<ICarsRepo, MockCarsRepo>();
			services.AddScoped<ICarService, CarService>();

			services.AddSingleton<ITravelPlanRepository, MockTravelPlanRepo>();
			services.AddSingleton<ITravelPlanService, TravelPlanService>();

			services.AddSession();
			services.AddHttpContextAccessor();
			services.AddRazorPages();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/error");
			}

			app.UseStaticFiles();
			app.UseHttpsRedirection();
			app.UseRouting();
			app.UseEndpoints(cfg =>
			{
				cfg.MapControllerRoute(
					"Fallback",
					"{controller}/{action}/{id?}",
				   new { controller = "Home", action = "Index" });

				cfg.MapRazorPages();
			});

		}








	}
}
