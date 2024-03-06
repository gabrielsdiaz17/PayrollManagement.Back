using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Back.Api.ModuleCostCenter.ViewModel;
using PayrollManagement.Back.Api.ModuleSiesaConcept.Interfaces;
using PayrollManagement.Back.Business.Models;

namespace PayrollManagement.Back.Api.ModuleSiesaConcept.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiesaConceptsController : ControllerBase
    {
        private readonly ISiesaConceptService _siesaConceptService;
        private readonly ILogger<SiesaConceptsController> _logger;
        public SiesaConceptsController(ISiesaConceptService siesaConceptService, ILogger<SiesaConceptsController> logger) 
        {
            _siesaConceptService = siesaConceptService;
            _logger = logger;
        }
        [HttpPost]
        public async Task <IActionResult> Create([FromBody] SiesaConcept newConcept)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _siesaConceptService.AddAsync(newConcept);
                    var newConceptId = newConcept.Id;
                    return Ok(new
                    {
                        Id = newConceptId
                    });
                }
                return BadRequest();
            } 
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetSiesaConcepts()
        {
            try
            {
                var query = await _siesaConceptService.GetAllAsync();
                if(query.Any())
                    return Ok(query);
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });

            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] SiesaConcept siesaConcept)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _siesaConceptService.UpdateAsync(siesaConcept);
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
                var siesaConcept = await _siesaConceptService.GetByIdAsync(id);

                if (siesaConcept == null)
                    return NotFound("Cost Center does not exist");
                siesaConcept.IsActive = false;
                siesaConcept.IsDeleted = true;
                //Pending to see user that updates if its by jwt and identity
                await _siesaConceptService.UpdateAsync(siesaConcept);
                return Accepted();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }

        }
    }
}
