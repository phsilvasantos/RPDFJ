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
    
    public partial class vwcp_Orden_Giro_Conciliado_x_Ing_Bod_x_OC
    {
        public int IdEmpresa { get; set; }
        public decimal IdAprobacion { get; set; }
        public int IdEmpresaConciliacion { get; set; }
        public decimal IdConciliacion { get; set; }
        public int Secuencia { get; set; }
        public int IdEmpresa_Ing_Egr_Inv { get; set; }
        public int IdSucursal_Ing_Egr_Inv { get; set; }
        public decimal IdNumMovi_Ing_Egr_Inv { get; set; }
        public int Secuencia_Ing_Egr_Inv { get; set; }
        public int IdBodega { get; set; }
        public System.DateTime Fecha_Ing_Bod { get; set; }
        public decimal IdProducto { get; set; }
        public string nom_producto { get; set; }
        public string IdUnidadMedida { get; set; }
        public string nom_medida { get; set; }
        public string nom_bodega { get; set; }
        public string nom_sucursal { get; set; }
        public double Cantidad { get; set; }
        public double Costo_uni { get; set; }
        public double do_porc_des { get; set; }
        public bool do_ManejaIva { get; set; }
        public decimal IdProveedor { get; set; }
        public string pr_nombre { get; set; }
        public Nullable<decimal> IdOrdenCompra { get; set; }
    }
}
