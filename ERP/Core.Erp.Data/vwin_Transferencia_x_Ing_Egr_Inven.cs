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
    
    public partial class vwin_Transferencia_x_Ing_Egr_Inven
    {
        public int IdEmpresa { get; set; }
        public int IdSucursalOrigen { get; set; }
        public int IdBodegaOrigen { get; set; }
        public decimal IdTransferencia { get; set; }
        public int IdSucursalDest { get; set; }
        public int IdBodegaDest { get; set; }
        public string tr_Observacion { get; set; }
        public System.DateTime tr_fecha { get; set; }
        public Nullable<int> IdEmpresa_Ing_Egr_Inven_Origen { get; set; }
        public Nullable<int> IdSucursal_Ing_Egr_Inven_Origen { get; set; }
        public Nullable<decimal> IdNumMovi_Ing_Egr_Inven_Origen { get; set; }
        public Nullable<int> IdEmpresa_Ing_Egr_Inven_Destino { get; set; }
        public Nullable<int> IdSucursal_Ing_Egr_Inven_Destino { get; set; }
        public Nullable<decimal> IdNumMovi_Ing_Egr_Inven_Destino { get; set; }
        public string Estado { get; set; }
        public int IdMovi_inven_tipo_Origen { get; set; }
        public Nullable<int> IdMotivo_Inv_Origen { get; set; }
        public int IdMovi_inven_tipo_Destino { get; set; }
        public Nullable<int> IdMotivo_Inv_Destino { get; set; }
        public string Codigo { get; set; }
    }
}
