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
    
    public partial class Af_Poliza_x_AF
    {
        public int IdEmpresa { get; set; }
        public decimal IdPoliza { get; set; }
        public decimal IdProveedor { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string cod_poliza { get; set; }
        public System.DateTime fecha { get; set; }
        public string observacion { get; set; }
        public System.DateTime fecha_vigencia_desde { get; set; }
        public System.DateTime fecha_vigencia_hasta { get; set; }
        public int num_cuotas { get; set; }
        public double valor_cuota { get; set; }
        public System.DateTime fecha_1era_cuota { get; set; }
        public double suma_asegurada { get; set; }
        public int total_meses { get; set; }
        public double subtotal { get; set; }
        public double porc_iva { get; set; }
        public double iva { get; set; }
        public double Total { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotivoAnulacion { get; set; }
        public string Estado { get; set; }
        public Nullable<double> subtotal_noIva { get; set; }
        public Nullable<double> pago_contado { get; set; }
    }
}
