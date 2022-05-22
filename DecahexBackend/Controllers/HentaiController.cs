using DecahexBackend.Models;
using DecahexBackend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace DecahexBackend.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class HentaiController : ControllerBase
    {

        private readonly DbService _dbService;

        public HentaiController(DbService dbService) => _dbService = dbService;

        [HttpGet]
        public async Task<List<Hentai>> Get() => await _dbService.GetHentaiAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Hentai>> Get(int id)
        {

            var hentai = await _dbService.GetHentaiAsync(id);

            if (hentai == null)
            {
                return NotFound();
            }

            return hentai;

        }

        //[HttpPost]
        //public async Task<IActionResult> Post(Hentai newHentai)
        //{
        //    await _dbService.CreateHentaiAsync(newHentai);

        //    return CreatedAtAction(nameof(Get), new { id = newHentai.HentaiId }, newHentai);
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Update(int hentaiId, Hentai updatedHentai)
        //{
        //    var hentai = await _dbService.GetHentaiAsync(hentaiId);

        //    if (hentai == null)
        //    {
        //        return NotFound();
        //    }

        //    updatedHentai.HentaiId = hentai.HentaiId;

        //    await _dbService.UpdateHentaiAsync(hentaiId, updatedHentai);

        //    //return StatusCode(418);
        //    return Ok();

        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var hentai = await _dbService.GetHentaiAsync(id);

        //    if (hentai == null)
        //    {
        //        return NotFound();
        //    }

        //    await _dbService.RemoveHentaiAsync(id);

        //    return Ok();
        //}

    }
}
