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
    
    public partial class ro_horario_planificacion
    {
        public int IdEmpresa { get; set; }
        public int IdCalendario { get; set; }
        public decimal IdEmpleado { get; set; }
        public decimal IdRegistro { get; set; }
        public decimal IdHorario { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
    
        public virtual ro_horario ro_horario { get; set; }
        public virtual ro_empleado ro_empleado { get; set; }
    }
}
