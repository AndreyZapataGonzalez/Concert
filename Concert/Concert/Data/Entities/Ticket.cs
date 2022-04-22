using System.ComponentModel.DataAnnotations;

namespace Concert.Data.Entities
{
    public class Ticket
    {
        public int Id { get; set; }


        [Required]
        public Boolean WasUsed { get; set; }

        [Display(Name = "Nro Documento")]
        [MaxLength(20, ErrorMessage ="El campo {0} debe tener maximo {1} caracteres")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        public String Document { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Nombre completo")]
        [MaxLength(50, ErrorMessage="El campo {0} debe tener maximo {1} caracteres")]
        public String Name { get; set; }

        public Entrance Entrance { get; set; }

        public DateTime Date { get; set; }
    }
}
