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
    
    public partial class ro_participacion_utilidad
    {
        public ro_participacion_utilidad()
        {
            this.ro_participacion_utilidad_empleado = new HashSet<ro_participacion_utilidad_empleado>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdPeriodo { get; set; }
        public double UtilidadDerechoIndividual { get; set; }
        public double UtilidadCargaFamiliar { get; set; }
        public double LimiteDistribucionUtilidad { get; set; }
        public System.DateTime FechaIngresa { get; set; }
        public string UsuarioIngresa { get; set; }
        public string Observacion { get; set; }
    
        public virtual ICollection<ro_participacion_utilidad_empleado> ro_participacion_utilidad_empleado { get; set; }
    }
}
