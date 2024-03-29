﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MercadoCompras.Models
{
    public class Cliente : Usuario
    {
        [Required(ErrorMessage = "Este campo es requerido")]
        [RegularExpression(@"[0-9]{2}\.[0-9]{3}\.[0-9]{3}", ErrorMessage = "El campo debe ser del formato NN.NNN.NNN")]
        [MaxLength(20, ErrorMessage = "El campo {0} tiene un máximo de {1} caracteres")]
        [Display(Name = "DNI")]
        public string Dni { get; set; }

        public List<Compra> Compras { get; set; }
        public List<Carrito> Carritos { get; set; }
    }
}
