using System;
using System.ComponentModel.DataAnnotations;

namespace MercadoCompras.Models
{
    public class Administrador : Usuario
    {
        [ScaffoldColumn(false)]
        public Guid Legajo { get; set; }
    }
}
