using ChartDataVisualizer.Data;
using ChartDataVisualizer.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChartDataVisualizer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DataController : ControllerBase
{
    private readonly DataService _dataService;

    public DataController(DataService dataService)
    {
        _dataService = dataService;
    }

    [HttpGet("dataset")]
    public IActionResult GetData()
    {
        var data = _dataService.GetAllData();
        return Ok(data);
    }
}
