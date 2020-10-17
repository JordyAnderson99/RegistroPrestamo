using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RegistroPrestamo.Entidades
{
    public class MorasDetalle
    {
        [Key]

        public int DetalleId { get; set; }
        public int MoraId { get; set; }
        public int PrestamoId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal Valor { get; set; }

        public MorasDetalle(int detalleId, int moraId, int prestamoId,DateTime fecha, decimal valor)
        {
            DetalleId = detalleId;
            MoraId = moraId;
            PrestamoId = prestamoId;
            Fecha = fecha;
            Valor = valor;
        }

    }
}