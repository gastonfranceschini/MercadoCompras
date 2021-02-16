using System;
using System.ComponentModel.DataAnnotations;

namespace MercadoCompras.Models
{
    public abstract class Usuario
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(100, ErrorMessage = "La longitud máxima del campo es de 100 caracteres")]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = "El campo admite sólo caracteres alfabéticos")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(100, ErrorMessage = "La longitud máxima del campo es de 100 caracteres")]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = "El campo admite sólo caracteres alfabéticos")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Alta")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy H:mm}")]
        public DateTime FechaAlta { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(50, ErrorMessage = "La longitud máxima del campo es de 50 caracteres")]
        [RegularExpression(@"[a-zA-Z0-9_\-]*", ErrorMessage = "El campo admite sólo caracteres alfanuméricos, guión bajo o guión medio")]
        [Display(Name = "Nombre de usuario")]
        public string Username { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Constraseña")]
        public byte[] Password { get; set; }

        public string NombreYApellido => $"{Nombre} {Apellido}";

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [EmailAddress(ErrorMessage = "Ingrese un email valido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MinLength(8, ErrorMessage = "El campo {0} debe tener como minimo {1} caracteres")]
        [MaxLength(10, ErrorMessage = "El campo {0} debe tener como maximo {1} caracteres")]
        public string Telefono { get; set; }
    }
}
