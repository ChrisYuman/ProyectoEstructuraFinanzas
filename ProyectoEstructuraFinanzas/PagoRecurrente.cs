﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuraFinanzas
{
    public class PagoRecurrente
    {
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaInicio { get; set; }
        public int IntervaloDias { get; set; }
        public DateTime FechaPago { get; set; }
    }
}
