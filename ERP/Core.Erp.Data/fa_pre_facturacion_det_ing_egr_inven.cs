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
    
    public partial class fa_pre_facturacion_det_ing_egr_inven
    {
        public int IdEmpresa { get; set; }
        public decimal IdPreFacturacion { get; set; }
        public int Secuencia { get; set; }
        public Nullable<int> eg_IdEmpresa { get; set; }
        public Nullable<int> eg_IdSucursal { get; set; }
        public Nullable<int> eg_IdMovi_inven_tipo { get; set; }
        public Nullable<decimal> eg_IdNumMovi { get; set; }
        public Nullable<int> eg_Secuencia { get; set; }
        public Nullable<double> eg_cantidad { get; set; }
        public Nullable<System.DateTime> eg_fecha { get; set; }
        public string eg_codigo { get; set; }
        public Nullable<int> in_IdEmpresa { get; set; }
        public Nullable<int> in_IdSucursal { get; set; }
        public Nullable<int> in_IdMovi_inven_tipo { get; set; }
        public Nullable<decimal> in_IdNumMovi { get; set; }
        public Nullable<int> in_Secuencia { get; set; }
        public Nullable<double> in_cantidad { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public Nullable<System.DateTime> cp_fecha { get; set; }
        public string cp_numero { get; set; }
        public int IdActivoFijo { get; set; }
        public double costo_uni { get; set; }
        public double subtotal { get; set; }
        public decimal IdProducto { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
    
        public virtual fa_pre_facturacion fa_pre_facturacion { get; set; }
    }
}
