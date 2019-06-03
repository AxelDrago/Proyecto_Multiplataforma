namespace Proyecto_Multiplataforma.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string NombreTemporal { get; set; }
        public int Edad { get; set; }
        public TipoMascota Tipo { get; set; }
        public string Foto { get; set; }
        public int TipoId { get; set; }
    }
}