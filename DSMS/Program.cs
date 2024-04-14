using DSMS.Context;
using DSMS.Repositories;
using DSMS.Services;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Patient DI
builder.Services.AddScoped<IPatientRepository, PatientRepositoryImp>();
builder.Services.AddScoped<IPatientService, PatientServiceImp>();

//Address DI

builder.Services.AddScoped<IAddressRepository, AddressRepositoryImp>();
builder.Services.AddScoped<IAddressService, AddressServiceImp>();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
