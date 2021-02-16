using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoCompras.Models
{
    public class Carrito
    {
        [Key]
        public Guid Id { get; set; }

        //El carrito se crea automaticamente con la creación de un cliente, en estado activo
        public Boolean Activo { get; set; } = true;

        [ForeignKey(nameof(Cliente))]
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public decimal SubTotal { get => CalcularSubtotal(); }
        public List<CarritoItem> CarritoItems { get; set; }

        //El subtotal es un dato calculado
        private decimal CalcularSubtotal() {
            decimal subtotal = 0;
            foreach (CarritoItem item in CarritoItems) {
                subtotal += item.Subtotal;
            }
            return subtotal;
        }

        //Al vaciar el carrito se eliminan todos los CarritoItems y datos que sean necesarios
        private void LimpiarCarrito() {
            CarritoItems.Clear();
        }
    }
}
