using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ECommWebApp.Data;
using ECommWebApp.Models;
using ECommWebApp.Repository;
using ECommWebApp.Repository.Generic;
using ECommWebApp.Repository.CustomerRepo;
using ECommWebApp.Repository.OrderItemRepo;
using ECommWebApp.Repository.ProductRepo;
using ECommWebApp.Repository.OrderRepo;

var builder = WebApplication.CreateBuilder(args);

// Injecting Entity Framework context
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DB") ?? throw new InvalidOperationException("Connection string not found.")));



// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
//whenever a ICustomerRepository is required, create a CustomerRepository and pass that in i.e, injection
builder.Services.AddScoped(typeof(ICustomerRepository), typeof(CustomerRepository));
builder.Services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
builder.Services.AddScoped(typeof(IOrderRepository), typeof(OrderRepository));
builder.Services.AddScoped(typeof(IOrderItemRepository), typeof(OrderItemRepository));


// Add the database context to the DI container.
//builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("Web_EF"));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
} else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}


app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
