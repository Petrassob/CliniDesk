using CliniDesk.API.Models;
using CliniDesk.Business;
using CliniDesk.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CliniDesk.API.Controllers;

[ApiController]

[Route("api/auth")]

public class AuthController : ControllerBase
{
    private readonly AuthService authService;

    public AuthController(AuthService authService)
    {
        this.authService = authService;
    }


    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Username) ||
            string.IsNullOrWhiteSpace(request.Password))
        {
            return BadRequest("Incomplete data");
        }

        string token = authService.Login(request.Username, request.Password);

            return Ok(new
            {
                token = token
            });
    }
        

    [HttpPost("register")]
    public IActionResult Register([FromBody] RegisterRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Username) ||
            string.IsNullOrWhiteSpace(request.Password))

        {
            return BadRequest("Incomplete data");
        }

    
        User user = authService.Register(request.Username, request.Password);

            return Ok(new
            {
                message = "Created user",
                username = user.Username
            });
     }
    

    [Authorize]
    [HttpGet("profile")]

    public IActionResult Profile()
    {
        return Ok("Authorized access");
    }
}