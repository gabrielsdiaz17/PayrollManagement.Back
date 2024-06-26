﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Back.Api.ModuleWorker.Interfaces;
using PayrollManagement.Back.Api.ModuleWorker.ViewModel;
using PayrollManagement.Back.Business.Models;

namespace PayrollManagement.Back.Api.ModuleWorker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IWorkerService _workerService;
        public ILogger<WorkerController> _loggger;
        private readonly IMapper _mapper;
        public WorkerController(IWorkerService workerService, ILogger<WorkerController> logger, IMapper mapper)
        {
            _workerService = workerService;
            _loggger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] WorkerViewModel newWorkerVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var worker = _mapper.Map<Worker>(newWorkerVM);
                    await _workerService.AddAsync(worker);
                    var workerId = worker.Id;
                    return Ok(new { Id = workerId });

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
                var query = await _workerService.GetWorkerWithUserInfo();
                if (query.Any())
                {
                    var workers = _mapper.Map<List<WorkerQueryViewModel>>(query);
                    return Ok(workers);
                }
                return Ok();

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpGet("getUserActivityByWorker/{id}")]

        public async Task<IActionResult> GetUserActivityByWorker(long id)
        {
            try
            {
                var query = await _workerService.GetUserActivityByWorker(id);
                if (query.Any())
                {
                    var worker = _mapper.Map<WorkerQueryViewModel>(query);
                    return Ok(worker);
                }
                return NotFound();

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpGet("workerByCostCenter/{costCenterId}")]
        public async Task<IActionResult> WorkerByCostCenter(long costCenterId)
        {
            try
            {
                
                var workers = await _workerService.WorkerByCostCenter(costCenterId);
                if (workers.Count > 0)
                    return Ok(workers);
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }

        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] WorkerViewModel workerVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var worker = _mapper.Map<Worker>(workerVM);
                    await _workerService.UpdateAsync(worker);
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
                var worker = await _workerService.GetByIdAsync(id);
                if (worker == null)
                    return NotFound("Worker does not exist");
                worker.IsDeleted = true;
                //Pending to see user that updates if its by jwt and identity
                await _workerService.UpdateAsync(worker);
                return Accepted();

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        
    }
}
