//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Academico
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aca_Rubro_x_Aca_Periodo_Lectivo
    {
        public int IdInstitucion_rub { get; set; }
        public int IdRubro { get; set; }
        public int IdInstitucion_per { get; set; }
        public int IdAnioLectivo { get; set; }
        public int IdPeriodo { get; set; }
        public double Valor { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }
    
        public virtual Aca_periodo Aca_periodo { get; set; }
        public virtual Aca_Rubro Aca_Rubro { get; set; }
    }
}