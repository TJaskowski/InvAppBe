using InvoiceAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

public class CompanyController : BaseApiController
{
    private readonly ICompanyRepository _companyRepository;
    public CompanyController(ICompanyRepository companyRepository)
    {
        _companyRepository = companyRepository;
    }
    [HttpPost]
    public async Task<ActionResult<Company>> Create(Company company)
    {
        var createdCompany = await _companyRepository.AddAsync(company);
        return Created($"/api/companies/{createdCompany.CompanyId}", createdCompany);
    }
}