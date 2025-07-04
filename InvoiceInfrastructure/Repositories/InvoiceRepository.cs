using InvoiceDomain.Models;

public class InvoiceRepository : IInvoiceRepository
{
    private readonly InvoiceDbContext _context;
    public InvoiceRepository(InvoiceDbContext context)
    {
        _context = context;
    }
    public async Task<Invoice> AddAsync(Invoice item)
    {
        var invoice = await _context.Invoices.FindAsync(item.InvoiceId);
        if (invoice != null)
        {
            throw new InvalidOperationException("Invoice already exists.");
        }
        _context.Invoices.Add(item);
        await _context.SaveChangesAsync();
        return item;
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Invoice>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Invoice> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Invoice> UpdateAsync(Invoice item)
    {
        throw new NotImplementedException();
    }
}
