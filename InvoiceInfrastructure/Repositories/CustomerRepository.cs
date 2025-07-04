using InvoiceDomain.Models;

public class CustomerRepository : ICustomerRepository
{
    private readonly InvoiceDbContext _context;

    public CustomerRepository(InvoiceDbContext context)
    {
        _context = context;
    }

    public Task<Customer> AddAsync(Customer item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Customer>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Customer> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> UpdateAsync(Customer item)
    {
        throw new NotImplementedException();
    }
}