using CadastroUsuario.Infrastructure.Context;
using CadastroUsuario.Infrastructure.Interfaces;
using CadastroUsuario.Infrastructure.Repositories;
using CadastroUsuarios.Application.Interfaces;
using CadastroUsuarios.Application.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Atividade_BancoSQL
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
            services.AddDbContext<CadastroUsuarioContext>(options =>
            {
                options.UseSqlite("Data Source=C:\\Users\\cristina.priester\\Desktop\\CadastroUsuario.db");
            });

            services.AddScoped<ICadastroUsuarioService, CadastroUsuarioService>();
            services.AddScoped<ICadastroUsuarioRepository, CadastroUsuarioRepository>();

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Atividade_BancoSQL", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Atividade_BancoSQL v1"));
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
