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
    
    public partial class fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo
    {
        public int IdEmpresa { get; set; }
        public decimal IdTarifario { get; set; }
        public int IdActivoFijo { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
    
        public virtual fa_tarifario_facturacion_x_cliente fa_tarifario_facturacion_x_cliente { get; set; }
    }
}
