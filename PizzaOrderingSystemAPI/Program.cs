using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PizzaOrderingSystemAPI.DBContext;
using PizzaOrderingSystemAPI.Middeleware;
using PizzaOrderingSystemAPI.Models.DeliveryEmployee;
using PizzaOrderingSystemAPI.Repository;
using PizzaOrderingSystemAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Accessing the Database connection String 
builder.Services.AddDbContext<PizzaOrderingSystemAPI_DbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PizzaOrderingSystemAPIConnectionString")
));

// Register repository and service classes
builder.Services.AddScoped<CustomerRepository>();
builder.Services.AddScoped<CustomerService>();
builder.Services.AddScoped<DeliveryEmployeeRepository>();
builder.Services.AddScoped<DeliveryEmployeeService>();
builder.Services.AddScoped<OrderRepository>();
builder.Services.AddScoped<OrderService>();
builder.Services.AddScoped<PizzaRepository>();
builder.Services.AddScoped<PizzaService>();
// Register Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<RequestLoggerMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
