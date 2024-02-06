using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Back.Api.ModulePlainTextFile.Interfaces;
using PayrollManagement.Back.Api.ModulePlainTextFile.ViewModels;
using PayrollManagement.Back.Business.Models;

namespace PayrollManagement.Back.Api.ModulePlainTextFile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlainTextFileRecordController : ControllerBase
    {
        private readonly IPlainTextFileRecordService _plainTextFileRecordService;
        private ILogger <PlainTextFileRecordController> _logger;
        private readonly IMapper _mapper;
        public PlainTextFileRecordController(IPlainTextFileRecordService plainTextFileRecordService, ILogger<PlainTextFileRecordController> logger, IMapper mapper)
        {
            _plainTextFileRecordService = plainTextFileRecordService;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task <IActionResult> Create([FromBody] List<PlainTextFileRecordViewModel> records)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    foreach (var record in records)
                    {
                        var textFileRecord = _mapper.Map<PlainTextFileRecord>(record);
                        await _plainTextFileRecordService.AddAsync(textFileRecord);
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
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] List<PlainTextFileRecordViewModel> records)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    foreach (var record in records)
                    {
                        var textFileRecord = _mapper.Map<PlainTextFileRecord>(record);
                        await _plainTextFileRecordService.UpdateAsync(textFileRecord);
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
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var recordFile = await _plainTextFileRecordService.GetByIdAsync(id);
                if (recordFile == null)
                    return NotFound("Record not found");
                recordFile.IsActive = false;
                recordFile.IsDeleted = true;
                await _plainTextFileRecordService.UpdateAsync(recordFile);
                return Accepted();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
    }
}
