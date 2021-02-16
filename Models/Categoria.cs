using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MercadoCompras.Models
{
    public class Categoria
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(100, ErrorMessage = "La longitud máxima del campo es de 100 caracteres")]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = "El campo admite sólo caracteres alfabéticos")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(200, ErrorMessage = "La longitud máxima del campo es de {1} caracteres")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        public List<Producto> Productos { get; set; }

    }
}
