using EmployeeManagementService.Infrastructure;
using EmployeeManagementService.Infrastructure.External;
using EmployeeManagementService.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.RegisterSwagger();
builder.Services.RegisterCors();
builder.Services.RegisterApiVersioning();
builder.Services.RegisterPersistenceDependencies(builder.Configuration);
builder.Services.RegisterExternalDependencies();

builder.Services.RegisterLogging();

var app = builder.Build();

app.UseHttpLogging();

app.UseCors(policyBuilder =>
{
    policyBuilder.AllowAnyHeader();
    policyBuilder.AllowAnyMethod();
    policyBuilder.AllowAnyOrigin();
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
