using Microsoft.AspNetCore.Mvc;
using TasksManager.API.DTOs;
using TasksManager.API.Services.Interfaces;
using TasksManager.API.DTOs.Tasks;

namespace TasksManager.API.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("tasks")]
    public class TasksController : ControllerBase
    {
        private readonly ITasksService _tasksService;

        public TasksController(ITasksService tasksService)
        {
            _tasksService = tasksService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TaskDTO>>> GetAllTasks()
        {
            try
            {
                var tasks = await _tasksService.GetAllTasks();

                if (tasks == null)
                    return NotFound();

                return Ok(tasks);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskDTO>> GetTaskById(Guid id)
        {
            try
            {
                var task = await _tasksService.GetTaskById(id);

                if (task == null)
                    return NotFound();

                return Ok(task);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{projectId}/project")]
        public async Task<ActionResult<List<TaskDTO>>> GetAllTasksByProject(Guid projectId)
        {
            try
            {
                var tasks = await _tasksService.GetAllTasksByProject(projectId);

                if (tasks == null)
                    return NotFound();

                return Ok(tasks);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{collaboratorId}/collaborator")]
        public async Task<ActionResult<List<TaskDTO>>> GetAllTasksByCollaborator(Guid collaboratorId)
        {
            try
            {
                var tasks = await _tasksService.GetAllTasksByCollaborator(collaboratorId);

                if (tasks == null)
                    return NotFound();

                return Ok(tasks);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<TaskDTO>> AddTask([FromBody] AddTaskRequest request)
        {
            try
            {
                var result = await _tasksService.AddTask(request);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<TaskDTO>> UpdateTask([FromBody] UpdateTaskRequest request)
        {
            try
            {
                var result = await _tasksService.UpdateTask(request);

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
                await _tasksService.DeleteTask(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}