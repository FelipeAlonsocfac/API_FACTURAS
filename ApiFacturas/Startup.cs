using ApiFacturas.DataAcces;
using ApiFacturas.Repository;
using ApiFacturas.Services;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturas
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
            //dbacces
            services.AddTransient<IDBContext, DBContext>();
            //services
            services.AddTransient<IDetalleFacturaService, DetalleFacturaService>();
            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<IEmpresaService, EmpresaService>();
            services.AddTransient<IEncabezadoFacturaService, EncabezadoFacturaService>();
            services.AddTransient<IProductoService, ProductoService>();
            services.AddTransient<ISedeService, SedeService>();
            services.AddTransient<IImpuestoService, ImpuestoService>(); 
            //repos
            services.AddTransient<IProductoRepository, ProductoRepository>();
            services.AddTransient<IImpuestoRepository, ImpuestoRepository>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IDetalleFacturaRepository, DetalleFacturaRepository>();
            services.AddTransient<IEmpresaRepository, EmpresaRepository>();
            services.AddTransient<IEncabezadoFacturaRepository, EncabezadoFacturaRepository>();
            services.AddTransient<ISedeRepository, SedeRepository>();

            services.AddDbContext<DBContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                );
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "FacturasAPI",
                    Version = "v1",
                    Description = "API para factura",
                    Contact = new OpenApiContact
                    {
                        Name = "Carlos Alonso",
                        Email = "xfelipe98@gmail.com",
                    }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiFacturas v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
