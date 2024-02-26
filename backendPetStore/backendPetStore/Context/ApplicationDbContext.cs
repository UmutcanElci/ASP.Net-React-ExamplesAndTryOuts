using backendPetStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace backendPetStore.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<ProductEntity> Products { get; set; }
}