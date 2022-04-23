using System.ComponentModel.DataAnnotations;

namespace Concert.Data.Entities
{
    public class Entrance
    {
        public int Id { get; set; }

        [Display(Name = "Descripcion de la entrada")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Required]
        public String Description { get; set; }

        //public ICollection<Ticket> Tickets { get; set; }
    }
}
