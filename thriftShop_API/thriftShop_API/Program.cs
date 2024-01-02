using AutoMapper;
using Microsoft.EntityFrameworkCore;
using thriftShop_API.Data;
using thriftShop_API.Models.DAO;
using thriftShop_API.Repositories;
using thriftShop_API.Repositories.Impl;
using thriftShop_API.Services;
using thriftShop_API.Services.Impl;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ThriftShopContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("ThriftDb"))
);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

/*using(var scope = app.Services.CreateScope())
{
    var salesContext = scope.ServiceProvider.GetRequiredService<ThriftShopContext>();
    salesContext.Database.EnsureCreated();
    salesContext.Products.Add(new Product()
    {
        Description = "teste",
        Name = "teste",
        Id = 1,
        Price = 10,
        Quantity = 1,
        ActualPrice = 12
    });
    salesContext.SaveChanges();
}*/

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