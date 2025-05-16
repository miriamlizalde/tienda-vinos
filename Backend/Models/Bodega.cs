using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

       
        public bool Ecologica { get; set; }

        [Required]
        [StringLength(100)]
        public string Localizacion { get; set; }

       
        public bool Activa { get; set; }
    }
}