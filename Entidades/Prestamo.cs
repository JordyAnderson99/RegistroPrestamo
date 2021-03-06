using System;
using System.ComponentModel.DataAnnotations;

namespace RegistroPrestamo.Entidades{

    public class Prestamo{
        [Key]
        public int  PrestamoId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int PersonaId  { get; set; }
        public string Concepto { get; set; }
        public decimal Monto { get; set; }
        public decimal Balance { get; set; }
    }
}