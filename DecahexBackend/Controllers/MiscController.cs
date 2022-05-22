using DecahexBackend.Models;
using DecahexBackend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DecahexBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MiscController : ControllerBase
    {
        private readonly DbService _dbService;

        public MiscController(DbService dbService) => _dbService = dbService;

        [HttpGet]
        public async Task<List<Misc>> Get() => await _dbService.GetMiscAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Misc>> Get(int id)
        {

            var misc = await _dbService.GetMiscAsync(id);

            if (misc == null)
            {
                return NotFound();
            }

            return misc;

        }

        //[HttpPost]
        //public async Task<IActionResult> Post(Misc newMisc)
        //{
        //    await _dbService.CreateMiscAsync(newMisc);

        //    return CreatedAtAction(nameof(Get), new { id = newMisc.MiscId }, newMisc);
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Update(int miscId, Misc updatedMisc)
        //{
        //    var misc = await _dbService.GetMiscAsync(miscId);

        //    if (misc == null)
        //    {
        //        return NotFound();
        //    }

        //    updatedMisc.MiscId = misc.MiscId;

        //    await _dbService.UpdateMiscAsync(miscId, updatedMisc);

        //    //return StatusCode(418);
        //    return Ok();

        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var misc = await _dbService.GetMiscAsync(id);

        //    if (misc == null)
        //    {
        //        return NotFound();
        //    }

        //    await _dbService.RemoveMiscAsync(id);

        //    return Ok();
        //}


    }
}
