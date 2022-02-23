﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Ingresosgenerales
    {
        public int IdIngresoGeneral { get; set; }
        public int IdUsuario { get; set; }
        public int IdConceptoIngreso { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }
        public string Socio { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public byte? Mes { get; set; }
        public short? Anio { get; set; }
        public string OrigenPago { get; set; }
        public string Estado { get; set; }

        public virtual Conceptoingresos IdConceptoIngresoNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
    }
}
