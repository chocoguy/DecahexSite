using DecahexBackend.Models;
using DecahexBackend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DecahexBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly DbService _dbService;

        public ProjectController(DbService dbService) => _dbService = dbService;

        [HttpGet]
        public async Task<List<Project>> Get() => await _dbService.GetProjectAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> Get(int id)
        {

            var project = await _dbService.GetProjectAsync(id);

            if (project == null)
            {
                return NotFound();
            }

            return project;

        }

        //[HttpPost]
        //public async Task<IActionResult> Post(Project newProject)
        //{
        //    await _dbService.CreateProjectAsync(newProject);

        //    return CreatedAtAction(nameof(Get), new { id = newProject.ProjectId }, newProject);
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Update(int projectId, Project updatedProject)
        //{
        //    var project = await _dbService.GetProjectAsync(projectId);

        //    if (project == null)
        //    {
        //        return NotFound();
        //    }

        //    updatedProject.ProjectId = project.ProjectId;

        //    await _dbService.UpdateProjectAsync(projectId, updatedProject);

        //    //return StatusCode(418);
        //    return Ok();

        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var project = await _dbService.GetProjectAsync(id);

        //    if (project == null)
        //    {
        //        return NotFound();
        //    }

        //    await _dbService.RemoveProjectAsync(id);

        //    return Ok();
        //}

    }
}
