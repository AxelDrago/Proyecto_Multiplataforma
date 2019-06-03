using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_Multiplataforma_1.Models
{
    public class ICareContext: IdentityDbContext
    {
         public DbSet<Producto> Productos { get; set; }

        public TiendaContext(DbContextOptions<TiendaContext> options) : base(options) { }

    }
}