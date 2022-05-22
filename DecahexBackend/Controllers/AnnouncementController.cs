using DecahexBackend.Models;
using DecahexBackend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DecahexBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnnouncementController : ControllerBase
    {
        private readonly DbService _dbService;

        public AnnouncementController(DbService dbService) => _dbService = dbService;

        [HttpGet]
        public async Task<List<Announcement>> Get() => await _dbService.GetAnnouncementAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Announcement>> Get(int id)
        {
            var annoucement = await _dbService.GetAnnouncementAsync(id);

            if (annoucement == null)
            {
                return NotFound();
            }

            return annoucement;
        }

        //[HttpPost]
        //public async Task<IActionResult> Post(Announcement newAnnouncement)
        //{
        //    await _dbService.CreateAnnouncementAsync(newAnnouncement);

        //    return CreatedAtAction(nameof(Get), new { id = newAnnouncement.AnnouncementId }, newAnnouncement);
        //}

        //[HttpPost("{id}")]
        //public async Task<IActionResult> Update(int announcementId, Announcement updatedAnnouncement)
        //{
        //    var announcement = await _dbService.GetAnnouncementAsync(announcementId);

        //    if (announcement == null)
        //    {
        //        return NotFound();
        //    }

        //    updatedAnnouncement.AnnouncementId = announcement.AnnouncementId;

        //    await _dbService.UpdateAnnouncementAsync(announcementId, updatedAnnouncement);

        //    return Ok();

        //}


        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var announcement = await _dbService.GetAnnouncementAsync(id);

        //    if(announcement == null)
        //    {
        //        return NotFound();
        //    }

        //    await _dbService.RemoveAnnouncementAsync(id);

        //    return Ok();

        //}




    }

}
