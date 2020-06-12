using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using AnimalShelter.Services;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Authorize]
  [ApiController]
  [Route("[controller]")]
  public class UsersController : ControllerBase
  {
    private IUserService _userService;
    public UsersController(IUserService userService)
    {
      _userService = userService;
    }

    [AllowAnonymous]
    [HttpPost("auth")]
    public IActionResult Auth([FromBody] User userParam)
    {
      var user = _userService.Auth(userParam.UserName, userParam.Password);

      if(user == null)
        return BadRequest(new { message = "Credentials incorrect"});
      return Ok(user);
    }

    [HttpGet]
    public IActionResult GetAll()
    {
      var claimsIdentity = this.User.Identity as ClaimsIdentity;
      var userId = claimsIdentity.FindFirst(ClaimTypes.Name)?.Value;
      var users = _userService.GetAll();
      return Ok(users); 
    }
  }
}