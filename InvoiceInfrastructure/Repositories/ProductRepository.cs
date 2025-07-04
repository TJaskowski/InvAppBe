
public class ProductRepository : IProductRepository
{
    private readonly InvoiceDbContext _invoiceDbContext;

    public ProductRepository(InvoiceDbContext invoiceDbContext)
    {
        _invoiceDbContext = invoiceDbContext;
    }

    public Task<Product> AddAsync(Product item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Product> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Product> UpdateAsync(Product item)
    {
        throw new NotImplementedException();
    }
}