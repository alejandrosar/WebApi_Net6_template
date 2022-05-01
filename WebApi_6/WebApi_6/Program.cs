
using BuilderConfigurator;

var builder = WebApplication.CreateBuilder(args);


var app = BuilderServices.AddServiceDependencies(builder);

// Configure the HTTP request pipeline.

app = AppConfigurator.AppConfigure(app);



app.Run();
