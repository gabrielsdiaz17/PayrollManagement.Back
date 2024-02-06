using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Back.Api.ModulePayrollType.Interface;
using PayrollManagement.Back.Business.Models;

namespace PayrollManagement.Back.Api.ModulePayrollType.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayrollTypeController : ControllerBase
    {
        private readonly IPayrollTypeService _payrollTypeService;
        private readonly ILogger<PayrollTypeController> _logger; 
        public PayrollTypeController(IPayrollTypeService payrollTypeService, ILogger<PayrollTypeController> logger)
        {
            _payrollTypeService = payrollTypeService;
            _logger = logger;
        }
        [HttpPost]
        public async Task <IActionResult> Create([FromBody] PayrollType payrollType)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    await _payrollTypeService.AddAsync(payrollType);
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
        public async Task <IActionResult> GetAll()
        {
            try
            {
                var allPayRollTypes = await _payrollTypeService.GetAllAsync();
                if(allPayRollTypes.Any())
                {
                    return Ok(allPayRollTypes);
                }
                return NotFound();
            }
            catch (Exception ex) 
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpPut]
        public async Task <IActionResult> Update([FromBody] PayrollType payrollType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _payrollTypeService.UpdateAsync(payrollType);
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
        public async Task <IActionResult> Delete(int id)
        {
            try
            {
                var payrollType = await _payrollTypeService.GetByIdAsync(id);
                if (payrollType == null)
                    return NotFound("Payroll type not found");
                payrollType.IsDeleted = true;
                payrollType.IsActive = false;
                await _payrollTypeService.UpdateAsync(payrollType);
                return Accepted();
            } 
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
    }
}
