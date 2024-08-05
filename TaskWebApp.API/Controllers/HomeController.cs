using Microsoft.AspNetCore.Mvc;

namespace TaskWebApp.API.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class HomeController : ControllerBase
{
    private readonly ILogger<HomeController> _logger;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    [HttpGet]
    public async Task<IActionResult> GetContentAsync(CancellationToken cancellationToken)
    {
        try
        {
            _logger.LogInformation("İstek başladı");

            await Task.Delay(5000, cancellationToken);

            var mytask = new HttpClient().GetStringAsync("https://www.google.com");

            var data = await mytask;

            _logger.LogInformation("İstek tamamlandı");

            return Ok(data);
        }
        catch (Exception ex)
        {
            _logger.LogInformation("İstek iptal edildi: " + ex.Message);
            return BadRequest();
        }

    }

}
