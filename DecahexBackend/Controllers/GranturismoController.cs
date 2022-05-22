using DecahexBackend.Models;
using DecahexBackend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DecahexBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GranturismoController : ControllerBase
    {
        private readonly DbService _dbService;

        public GranturismoController(DbService dbService) => _dbService = dbService;

        [HttpGet]
        public async Task<List<GranturismoPost>> Get() => await _dbService.GetGranturismoAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<GranturismoPost>> Get(int id)
        {

            var anime = await _dbService.GetGranturismoAsync(id);

            if (anime == null)
            {
                return NotFound();
            }

            return anime;

        }

        //[HttpPost]
        //public async Task<IActionResult> Post(GranturismoPost newGtPost)
        //{
        //    await _dbService.CreateGranturismoAsync(newGtPost);

        //    return CreatedAtAction(nameof(Get), new { id = newGtPost.GranturismoPostId }, newGtPost);
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Update(int GtId, GranturismoPost updatedGt)
        //{
        //    var Gt = await _dbService.GetGranturismoAsync(GtId);

        //    if (Gt == null)
        //    {
        //        return NotFound();
        //    }

        //    updatedGt.GranturismoPostId = Gt.GranturismoPostId;

        //    await _dbService.UpdateGranturismoAsync(GtId, updatedGt);

        //    //return StatusCode(418);
        //    return Ok();

        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var Gt = await _dbService.GetGranturismoAsync(id);

        //    if (Gt == null)
        //    {
        //        return NotFound();
        //    }

        //    await _dbService.RemoveGranturismoAsync(id);

        //    return Ok();
        //}
    }
}
