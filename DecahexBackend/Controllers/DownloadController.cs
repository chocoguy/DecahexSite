using DecahexBackend.Models;
using DecahexBackend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DecahexBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DownloadController : ControllerBase
    {
        private readonly DbService _dbService;

        public DownloadController(DbService dbService) => _dbService = dbService;

        [HttpGet]
        public async Task<List<Download>> Get() => await _dbService.GetDownloadAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Download>> Get(int id)
        {
            var download = await _dbService.GetDownloadAsync(id);

            if (download == null)
            {
                return NotFound();
            }

            return download;

        }

        //[HttpPost]
        //public async Task<IActionResult> Post(Download newDownload)
        //{
        //    await _dbService.CreateDownloadAsync(newDownload);

        //    return CreatedAtAction(nameof(Get), new { id = newDownload.DownloadId }, newDownload);
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Update(int downloadId, Download updatedDownload)
        //{
        //    var download = await _dbService.GetDownloadAsync(downloadId);

        //    if (download == null)
        //    {
        //        return NotFound();
        //    }

        //    updatedDownload.DownloadId = download.DownloadId;

        //    await _dbService.UpdateDownloadAsync(downloadId, updatedDownload);

        //    return Ok();

        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var download = await _dbService.GetDownloadAsync(id);

        //    if(download == null)
        //    {
        //        return NotFound();
        //    }

        //    await _dbService.RemoveDownloadAsync(id);

        //    return Ok();
        //}

    }
}
