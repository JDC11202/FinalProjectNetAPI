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
        if (ID == null || ID == 0) 
        { 
            return await _context.TableName.Take(5).ToListAsync(); 
        } 
        else 
        { 
            return await _context.TableName.FindAsync(id); 
        }
    }
}
