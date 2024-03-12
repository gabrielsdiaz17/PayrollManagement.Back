using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Back.Api.ModulePlainTextFile.Interfaces;
using PayrollManagement.Back.Api.ModulePlainTextFile.ViewModels;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.HelperModels;

namespace PayrollManagement.Back.Api.ModulePlainTextFile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlainTextFileController : ControllerBase
    {
        private readonly IPlainTextFileService _plainTextFileService;
        private  ILogger<PlainTextFileController> _logger;
        private readonly IMapper _mapper;
        public PlainTextFileController(IPlainTextFileService plainTextFileService, ILogger<PlainTextFileController> logger, IMapper mapper)
        {
            _plainTextFileService = plainTextFileService;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task <IActionResult> GetAll()
        {
            try
            {
                var query = await _plainTextFileService.GetAll();
                if (query == null)
                {
                    return NotFound("No files Available");
                }
                var files = _mapper.Map<List<PlainTextFileWithRecordsViewModel>>(query);
                return Ok(files);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }

        }
        [HttpPost("getPlaiTextFileByDate")]
        public async Task <IActionResult> GetPlainTextByDates([FromBody] DateGeneralFilter filter)
        {
            try
            {
                var query = await _plainTextFileService.GetPlainTextByDate(filter);
                if (query == null)
                {
                    return NotFound("No files Available");
                }
                var files = _mapper.Map<List<PlainTextFileWithRecordsViewModel>>(query);
                return Ok(files);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpPost]
        public async Task <IActionResult> Create([FromBody] PlainTextFileViewModel model)
        {
            try
            {
                var plainText = _mapper.Map<PlainTextFile>(model);
                DateTime utcUpload = DateTime.SpecifyKind(model.DateUpload, DateTimeKind.Utc);
                plainText.DateUpload = utcUpload;
                await _plainTextFileService.AddAsync(plainText);
                var plainTextFileId = plainText.Id;
                return Ok(new { Id = plainTextFileId });
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
    }
    
}
