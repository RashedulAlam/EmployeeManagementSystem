using EmployeeManagementService.Business;
using EmployeeManagementService.Infrastructure;
using EmployeeManagementService.Infrastructure.External;
using EmployeeManagementService.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddHttpClient();
builder.Services.RegisterSwagger();
builder.Services.RegisterCors();
builder.Services.RegisterApiVersioning();
builder.Services.RegisterPersistenceDependencies(builder.Configuration);
builder.Services.RegisterExternalDependencies();
builder.Services.RegisterExceptionHandlers();
builder.Services.RegisterAutomapper();
builder.Services.RegisterBusinessDependencies();

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

// app.UseExceptionHandler();

app.MapControllers();

app.Run();
