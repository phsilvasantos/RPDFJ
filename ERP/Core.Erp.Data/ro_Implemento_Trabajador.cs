//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ro_Implemento_Trabajador
    {
        public ro_Implemento_Trabajador()
        {
            this.ro_Asignacion_Implemento_x_Empleado_det = new HashSet<ro_Asignacion_Implemento_x_Empleado_det>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdImplemento { get; set; }
        public string descripcion { get; set; }
        public Nullable<decimal> IdProducto_Inv { get; set; }
        public int IdTipoImplemento { get; set; }
        public System.DateTime FechaCompra { get; set; }
        public double CostoCompra { get; set; }
        public string Estado { get; set; }
        public Nullable<bool> Maneja_Invent { get; set; }
    
        public virtual ro_implemento_Trabajador_Tipo ro_implemento_Trabajador_Tipo { get; set; }
        public virtual ICollection<ro_Asignacion_Implemento_x_Empleado_det> ro_Asignacion_Implemento_x_Empleado_det { get; set; }
    }
}
