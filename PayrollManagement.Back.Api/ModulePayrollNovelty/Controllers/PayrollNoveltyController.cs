﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Back.Api.ModulePayrollNovelty.Interfaces;
using PayrollManagement.Back.Api.ModulePayrollNovelty.ViewModels;
using PayrollManagement.Back.Api.ModuleUserActivity.ViewModel;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.HelperModels;

namespace PayrollManagement.Back.Api.ModulePayrollNovelty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayrollNoveltyController : ControllerBase
    {
        private readonly IPayrollNoveltyService _payrollNoveltyService;
        private readonly ILogger <PayrollNoveltyController>_logger;
        private readonly IMapper _mapper;
        public PayrollNoveltyController(IPayrollNoveltyService payrollNoveltyService, ILogger<PayrollNoveltyController> logger, IMapper mapper)
        {
            _payrollNoveltyService = payrollNoveltyService;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task <IActionResult> Create([FromBody] PayrollNoveltyViewModel novelty)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var noveltyEntity = _mapper.Map<PayrollNovelty>(novelty);
                    DateTime utcNovelty = DateTime.SpecifyKind(novelty.NoveltyDate, DateTimeKind.Utc);
                    DateTime utcInitial = DateTime.SpecifyKind(novelty.InitialDate, DateTimeKind.Utc);
                    DateTime utcEnd = DateTime.SpecifyKind(novelty.EndDate, DateTimeKind.Utc);

                    noveltyEntity.NoveltyDate = utcNovelty;
                    noveltyEntity.InitialDate = utcInitial;
                    noveltyEntity.EndDate = utcEnd;
                    if (noveltyEntity.UserActivityId == 0)
                    {
                        noveltyEntity.UserActivityId = null;
                    }

                    await _payrollNoveltyService.AddAsync(noveltyEntity);
                    var payrollNoveltyId = noveltyEntity.Id;
                    return Ok(new { Id = payrollNoveltyId });
                }
                return BadRequest();
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetallNovelties()
        {
            try
            {
                var query = await _payrollNoveltyService.GetPayrollNoveltiesNotProcessed();
                if (query.Any())
                {
                    var novelties = _mapper.Map<List<PayrollNoveltyDetailViewModel>>(query);
                    return Ok(novelties);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpPost("getNoveltiesByDate")]
        public async Task <IActionResult> GetNoveltiesByDate([FromBody] DateGeneralFilter filter)
        {
            try
            {
                var query = await _payrollNoveltyService.GetPayrollNoveltiesByDate(filter);
                if (query.Any())
                {
                    var novelties = _mapper.Map<List<PayrollNoveltyDetailViewModel>>(query);
                    return Ok(novelties);
                }
                return NotFound();
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }

        [HttpPost("getNoveltiesByUserInfo")]
        public async Task<IActionResult> GetNoveltiesByUserInfo([FromBody] DateGeneralFilterWithUserInfo filter)
        {
            try
            {
                var query = await _payrollNoveltyService.GetPayrollNoveltiesByUserInfo(filter);
                if (query.Any())
                {
                    var novelties = _mapper.Map<List<PayrollNoveltyDetailViewModel>>(query);
                    return Ok(novelties);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] PayrollNoveltyViewModel payrollNovelty)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var payrollNoveltyUpdate = _mapper.Map<PayrollNovelty>(payrollNovelty);
                    await _payrollNoveltyService.UpdateAsync(payrollNoveltyUpdate);
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
                var payrollNovelty = await _payrollNoveltyService.GetByIdAsync(id);
                if (payrollNovelty == null)
                    return NotFound("PayrollNovelty not found");
                payrollNovelty.IsActive = false;
                payrollNovelty.IsDeleted = true;
                await _payrollNoveltyService.UpdateAsync(payrollNovelty);
                return Accepted();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
    }
}
