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
    
    public partial class vwFa_Documento_DeclaracionSRI_DATA
    {
        public long IdFila { get; set; }
        public string tpIdCliente { get; set; }
        public string idCliente { get; set; }
        public string tipoComprobante { get; set; }
        public string numeroComprobantes { get; set; }
        public Nullable<decimal> baseNoGraIva { get; set; }
        public Nullable<decimal> baseImponible { get; set; }
        public Nullable<decimal> baseImpGrav { get; set; }
        public Nullable<decimal> montoIva { get; set; }
        public int IdEmpresa { get; set; }
        public Nullable<int> anio { get; set; }
        public Nullable<int> mes { get; set; }
        public string Razon_Social { get; set; }
    }
}
