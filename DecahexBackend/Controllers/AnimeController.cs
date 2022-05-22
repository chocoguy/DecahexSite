using DecahexBackend.Models;
using DecahexBackend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace DecahexBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimeController : ControllerBase
    {
        private readonly DbService _dbService;

        public AnimeController(DbService dbService) => _dbService = dbService;

        [HttpGet]
        public async Task<List<Anime>> Get() => await _dbService.GetAnimeAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Anime>> Get(int id)
        {

            var anime = await _dbService.GetAnimeAsync(id);

            if (anime == null)
            {
                return NotFound();
            }

            return anime;

        }

        //[HttpPost]
        //public async Task<IActionResult> Post(Anime newAnime)
        //{
        //    await _dbService.CreateAnimeAsync(newAnime);

        //    return CreatedAtAction(nameof(Get), new { id = newAnime.AnimeId }, newAnime);
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Update(int id, Anime updatedAnime)
        //{
        //    var anime = await _dbService.GetAnimeAsync(id);

        //    if(anime == null)
        //    {
        //        return NotFound();
        //    }

        //    updatedAnime.Id = anime.Id;

        //    await _dbService.UpdateAnimeAsync(id, updatedAnime);

        //    //return StatusCode(418);
        //    return Ok();

        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var anime = await _dbService.GetAnimeAsync(id);

        //    if(anime == null)
        //    {
        //        return NotFound();
        //    }

        //    await _dbService.RemoveAnimeAsync(id);

        //    return Ok();
        //}

    }
}
