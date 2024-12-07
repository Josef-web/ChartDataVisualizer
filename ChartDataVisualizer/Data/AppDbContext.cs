using ChartDataVisualizer.Models;
using Microsoft.EntityFrameworkCore;

namespace ChartDataVisualizer.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<DataPoint> DataPoints { get; set; }
}