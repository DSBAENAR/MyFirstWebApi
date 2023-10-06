using Microsoft.EntityFrameworkCore;
using MyFirstWebAPI.Entidades;

namespace MyFirstWebAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
            public DbSet<Autor> Autores { get; set; }
    }

}
