using ChartDataVisualizer.Data;
using ChartDataVisualizer.Models;

namespace ChartDataVisualizer.Services;

public class DataService
{
    private readonly AppDbContext _context;

    public DataService(AppDbContext context)
    {
        _context = context;
    }

    public List<DataPoint> GetAllData()
    {
        return _context.DataPoints.ToList();
    }
}