using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {            
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            //aparece a mensagem de erro
            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();
            
        }
        
    }
}