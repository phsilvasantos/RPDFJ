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
    
    public partial class ct_cbtecble_tipo
    {
        public ct_cbtecble_tipo()
        {
            this.ct_cbtecble = new HashSet<ct_cbtecble>();
            this.ct_cbtecble_Plantilla = new HashSet<ct_cbtecble_Plantilla>();
            this.ct_parametro = new HashSet<ct_parametro>();
            this.ct_parametro1 = new HashSet<ct_parametro>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdTipoCbte { get; set; }
        public string CodTipoCbte { get; set; }
        public string tc_TipoCbte { get; set; }
        public string tc_Estado { get; set; }
        public string tc_Interno { get; set; }
        public string tc_Nemonico { get; set; }
        public Nullable<int> IdTipoCbte_Anul { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
    
        public virtual ICollection<ct_cbtecble> ct_cbtecble { get; set; }
        public virtual ICollection<ct_cbtecble_Plantilla> ct_cbtecble_Plantilla { get; set; }
        public virtual ICollection<ct_parametro> ct_parametro { get; set; }
        public virtual ICollection<ct_parametro> ct_parametro1 { get; set; }
    }
}
