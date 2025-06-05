using InvoiceAPI.Controllers;
using InvoiceDomain.Models;
using Microsoft.AspNetCore.Mvc;

public class InvoiceController : BaseApiController
{
    private readonly IInvoiceRepository _invoiceRepository;

    public InvoiceController(IInvoiceRepository invoiceRepository)
    {
        _invoiceRepository = invoiceRepository;
    }

    [HttpPost]
    public async Task<ActionResult<Invoice>> Create(Invoice invoice)
    {
        var createdInvoice = await _invoiceRepository.AddAsync(invoice);
        return Created($"/api/invoices/{createdInvoice.InvoiceId}", createdInvoice);
    }

}