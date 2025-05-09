using Application;
using Core.CrossCuttingConcerns.Exceptions.Extensions;
using Persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddApplicationServices();
builder.Services.AddPersistanceServices(builder.Configuration);
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
//if(app.Environment.IsProduction())//e�er ben geli�tiriciysem bana uzun uzun hatay� var e�er ben bunu yay�na alm�� isem midel weardeki hatay� d�nd�r 
app.ConfigureCustomExceptionMiddleware();//hata y�netimin midel weari 


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
