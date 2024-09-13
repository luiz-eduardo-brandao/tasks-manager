using Microsoft.AspNetCore.Mvc;
using TasksManager.API.DTOs;
using TasksManager.API.Services.Interfaces;
using TasksManager.API.DTOs.TimeTrackers;

namespace TasksManager.API.Controllers
{
    [ApiController]
    [Route("time-trackers")]
    public class TimeTrackersController : ControllerBase
    {
        private readonly ITimeTrackerService _timeTrackerService;

        public TimeTrackersController(ITimeTrackerService timeTrackerService)
        {
            _timeTrackerService = timeTrackerService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TimeTrackerDTO>>> GetAll()
        {
            try
            {
                var trackers = await _timeTrackerService.GetAllTrackers();

                if (trackers == null)
                    return NotFound();

                return Ok(trackers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TimeTrackerDTO>> GetById(Guid id)
        {
            try
            {
                var tracker = await _timeTrackerService.GetTrackerById(id);

                if (tracker == null)
                    return NotFound();

                return Ok(tracker);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpPost("start/{timezone}")]
        public async Task<ActionResult> StartTracker(string timezone, [FromBody] StartStopTrackerRequest request)
        {
            try
            {
                var result = await _timeTrackerService.StartTracker(timezone, request);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("stop/{timeTrackerId}")]
        public async Task<ActionResult> StopTracker(Guid timeTrackerId)
        {
            try
            {
                await _timeTrackerService.StopTracker(timeTrackerId);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("{timezone}")]
        public async Task<ActionResult<TimeTrackerDTO>> AddTracker(string timezone, [FromBody] AddTimeTrackerRequest request)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(timezone))
                    return BadRequest("Por favor preencher time zone");

                var result = await _timeTrackerService.AddTracker(timezone, request);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{timezone}")]
        public async Task<ActionResult<TimeTrackerDTO>> UpdateTracker(string timezone, [FromBody] UpdateTimeTrackerRequest request)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(timezone))
                    return BadRequest("Por favor preencher time zone");

                var result = await _timeTrackerService.UpdateTracker(timezone,request);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTracker(Guid id)
        {
            try
            {
                await _timeTrackerService.DeleteTracker(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}