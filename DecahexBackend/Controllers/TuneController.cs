using DecahexBackend.Models;
using DecahexBackend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DecahexBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TuneController : ControllerBase
    {
        private readonly DbService _dbService;

        public TuneController(DbService dbService) => _dbService = dbService;

        [HttpGet]
        public async Task<List<GranturismoTune>> Get() => await _dbService.GetGranturismoTuneAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<GranturismoTune>> Get(int id)
        {

            var GtTune = await _dbService.GetGranturismoTuneAsync(id);

            if (GtTune == null)
            {
                return NotFound();
            }

            return GtTune;

        }

    //    [HttpPost]
    //    public async Task<IActionResult> Post(GranturismoTune newGt)
    //    {
    //        await _dbService.CreateGranturismoTuneAsync(newGt);

    //        return CreatedAtAction(nameof(Get), new { id = newGt.GranturismoTuneId }, newGt);
    //    }

    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> Update(int GtId, GranturismoTune updatedGt)
    //    {
    //        var Gt = await _dbService.GetGranturismoTuneAsync(GtId);

    //        if (Gt == null)
    //        {
    //            return NotFound();
    //        }

    //        updatedGt.GranturismoTuneId = Gt.GranturismoTuneId;

    //        await _dbService.UpdateGranturismoTuneAsync(GtId, updatedGt);

    //        //return StatusCode(418);
    //        return Ok();

    //    }

    //    [HttpDelete("{id}")]
    //    public async Task<IActionResult> Delete(int Gtid)
    //    {
    //        var Gt = await _dbService.GetGranturismoTuneAsync(Gtid);

    //        if (Gt == null)
    //        {
    //            return NotFound();
    //        }

    //        await _dbService.RemoveGranturismoTuneAsync(Gtid);

    //        return Ok();
    //    }

    }
}
