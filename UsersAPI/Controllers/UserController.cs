using Microsoft.AspNetCore.Mvc;
using UsersAPI.Models;
using UsersAPI.Repositories;

namespace UsersAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UserController(IUserRepository userRepository)
    {
        this._userRepository = userRepository;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var users = await _userRepository.GetAllAsync();

        return Ok(users);
    }

    [HttpGet]
    [Route("{id:Guid}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        if (user == null) return NotFound();

        return Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] User user)
    {
        var newUser = await _userRepository.CreateAsync(user);

        return CreatedAtAction(nameof(GetById), new { id = newUser.UserId }, user);
    }

    [HttpPut]
    [Route("{id:Guid}")]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] User user)
    {
        var updatedUser = await _userRepository.UpdateAsync(id, user);
        if (updatedUser == null) return NotFound();

        return Ok(updatedUser);
    }

    [HttpDelete]
    [Route("{id:Guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        var user = await _userRepository.DeleteAsync(id);
        if (user == null) return NotFound();

        return Ok(user);
    }
}