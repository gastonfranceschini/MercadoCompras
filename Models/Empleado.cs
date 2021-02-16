using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoCompras.Models
{
    public class Empleado : Usuario
    {
        [ScaffoldColumn(false)]
        public Guid Legajo { get; set; }
    }
}
