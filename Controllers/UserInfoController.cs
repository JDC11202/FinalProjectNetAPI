using FinalProjectNetAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProjectNetAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserInfoController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<UserInfoController> _logger;

    public UserInfoController(ILogger<UserInfoController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "UserInfo")]
    public IActionResult Get()
    {
        var personName = new UserInfo {Name = "Jacob Collier"};
        return Ok();
    }
}
