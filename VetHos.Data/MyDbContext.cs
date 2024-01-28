using Microsoft.EntityFrameworkCore;
using VetHos.Data.Tables;

namespace VetHos.Data;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {

    }

    public DbSet<VetTable> VetTable { get; set; }
}

