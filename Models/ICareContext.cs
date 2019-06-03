using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_Multiplataforma_1.Models
{
    public class ICareContext: IdentityDbContext
    {
         public DbSet<Mascota> Mascota { get; set; }

        public TiendaContext(DbContextOptions<ICareContext> options) : base(options) { }

    }
}