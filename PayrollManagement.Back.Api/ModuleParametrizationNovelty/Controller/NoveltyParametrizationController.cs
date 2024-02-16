using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Back.Api.ModuleParametrizationNovelty.Interface;
using PayrollManagement.Back.Api.ModuleWorker.Controllers;
using PayrollManagement.Back.Api.ModuleWorker.Interfaces;
using PayrollManagement.Back.Api.ModuleWorker.Services;
using PayrollManagement.Back.Api.ModuleWorker.ViewModel;
using PayrollManagement.Back.Business.Models;

namespace PayrollManagement.Back.Api.ModuleParametrizationNovelty.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoveltyParametrizationController : ControllerBase
    {
        private readonly INoveltyParametrizationService _noveltyParametrizationService;
        public ILogger<NoveltyParametrizationController> _loggger;
        private readonly IMapper _mapper;
        public NoveltyParametrizationController(INoveltyParametrizationService noveltyParametrizationService, ILogger<NoveltyParametrizationController> loggger, IMapper mapper)
        {
            _noveltyParametrizationService = noveltyParametrizationService;
            _loggger = loggger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task <IActionResult> Create([FromBody] ParametrizationNovelty newNovelty)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    await _noveltyParametrizationService.AddAsync(newNovelty);
                    var noveltyParametrizationId = newNovelty.Id;
                    return Ok(new {Id = noveltyParametrizationId});
                }
                return BadRequest(ModelState);
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
                var novelties = await _noveltyParametrizationService.GetAllAsync();
                if (novelties.Any())
                {
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
        public async Task<IActionResult> Update([FromBody] ParametrizationNovelty updateNovelty)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _noveltyParametrizationService.UpdateAsync(updateNovelty);
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
                var novelty = await _noveltyParametrizationService.GetByIdAsync(id);
                if (novelty == null)
                    return NotFound("Parametrization does not exist");
                novelty.IsDeleted = true;
                //Pending to see user that updates if its by jwt and identity
                await _noveltyParametrizationService.UpdateAsync(novelty);
                return Accepted();

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
    }
}
