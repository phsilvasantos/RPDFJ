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
    
    public partial class vwcp_OrdenGiroRetencionReport
    {
        public int IdEmpresa { get; set; }
        public Nullable<decimal> IdCbteCble_Ogiro { get; set; }
        public Nullable<int> IdTipoCbte_Ogiro { get; set; }
        public decimal IdRetencion { get; set; }
        public int Idsecuencia { get; set; }
        public System.DateTime A_re_fecha { get; set; }
        public string A_SerieRetencion { get; set; }
        public string NumRetencion { get; set; }
        public string re_Tiene_RTiva { get; set; }
        public string re_Tiene_RFuente { get; set; }
        public string re_tipoRet { get; set; }
        public double re_baseRetencion { get; set; }
        public int IdCodigo_SRI { get; set; }
        public string re_Codigo_impuesto { get; set; }
        public double re_Porcen_retencion { get; set; }
        public double re_valor_retencion { get; set; }
        public string re_EstaImpresa { get; set; }
        public string re_estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string nRetencionSRI { get; set; }
        public string FVigCoSRI { get; set; }
        public string codigoSRI { get; set; }
        public string NAutorizacion { get; set; }
        public Nullable<int> IdEmpresa_Ogiro { get; set; }
    }
}
