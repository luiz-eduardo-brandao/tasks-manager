using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TasksManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeTrackersController : ControllerBase
    {
        // [HttpGet("timeTrackers")]
        // public async Task<ActionResult<List<TimeTrackerResponse>>> GetTimeTrackers() 
        // {
        //     var timeTrackersList = await _context.TimeTrackers.ToListAsync();

        //     var timeTrackers = timeTrackersList.Select(t => new TimeTrackerResponse(t)).ToList();

        //     return timeTrackers;
        // }
        
        // [HttpPost("{culture}/add-task")]
        // public async Task<ActionResult<List<TaskModel>>> RegisterNewTask([FromBody] RegisterTaskRequest request) 
        // {
        //     var project = await _context.Projects.FindAsync(request.ProjectId);

        //     if (project == null)
        //         return NotFound();

        //     var task = new TaskModel 
        //     {
        //         Id = request.Id,
        //         ProjectId = request.ProjectId,
        //         Name = request.Name,
        //         Description = request.Description
        //     };
            
        //     _context.Tasks.Add(task);
        //     await _context.SaveChangesAsync();

            
        //     var tasksList = await _context.Tasks.ToListAsync();

        //     return tasksList;
        // }

        // [HttpPost("{culture}")]
        // public async Task<ActionResult<List<TimeTracker>>> AddTimeTracker(string culture) 
        // {

        //     var timeTracker = new TimeTracker 
        //     {
        //         Id = Guid.NewGuid(),
        //         CreatedAt = DateTime.UtcNow,
        //         TimeZoneId = culture,
        //         StartDate = DateTime.Now,
        //         EndDate = DateTime.Now.AddMinutes(10),
        //         TaskId = Guid.Parse("ACD96614-B660-4A01-924D-3B464CAA2EC3"),
        //         CollaboratorId = Guid.Parse("DFAEEE36-623B-4EC5-AF23-B15F4CF87B6D")
        //     };

        //     _context.TimeTrackers.Add(timeTracker);
        //     await _context.SaveChangesAsync();

        //     var timeTrackersList = await _context.TimeTrackers.ToListAsync();

        //     return timeTrackersList;
        // }
    }
}