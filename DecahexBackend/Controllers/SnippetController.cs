using DecahexBackend.Models;
using DecahexBackend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DecahexBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SnippetController : ControllerBase
    {

        private readonly DbService _dbService;

        public SnippetController(DbService dbService) => _dbService = dbService;

        [HttpGet]
        public async Task<List<Snippet>> Get() => await _dbService.GetSnippetAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Snippet>> Get(int id)
        {

            var snippet = await _dbService.GetSnippetAsync(id);

            if (snippet == null)
            {
                return NotFound();
            }

            return snippet;

        }

        //[HttpPost]
        //public async Task<IActionResult> Post(Snippet newSnippet)
        //{
        //    await _dbService.CreateSnippetAsync(newSnippet);

        //    return CreatedAtAction(nameof(Get), new { id = newSnippet.SnippetId }, newSnippet);
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Update(int snippetId, Snippet updatedSnippet)
        //{
        //    var snippet = await _dbService.GetSnippetAsync(snippetId);

        //    if (snippet == null)
        //    {
        //        return NotFound();
        //    }

        //    updatedSnippet.SnippetId = snippet.SnippetId;

        //    await _dbService.UpdateSnippetAsync(snippetId, updatedSnippet);

        //    //return StatusCode(418);
        //    return Ok();

        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var snippet = await _dbService.GetSnippetAsync(id);

        //    if (snippet == null)
        //    {
        //        return NotFound();
        //    }

        //    await _dbService.RemoveSnippetAsync(id);

        //    return Ok();
        //}

    }
}
