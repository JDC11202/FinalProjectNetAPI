using FinalProjectNetAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProjectNetAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BasicUserInfoController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<BasicUserInfoController> _logger;

    public BasicUserInfoController(ILogger<BasicUserInfoController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "BasicUserInfo")]
    public IActionResult Get()
    {
        var personName = new BasicUserInfo {Name = "Jacob Collier"};
        return Ok();
    }
}
