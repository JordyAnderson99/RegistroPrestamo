using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RegistroPrestamo.Entidades
{
    public class MorasDetalle
    {
        [Key]

        public int Id { get; set; }
        public int MoraId { get; set; }
        public int PrestamoId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal Valor { get; set; }

        public MorasDetalle()
        {
            Id = 0;
            MoraId = 0;
            PrestamoId = 0;
            Fecha = DateTime.Now;
            Valor = 0;
        }
        public MorasDetalle(int moraId, int prestamoId, DateTime fecha, decimal valor)
        {
            Id = 0;
            MoraId = moraId;
            PrestamoId = prestamoId;
            Fecha = fecha;
            Valor = valor;
        }

    }
}