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
    
    public partial class vwcom_cotizacion_compra_det
    {
        public int IdEmpresa { get; set; }
        public decimal IdCotizacion { get; set; }
        public int IdSucursal { get; set; }
        public int Secuencia { get; set; }
        public Nullable<decimal> Idproducto { get; set; }
        public Nullable<double> Cant_soli { get; set; }
        public Nullable<double> Cant_a_cotizar { get; set; }
        public Nullable<decimal> IdListadoMateriales_lq { get; set; }
        public string nom_sucursal { get; set; }
        public Nullable<System.DateTime> FechaReg { get; set; }
        public Nullable<int> IdDetalle_lq { get; set; }
        public string pr_descripcion { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
    }
}
