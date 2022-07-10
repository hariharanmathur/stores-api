using Microsoft.Data.SqlClient;
using Stores.API.context;
using Stores.Contract.Inferfaces;
using Stores.Contract.Repository;
using Stores.DAL;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IDbConnection>((sp)=> new SqlConnection(builder.Configuration.GetConnectionString("DBConnection")));
builder.Services.AddScoped<IDapperGenericRepository, DapperGenericRespository>();
builder.Services.AddTransient<IBrand, BrandRepository>();
builder.Services.AddTransient<ICategories, CategoriesRepository>();
builder.Services.AddTransient<IJobStatus, JobStatusRepository>();
builder.Services.AddTransient<IServiceList, ServiceListRepository>();
builder.Services.AddTransient<IProduct, ProductRepository>();
builder.Services.AddTransient<IRoles, RolesRepository>();
builder.Services.AddTransient<IUserDetails, UserDetailsRepository>();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
