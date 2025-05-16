using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Vino
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Bodega")]
        public int BodegaId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        public string Tipo { get; set; }

        [Required]
        public DateTime Año { get; set; }

        public decimal Graduacion { get; set; }

        [Required]
        public float Precio { get; set; }

        public int Stock { get; set; }

        public string? NombreBodega { get; set; }
        


    }
}