using System.ComponentModel.DataAnnotations;

namespace PRT.PRApplication.ViewModels
{
    public class TodoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Descrição é requerido")]
        [MaxLength(200, ErrorMessage = "Numero máximo de caracteres{0}")]
        [MinLength(5, ErrorMessage = "Número mínimo de caracteres{0}")]
        public string Description { get; set; }

        public bool Done { get; set; }
    }
}