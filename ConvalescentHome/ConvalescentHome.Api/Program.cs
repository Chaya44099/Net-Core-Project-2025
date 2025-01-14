using ConvalescentHome.Core.Entities;
using ConvalescentHome.Core.Irepository;
using ConvalescentHome.Core.IService;
using ConvalescentHome.Data;
using ConvalescentHome.Data.Repository;
using ConvalescentHome.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IBabyService, BabyService>();
builder.Services.AddScoped<Irepository<BabyEntity>, BabyRepository>();

builder.Services.AddScoped<IInvitationService, InvitationService>();
builder.Services.AddScoped<Irepository<InvitationEntity>, InvitationRepository>();

builder.Services.AddScoped<IParturientService, ParturientService>();
builder.Services.AddScoped<Irepository<ParturientEntity>, ParturientRepository>();

builder.Services.AddScoped<IWorkerService, WorkerService>();
builder.Services.AddScoped<Irepository<WorkerEntity>, WorkerRepository>();

builder.Services.AddScoped<IRoomsService, RoomsService>();
builder.Services.AddScoped<Irepository<RoomsEntity>, RoomsRepository>();

builder.Services.AddDbContext<DataContext>(option =>
{
    option.UseSqlServer("Data Source=DESKTOP-SSNMLFD;Initial Catalog=ConvalescentHome;Integrated Security=true;");
}
       );


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

app.UseAuthorization();

app.MapControllers();

app.Run();
