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
    
    public partial class vwcp_Cbte_x_pagar_OG
    {
        public int IdEmpresa { get; set; }
        public string em_nombre { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public decimal IdProveedor { get; set; }
        public string NomProveedor { get; set; }
        public System.DateTime co_fechaOg { get; set; }
        public string co_factura { get; set; }
        public string co_observacion { get; set; }
        public string co_serie { get; set; }
        public Nullable<double> co_total { get; set; }
        public Nullable<double> co_valorpagar { get; set; }
        public Nullable<double> Valor_Respaldado { get; set; }
        public Nullable<double> SaldoPendiente { get; set; }
        public string TipoReg { get; set; }
        public string Descripcion { get; set; }
        public string CodTipoDocumento { get; set; }
        public string Referencia { get; set; }
        public double Total_Retencion { get; set; }
    }
}
