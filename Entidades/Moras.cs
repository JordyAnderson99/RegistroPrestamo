using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroPrestamo.Entidades
{
    public class Moras
    {
        [Key]
        public int MoraId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public Decimal Total { get; set; }

        [ForeignKey("MoraId")]

        public List<MorasDetalle> Detalle { get; set; } = new List<MorasDetalle>();

    }
}