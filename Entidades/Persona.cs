using System;
using System.ComponentModel.DataAnnotations;

namespace RegistroPrestamo.Entidades{

    public class Persona{
        [Key]
        public int PersonaId  { get; set; }
        public string Nombres { get; set; }
        public DateTime Fecha { get; set; }= DateTime.Now;
        public decimal Balance { get; set; }

    }
}

