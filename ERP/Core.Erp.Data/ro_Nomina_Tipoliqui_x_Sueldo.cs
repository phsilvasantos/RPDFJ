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
    
    public partial class ro_Nomina_Tipoliqui_x_Sueldo
    {
        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdNomina_TipoLiqui { get; set; }
        public double PorSueldo { get; set; }
        public Nullable<bool> PermiteAcumularDecimoTercer { get; set; }
        public Nullable<bool> PermiteAcumularDecimoCuarto { get; set; }
        public Nullable<bool> PermiteAcumularFondoReserva { get; set; }
    }
}
