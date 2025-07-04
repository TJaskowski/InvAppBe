using InvoiceAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

public class CustomerController : BaseApiController
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerController(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    [HttpPost]
    public async Task<ActionResult<Customer>> Create(Customer customer)
    {
        var createdCustomer = await _customerRepository.AddAsync(customer);
        return Created($"/api/customers/{createdCustomer.CustomerId}", createdCustomer);
    }
}