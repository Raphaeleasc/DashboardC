using Microsoft.EntityFrameworkCore;

class EdataDb : DbContext
{
    public EdataDb(DbContextOptions<EdataDb> options)
        : base(options) { }

    public DbSet<Edata> Edatas => Set<Edata>();
}