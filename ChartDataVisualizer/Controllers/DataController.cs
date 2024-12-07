using ChartDataVisualizer.Data;
using Microsoft.AspNetCore.Mvc;

namespace ChartDataVisualizer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DataController : ControllerBase
{
    private readonly AppDbContext _context;

    public DataController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("dataset")]
    public IActionResult GetData()
    {
        var data = _context.DataPoints.ToList();
        return Ok(data);
    }
}