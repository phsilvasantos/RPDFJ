//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwro_Solicitud_Vacaciones_x_empleado
    {
        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdLiquidacion { get; set; }
        public decimal IdEmpleado { get; set; }
        public int Dias_a_disfrutar { get; set; }
        public System.DateTime Fecha_Desde { get; set; }
        public System.DateTime Fecha_Hasta { get; set; }
        public Nullable<bool> Gozadas_Pgadas { get; set; }
        public double ValorCancelado { get; set; }
        public Nullable<double> Iess { get; set; }
    }
}
