//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Reportes
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwINV_Rpt022
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdDev_Inven { get; set; }
        public int secuencia { get; set; }
        public int IdEmpresa_movi_inv { get; set; }
        public int IdSucursal_movi_inv { get; set; }
        public int IdBodega_movi_inv { get; set; }
        public int IdMovi_inven_tipo_movi_inv { get; set; }
        public decimal IdNumMovi_movi_inv { get; set; }
        public int Secuencia_movi_inv { get; set; }
        public string cod_Dev_Inven { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal num_egreso { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string nom_punto_cargo { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public string Descripcion { get; set; }
        public double cantidad_a_devolver { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string observacion { get; set; }
    }
}
