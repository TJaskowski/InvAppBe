
public class CompanyRepository : ICompanyRepository
{
    private readonly InvoiceDbContext _context;

    public CompanyRepository(InvoiceDbContext context)
    {
        _context = context;
    }

    public Task<Company> AddAsync(Company item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Company>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Company> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Company> UpdateAsync(Company item)
    {
        throw new NotImplementedException();
    }
}