using ChartDataVisualizer.Data;
using ChartDataVisualizer.Services;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// 🚀 Serilog'u yapılandırın
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .CreateLogger();

builder.Host.UseSerilog(); // Serilog'u uygulamaya ekle

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddScoped<DataService>();

// Add DbContext service
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// 🚀 CORS yapılandırmasını ekliyoruz
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", policy =>
    {
        policy
            .AllowAnyOrigin() // İsteyen her siteye (localhost:63342) izin verir
            .AllowAnyMethod() // GET, POST, PUT, DELETE vb. izin verilir
            .AllowAnyHeader(); // Her türlü header'a izin verilir
    });
});

builder.Logging.ClearProviders();
builder.Logging.AddSerilog();


var app = builder.Build();

// 🚀 CORS'u tüm uygulamada etkinleştir
app.UseCors("AllowAllOrigins");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseDefaultFiles(); // index.html dosyasını varsayılan yapar
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}