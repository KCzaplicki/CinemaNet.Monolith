using CinemaNet.Api;
using CinemaNet.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseCors(policy =>
    {
        policy.WithOrigins("http://localhost:4200")
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
    app.UseSwagger();
    app.UseSwaggerUI();
}

await app.CreateDatabaseIfNotExists();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();