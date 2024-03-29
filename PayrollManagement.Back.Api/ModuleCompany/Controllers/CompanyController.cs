﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollManagement.Back.Api.ModuleCompany.Interfaces;
using PayrollManagement.Back.Api.ModuleCompany.ViewModel;
using PayrollManagement.Back.Business.Models;

namespace PayrollManagement.Back.Api.ModuleCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private ILogger<CompanyController> _logger;
        private readonly IMapper _mapper;
        public CompanyController(ICompanyService companyService, ILogger<CompanyController> logger, IMapper mapper)
        {
            _companyService = companyService;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CompanyViewModel newCompany)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var company = _mapper.Map<Company>(newCompany);
                    await _companyService.AddAsync(company);
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
                var query = await _companyService.GetCompaniesWithCities();
                var companies = _mapper.Map<List<CompanySearchViewModel>>(query);
                return Ok(companies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] CompanyViewModel updateCompany)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var company = _mapper.Map<Company>(updateCompany);
                    await _companyService.UpdateAsync(company);
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
                var company = await _companyService.GetByIdAsync(id);
                if (company == null)
                    return NotFound("Company does not exist");
                company.IsActive = false;
                company.IsDeleted = true;
                await _companyService.UpdateAsync(company);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
    }
}
