using headphones_market.core.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace headphones_market.core.Api.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext( DbContextOptions<AppDbContext> options ) : base( options ) { }


        public DbSet<Keyboard> Keyboards { get; set; }

        public DbSet<Headphone> Headphone {  get; set; }

    }
}
