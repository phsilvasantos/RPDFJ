//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Facturacion
{
    using System;
    using System.Collections.Generic;
    
    public partial class fa_factura_x_in_movi_inve_x_Anulacion
    {
        public int fa_IdEmpresa { get; set; }
        public int fa_IdSucursal { get; set; }
        public int fa_IdBodega { get; set; }
        public decimal fa_IdCbteVta { get; set; }
        public int inv_IdEmpresa { get; set; }
        public int inv_IdSucursal { get; set; }
        public int inv_IdBodega { get; set; }
        public int inv_IdMovi_inven_tipo { get; set; }
        public decimal inv_IdNumMovi { get; set; }
        public string Observacion { get; set; }
    
        public virtual fa_factura fa_factura { get; set; }
    }
}
