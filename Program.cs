var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// es el constructor de la app, la cual se va a contruir a partir 
// de los servicios que vamos a registrar en el builder
var app = builder.Build();

app.MapOpenApi();
app.Run();
