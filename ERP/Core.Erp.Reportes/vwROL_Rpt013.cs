//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Reportes
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwROL_Rpt013
    {
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string pe_cedulaRuc { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdSolicitudVaca { get; set; }
        public string pe_apellido_remplazo { get; set; }
        public string pe_nombre_remplazo { get; set; }
        public System.DateTime Anio_Desde { get; set; }
        public System.DateTime Anio_Hasta { get; set; }
        public int Dias_pendiente { get; set; }
        public int Dias_a_disfrutar { get; set; }
        public string Dias_q_Corresponde { get; set; }
        public string AnioServicio { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.DateTime Fecha_Desde { get; set; }
        public System.DateTime Fecha_Hasta { get; set; }
        public System.DateTime Fecha_Retorno { get; set; }
        public string Observacion { get; set; }
        public string de_descripcion { get; set; }
        public Nullable<long> Canceladas { get; set; }
        public Nullable<bool> Gozadas_Pgadas { get; set; }
        public Nullable<System.DateTime> em_fechaIngaRol { get; set; }
        public string ca_descripcion { get; set; }
        public string Centro_costo { get; set; }
    }
}
