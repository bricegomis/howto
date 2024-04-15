using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class CounterController : ControllerBase
{
    private readonly ILogger<CounterController> _logger;
    private readonly CounterBackgroundService _counterBackgroundService;

    public CounterController(ILogger<CounterController> logger, CounterBackgroundService counterBackgroundService)
    {
        _logger = logger;
        _counterBackgroundService = counterBackgroundService;
    }

    [HttpGet]
    public ActionResult<int> GetCounter()
    {
        return _counterBackgroundService.GetCounter();
    }
}