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
    
    public partial class fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre
    {
        public int IdEmpresa { get; set; }
        public decimal IdTarifario { get; set; }
        public int IdActivoFijo { get; set; }
        public Nullable<double> Af_porcentaje_deprec { get; set; }
        public Nullable<int> Af_anios_vida_util { get; set; }
        public Nullable<double> Af_costo_historico { get; set; }
        public Nullable<double> Af_costo_compra { get; set; }
        public Nullable<int> Af_Meses_depreciar { get; set; }
        public Nullable<System.DateTime> Af_fecha_ini_depre { get; set; }
        public Nullable<System.DateTime> Af_fecha_fin_depre { get; set; }
        public Nullable<double> Af_ValorSalvamento { get; set; }
        public Nullable<double> Af_ValorResidual { get; set; }
        public Nullable<bool> se_factura_valorSalvamento { get; set; }
        public Nullable<bool> se_factura_Iva { get; set; }
    
        public virtual fa_tarifario_facturacion_x_cliente fa_tarifario_facturacion_x_cliente { get; set; }
    }
}
