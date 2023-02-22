using Bookish.Application;
using Bookish.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Bookish.Api.Controllers;

[ApiController]
[Route("api/v1/users")]
public class UserController : ControllerBase
{
    private readonly IUsersService _usersService;

    public UserController(IUsersService userService)
    {
        _usersService = userService;
    }
    
    [HttpGet]
    public  IActionResult GetUsers()
    {
        var users = _usersService.GetAll();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(string id) { 
        var user = _usersService.GetById(id);
        return Ok(user);
    }

}
