using CoffeeShopWeb.Service;
using CoffeeShopWeb.Services.IServices;
using CoffeeShopWeb.Utility;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWeb
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
            services.AddHttpContextAccessor();
            services.AddHttpClient();
            services.AddHttpClient<ICouponService, CouponService>();
            services.AddHttpClient<IProductService, ProductService>();
            services.AddControllersWithViews();
            services.AddScoped<IBaseService, BaseService>();
            services.AddScoped<ICouponService, CouponService>();
            services.AddScoped<IProductService, ProductService>();

            StaticDetail.CouponAPIBase = Configuration["ServiceUrls:CouponAPI"];
            StaticDetail.ProductAPIBase = Configuration["ServiceUrls:ProductAPI"];

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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Coupon}/{action=CouponIndex}/{id?}");
            });

        }
    }
}
