using Microsoft.EntityFrameworkCore;
using MKP.Domain;

namespace MKP.Data;

public class MainContext : DbContext
{
    public MainContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Person> Person { get; set; }
}