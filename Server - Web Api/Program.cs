
using Microsoft.EntityFrameworkCore;
using Server___Web_Api.BLL;
using Server___Web_Api.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<pageContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("pageContext")));

builder.Services.AddControllers();
builder.Services.AddHttpClient();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICandidatesDal, CandidatesDal>();
builder.Services.AddScoped<ICandidatesBll, CandidatesBll>();


builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", //give it the name you want
                  builder =>
                  {
                      builder.WithOrigins("http://localhost:4200",
                                           "development web site")
                                          .AllowAnyHeader()
                                          .AllowAnyMethod()
                                          ;
                  });

});

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
app.UseCors("CorsPolicy");
app.Run();
