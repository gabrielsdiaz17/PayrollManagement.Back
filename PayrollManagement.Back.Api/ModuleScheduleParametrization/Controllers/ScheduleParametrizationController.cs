using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Back.Api.ModuleRole.ViewModel;
using PayrollManagement.Back.Api.ModuleScheduleParametrization.Interfaces;
using PayrollManagement.Back.Business.Models;

namespace PayrollManagement.Back.Api.ModuleScheduleParametrization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleParametrizationController : ControllerBase
    {
        private readonly IScheduleParametrizationService _scheduleParametrizationService;
        private ILogger<ScheduleParametrizationController> _logger;
        public ScheduleParametrizationController(IScheduleParametrizationService scheduleParametrizationService, ILogger<ScheduleParametrizationController> logger)
        {
            _scheduleParametrizationService = scheduleParametrizationService;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var querySchedule = await _scheduleParametrizationService.GetAllAsync();                
                return Ok(querySchedule);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ScheduleParametrization newScheduleParametrization)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _scheduleParametrizationService.AddAsync(newScheduleParametrization);
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ScheduleParametrization updateSchedule)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _scheduleParametrizationService.UpdateAsync(updateSchedule);
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
    }
}
