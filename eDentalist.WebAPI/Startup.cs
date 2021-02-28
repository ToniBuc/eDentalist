using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Database;
using eDentalist.WebAPI.Filters;
using eDentalist.WebAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace eDentalist.WebAPI
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
            services.AddControllers();
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "eDentalist API", Version = "v1" });
            });

            //services.AddScoped<IMaterialService, MaterialService>();

            services.AddScoped<IService<Model.Country, object>, BaseService<Model.Country, object, Country>>();
            services.AddScoped<IService<Model.EquipmentType, object>, BaseService<Model.EquipmentType, object, EquipmentType>>();
            services.AddScoped<IService<Model.HygieneProcessType, object>, BaseService<Model.HygieneProcessType, object, HygieneProcessType>>();
            services.AddScoped<IService<Model.UserRole, object>, BaseService<Model.UserRole, object, UserRole>>();

            services.AddScoped<ICRUDService<Model.Material, MaterialSearchRequest, MaterialUpsertRequest, MaterialUpsertRequest>, MaterialService>();
            services.AddScoped<ICRUDService<Model.Equipment, EquipmentSearchRequest, EquipmentUpsertRequest, EquipmentUpsertRequest>, EquipmentService>();
            services.AddScoped<ICRUDService<Model.Procedure, ProcedureSearchRequest, ProcedureUpsertRequest, ProcedureUpsertRequest>, ProcedureService>();
            services.AddScoped<ICRUDService<Model.HygieneProcess, HygieneProcessSearchRequest, HygieneProcessUpsertRequest, HygieneProcessUpsertRequest>, HygieneProcessService>();
            services.AddScoped<ICRUDService<Model.Requisition, RequisitionSearchRequest, RequisitionUpsertRequest, RequisitionUpsertRequest>, RequisitionService>();
            services.AddScoped<ICRUDService<Model.City, CitySearchRequest, CityUpsertRequest, CityUpsertRequest>, CityService>();
            //services.AddScoped<ICRUDService<Model.Workday, WorkdaySearchRequest, WorkdayUpsertRequest, WorkdayUpsertRequest>, WorkdayService>();
            services.AddScoped<ICRUDService<Model.Bill, BillSearchRequest, BillUpsertRequest, BillUpsertRequest>, BillService>();

            //var connection = @"Server=DESKTOP-ECJHPDM\MSSQLSERVER_OLAP;Database=eDentalist;User ID=;password=;ConnectRetryCount=0";
            //services.AddDbContext<eDentalistDbContext>(options => options.UseSqlServer(connection));
            //services.AddDbContext<eDentalistDbContext>(options => options.UseSqlServer("eDentalist2"));

            var connection = @"Server=DESKTOP-ECJHPDM\MSSQLSERVER_OLAP;Database=eDentalist;Trusted_Connection=True";
            services.AddDbContext<eDentalistDbContext>(options => options.UseSqlServer(connection));
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "eDentalist");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
