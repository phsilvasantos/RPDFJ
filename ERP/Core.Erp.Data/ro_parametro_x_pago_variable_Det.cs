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
    
    public partial class ro_parametro_x_pago_variable_Det
    {
        public int Idempresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int Id_Tipo_Pago_Variable { get; set; }
        public string cod_Pago_Variable { get; set; }
        public double Meta { get; set; }
        public double Variable_porcentaje_prorrateado { get; set; }
    
        public virtual ro_parametro_x_pago_variable ro_parametro_x_pago_variable { get; set; }
        public virtual ro_parametro_x_pago_variable_tipo ro_parametro_x_pago_variable_tipo { get; set; }
    }
}
