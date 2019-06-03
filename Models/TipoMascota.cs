
using System.Collections.Generic;
namespace Proyecto_Multiplataforma_1.Models
{
    public class TipoMascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Mascota> Mascotas { get; set; }
    }
}