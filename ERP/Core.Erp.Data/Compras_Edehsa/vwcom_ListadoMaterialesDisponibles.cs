//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Compras_Edehsa
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwcom_ListadoMaterialesDisponibles
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdProducto { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public string CodigoBarra { get; set; }
        public Nullable<double> dm_cantidad { get; set; }
        public string mv_tipo_movi { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public string bodega { get; set; }
        public string observacion { get; set; }
        public double dm_precio { get; set; }
        public double mv_costo { get; set; }
        public double longitud { get; set; }
        public double espesor { get; set; }
        public double ancho { get; set; }
        public double alto { get; set; }
        public double ceja { get; set; }
        public double diametro { get; set; }
        public string descripcion_corta { get; set; }
        public int densidad { get; set; }
        public int Secuencia { get; set; }
        public int mv_Secuencia { get; set; }
        public string dm_observacion { get; set; }
        public decimal IdNumMovi { get; set; }
        public string ot_CodObra { get; set; }
        public Nullable<decimal> ot_IdOrdenTaller { get; set; }
        public decimal secmax { get; set; }
        public Nullable<double> largo_conversion { get; set; }
        public Nullable<double> alto_conversion { get; set; }
        public double cantidad { get; set; }
        public string CodObra_preasignada { get; set; }
        public Nullable<decimal> IdOrdenTaller_preasignada { get; set; }
    }
}
