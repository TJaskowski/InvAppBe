using InvoiceDomain.Models;
using Microsoft.EntityFrameworkCore;

public class InvoiceDbContext : DbContext
{
    public InvoiceDbContext(DbContextOptions<InvoiceDbContext> options) : base(options) { }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>()
        .OwnsOne(c => c.ContactDetails);
        modelBuilder.Entity<Customer>()
            .OwnsOne(c => c.ContactDetails);
        modelBuilder.Entity<Invoice>()
            .HasOne(i => i.Company)
            .WithMany()
            .HasForeignKey("CompanyId")
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Invoice>()
            .HasOne(i => i.Customer)
            .WithMany()
            .HasForeignKey("CustomerId")
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Invoice>()
            .HasMany(i => i.Products)
            .WithMany()
            .UsingEntity(j => j.ToTable("InvoiceProducts"));

        base.OnModelCreating(modelBuilder);
    }
}