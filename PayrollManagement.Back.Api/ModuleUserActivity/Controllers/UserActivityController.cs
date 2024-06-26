﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Back.Api.ModuleUserActivity.Interfaces;
using PayrollManagement.Back.Api.ModuleUserActivity.ViewModel;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.HelperModels;

namespace PayrollManagement.Back.Api.ModuleUserActivity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserActivityController : ControllerBase
    {
        private readonly IUserActivityService _userActivityService;
        private ILogger<UserActivityController> _logger;
        private readonly IMapper _mapper;
        public UserActivityController(IUserActivityService userActivityService, ILogger<UserActivityController> logger, IMapper mapper)
        {
            _userActivityService = userActivityService;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] List<UserActivityViewModel> newUserActivities)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    foreach (var newUserActivity in newUserActivities)
                    {
                        var userActivity = _mapper.Map<UserActivity>(newUserActivity);
                        await _userActivityService.AddAsync(userActivity);
                    }
                    return Ok();
                }
                return BadRequest();

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var query = await _userActivityService.GetAllAsync();
                var usersActivity = _mapper.Map<List<UserActivityViewModel>>(query);
                return Ok(usersActivity);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpPost("getActivityByWorker")]
        public async Task<IActionResult> GetActivityByWorker([FromBody] UserActivitityFilterWorkerId userFilter)
        {
            try
            {
                var query = await _userActivityService.GetActivityByWorkerId(userFilter);
                if (query.Any())
                {
                    var activitiesWorker = _mapper.Map<List<UserActivityViewModelDetails>>(query);
                    return Ok(activitiesWorker);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpPost("getActivityByDates")]
        public async Task<IActionResult> GetActivityByDates([FromBody] UserActivityFilter filter)
        {
            try
            {
                var query = await _userActivityService.GetAcitivityByDates(filter);
                if (query.Any())
                {
                    var userActivities = _mapper.Map<List<UserActivityViewModelDetails>>(query);
                    return Ok(userActivities);
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpPost("getActivityByCostCenter")]
        public async Task<IActionResult> GetActivityByCostCenter([FromBody] CostCenterActivityFilter filter)
        {
            try
            {
                var query = await _userActivityService.GetActivityByCostCenter(filter);
                if (query.Any())
                {
                    var userActivities = _mapper.Map<List<UserActivityViewModelDetails>>(query);
                    return Ok(userActivities);
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UserActivityViewModel userActivityUpdate)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var userActivity = _mapper.Map<UserActivity>(userActivityUpdate);
                    await _userActivityService.UpdateAsync(userActivity);
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var userActivity = await _userActivityService.GetByIdAsync(id);
                if (userActivity == null)
                    return NotFound("UserActivity not found");
                userActivity.IsActive = false;
                userActivity.IsDeleted = true;
                await _userActivityService.UpdateAsync(userActivity);
                return Accepted();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
    }
}
