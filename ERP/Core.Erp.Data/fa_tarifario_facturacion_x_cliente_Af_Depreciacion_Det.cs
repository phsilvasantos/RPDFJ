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
    
    public partial class fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det
    {
        public int IdEmpresa { get; set; }
        public decimal IdDepreciacion { get; set; }
        public decimal IdTarifario { get; set; }
        public int Secuencia { get; set; }
        public int IdTipoDepreciacion { get; set; }
        public int IdActivoFijo { get; set; }
        public string Concepto { get; set; }
        public double Valor_Compra { get; set; }
        public double Valor_Salvamento { get; set; }
        public int Vida_Util { get; set; }
        public double Porc_Depreciacion { get; set; }
        public double Valor_Depreciacion { get; set; }
        public double Valor_Depre_Acum { get; set; }
        public double Valor_Importe { get; set; }
        public int IdPeriodo { get; set; }
    
        public virtual fa_tarifario_facturacion_x_cliente_Af_Depreciacion fa_tarifario_facturacion_x_cliente_Af_Depreciacion { get; set; }
    }
}
