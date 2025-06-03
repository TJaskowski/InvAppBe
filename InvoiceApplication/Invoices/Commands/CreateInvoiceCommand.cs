using System.Net;
using MediatR;

namespace InvoiceApplication.Invoices.Commands;
public class CreateInvoiceCommand : IRequest<int>
{
    public int InvoiceId { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public double NetAmount { get; set; }
    public double TaxAmount { get; set; }
    public double GrossAmount { get; set; }
    public double DiscountAmount { get; set; }

    // Uncomment and define the Company, Customer, and Product classes in InvoiceDomain.Models namespace
    // public Company Company { get; set; }
    // public Customer Customer { get; set; }
    // public List<Product> Products { get; set; } = new List<Product>();
}