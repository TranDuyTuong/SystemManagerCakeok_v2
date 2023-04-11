using Library.DataTable.TableRole;
using Library.DataTable.TableUser;
using Library.DomainData.DataEF;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Library.Repository;
using Library.ServiceAdmin;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//call connectionstring database
builder.Services.AddDbContext<ContextDBCakeOk>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DB_CakeOk")));

builder.Services.AddRepository();
builder.Services.AddSerivceAdmin();

builder.Services.AddIdentity<T_User, T_Role>()
    .AddEntityFrameworkStores<ContextDBCakeOk>()
    .AddDefaultTokenProviders();

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
