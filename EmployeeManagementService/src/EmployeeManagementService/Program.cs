using EmployeeManagementService.Infrastructure;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.RegisterSwagger();
builder.Services.RegisterCors();
builder.Services.RegisterApiVersioning();

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
