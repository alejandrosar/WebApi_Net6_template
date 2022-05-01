using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

namespace BuilderConfigurator
{
    public class AppConfigurator
    {
        public static WebApplication AppConfigure(WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            return app;
        }
    }
}
