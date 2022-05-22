using DecahexBackend.Models;
using DecahexBackend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace DecahexBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GarbageController : ControllerBase
    {
        private readonly DbService _dbService;

        public GarbageController(DbService dbService) => _dbService = dbService;

        [HttpGet]
        public async Task<List<Garbage>> Get() => await _dbService.GetGarbageAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Garbage>> Get(int id)
        {
            var garbage = await _dbService.GetGarbageAsync(id);

            if(garbage == null)
            {
                return NotFound();
            }

            return garbage;
        }

        //[HttpPost]
        //public async Task<IActionResult> Post(Garbage newGarbage)
        //{
        //    await _dbService.CreateGarbageAsync(newGarbage);

        //    return CreatedAtAction(nameof(Get), new { id = newGarbage.GarbageId }, newGarbage);

        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Update(int garbageId, Garbage updatedGarbage)
        //{
        //    var garbage = await _dbService.GetGarbageAsync(garbageId);

        //    if(garbage == null)
        //    {
        //        return NotFound();
        //    }

        //    updatedGarbage.GarbageId = garbage.GarbageId;

        //    await _dbService.UpdateGarbageAsync(garbageId, updatedGarbage);

        //    return Ok();

        //}


        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var garbage = await _dbService.GetGarbageAsync(id);

        //    if(garbage == null)
        //    {
        //        return NotFound();
        //    }

        //    await _dbService.RemoveGarbageAsync(id);

        //    return Ok();

        //}

    }
}
