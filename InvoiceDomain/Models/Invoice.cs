namespace InvoiceDomain.Models;

public class Invoice
{
     public int InvoiceId { get; set; }
    // public Company Company { get; set; }
    // public Customer Customer { get; set; }
    // public List<Product> Products { get; set; } = new List<Product>(); uncomment after defining Company, Customer, and Product classes
        public string CustomerName { get; set; } = string.Empty;

        public double NetAmount { get; set; }
        public double TaxAmount { get; set; }
        public double GrossAmount { get; set; }
        public double DiscountAmount { get; set; }
}