using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoCompras.Models
{
    public class Sucursal
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(100, ErrorMessage = "La longitud máxima del campo es de 100 caracteres")]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = "El campo admite sólo caracteres alfabéticos")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MinLength(8, ErrorMessage = "El campo {0} debe tener como minimo {1} caracteres")]
        [MaxLength(10, ErrorMessage = "El campo {0} debe tener como maximo {1} caracteres")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [EmailAddress(ErrorMessage = "Ingrese un email valido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        public List<StockItem> StockItems { get; set; }

        //Consulto para poder eliminar una sucursal ya que no debe tener productos en su stock
        private bool TengoItems()
        {
            return StockItems.Count() > 0;
        }
    }
}
