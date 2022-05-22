using DecahexBackend.Models;
using DecahexBackend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DecahexBackend.Controllers
{

        //[ApiController]
        //[Route("api/[controller]")]
        //public class UsersController : ControllerBase
        //{
        //    private readonly UserService _userService;

        //    public UsersController(UserService userService) => _userService = userService;

        //    [HttpGet]
        //    [Authorize("read:messages")]
        //    public async Task<List<User>> Get() => await _userService.GetAsync();

        //    [HttpGet("{id:length(24)}")]
        //    public async Task<ActionResult<User>> Get(string id)
        //    {
        //        var user = await _userService.GetAsync(id);

        //        if (user == null)
        //        {
        //            return NotFound();
        //        }

        //        return user;
        //    }

        //    [HttpPost]
        //    public async Task<IActionResult> Post(User newUser)
        //    {
        //        await _userService.CreateAsync(newUser);

        //        return CreatedAtAction(nameof(Get), new { id = newUser.Id }, newUser);
        //    }

        //    [HttpPut("{id:length(24)}")]
        //    public async Task<IActionResult> Update(string id, User updatedUser)
        //    {
        //        var user = await _userService.GetAsync(id);

        //        if( user == null)
        //        {
        //            return NotFound();
        //        }

        //        updatedUser.Id = user.Id;

        //        await _userService.UpdateAsync(id, updatedUser);

        //        return NoContent();


        //    }

        //    [HttpDelete("{id:length(24)}")]
        //    public async Task<IActionResult> Delete(string id)
        //    {
        //        var user = await _userService.GetAsync(id);

        //        if(user == null)
        //        {
        //            return NotFound();
        //        }

        //        await _userService.RemoveAsync(id);

        //        return NoContent();

        //    }

            

        //}
}
