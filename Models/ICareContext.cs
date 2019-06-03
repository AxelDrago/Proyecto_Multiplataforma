using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proyecto_Multiplataforma.Models;
namespace Proyecto_Multiplataforma.Models
{
    public class ICareContext: IdentityDbContext
    {
         public DbSet<Mascota> Mascotas { get; set; }

        public ICareContext(DbContextOptions<ICareContext> options) : base(options) { }

    }
}