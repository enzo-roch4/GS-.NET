using System.ComponentModel.DataAnnotations;

namespace PlanejadorViagens.Models
{
    public class Carro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Modelo { get; set; }

        [Required]
        public double Autonomia { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
