using Microsoft.AspNetCore.Mvc;
using TasksManager.API.DTOs;
using TasksManager.API.DTOs.Projects;
using TasksManager.API.Services.Interfaces;

namespace TasksManager.API.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectsService _projectsService;

        public ProjectsController(IProjectsService projectsService)
        {
            _projectsService = projectsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProjectDTO>>> GetAllProjects() 
        {
            try
            {
                var projects = await _projectsService.GetAllProjects();

                if (projects == null)
                    return NotFound();

                return Ok(projects);   
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectDTO>> GetProjectById(Guid id) 
        {
            try
            {
                var project = await _projectsService.GetProjectById(id);

                if (project == null)
                    return NotFound();

                return Ok(project);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ProjectDTO>> AddProject([FromBody] AddProjectRequest request) 
        {
            try
            {
                var result = await _projectsService.AddProject(request);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 
        
        [HttpPut]
        public async Task<ActionResult<ProjectDTO>> UpdateProject([FromBody] UpdateProjectRequest request) 
        {
            try
            {
                var result = await _projectsService.UpdateProject(request);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProject(Guid id) 
        {
            try
            {
                await _projectsService.DeleteProject(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 
    }
}