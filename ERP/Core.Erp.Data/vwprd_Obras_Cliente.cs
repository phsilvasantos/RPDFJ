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
    
    public partial class vwprd_Obras_Cliente
    {
        public string cl_RazonSocial { get; set; }
        public int IdEmpresa { get; set; }
        public string CodObra { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public System.DateTime Fecha { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public Nullable<System.DateTime> FechaAnu { get; set; }
        public System.DateTime FechaTransac { get; set; }
        public Nullable<System.DateTime> FechaUltModi { get; set; }
        public decimal IdCliente { get; set; }
        public Nullable<decimal> PesoObra { get; set; }
        public string Referencia { get; set; }
    }
}
