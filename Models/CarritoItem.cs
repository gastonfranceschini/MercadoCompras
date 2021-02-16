using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoCompras.Models
{
    public class CarritoItem
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Carrito))]
        public Guid CarritoId { get; set; }
        public Carrito Carrito { get; set; }

        [ForeignKey(nameof(Producto))]
        public Guid ProductoId { get; set; }
        public Producto Producto { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal ValorUnitario { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Cantidad { get; set; }
        public decimal Subtotal { get => CalcularSubtotal(); }

        //El subototal debe ser una propiedad calculada en base a la cantidad por el valor unitario
        private decimal CalcularSubtotal()
        {
            return ValorUnitario*Cantidad;
        }
    }
}
