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
    
    public partial class ro_Nomina_Tipoliqui
    {
        public ro_Nomina_Tipoliqui()
        {
            this.ro_Ing_Egre_x_Empleado = new HashSet<ro_Ing_Egre_x_Empleado>();
            this.ro_nomina_tipo_liqui_orden = new HashSet<ro_nomina_tipo_liqui_orden>();
            this.ro_rol = new HashSet<ro_rol>();
            this.ro_periodo_x_ro_Nomina_TipoLiqui = new HashSet<ro_periodo_x_ro_Nomina_TipoLiqui>();
            this.ro_nomina_x_horas_extras = new HashSet<ro_nomina_x_horas_extras>();
            this.ro_empleado_Novedad = new HashSet<ro_empleado_Novedad>();
            this.ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar = new HashSet<ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdNomina_TipoLiqui { get; set; }
        public string DescripcionProcesoNomina { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public Nullable<System.DateTime> FechaAnu { get; set; }
        public System.DateTime FechaTransac { get; set; }
        public Nullable<System.DateTime> FechaUltModi { get; set; }
        public string Estado { get; set; }
    
        public virtual ICollection<ro_Ing_Egre_x_Empleado> ro_Ing_Egre_x_Empleado { get; set; }
        public virtual ICollection<ro_nomina_tipo_liqui_orden> ro_nomina_tipo_liqui_orden { get; set; }
        public virtual ICollection<ro_rol> ro_rol { get; set; }
        public virtual ICollection<ro_periodo_x_ro_Nomina_TipoLiqui> ro_periodo_x_ro_Nomina_TipoLiqui { get; set; }
        public virtual ICollection<ro_nomina_x_horas_extras> ro_nomina_x_horas_extras { get; set; }
        public virtual ro_Nomina_Tipo ro_Nomina_Tipo { get; set; }
        public virtual ICollection<ro_empleado_Novedad> ro_empleado_Novedad { get; set; }
        public virtual ICollection<ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar> ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar { get; set; }
    }
}
