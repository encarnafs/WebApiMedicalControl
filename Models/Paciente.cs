using System.ComponentModel.DataAnnotations;

namespace WebApiMedicalControl.Models
{
    public class Paciente
    {
        [Key]
        public int Id_Paciente { get; set; }
        public required string Nombre { get; set; }
        public required string Apellidos { get; set; }
        public char Genero { get; set; }
        public required string DNI { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string? Observaciones { get; set; }

    }
}
