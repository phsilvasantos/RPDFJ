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
    
    public partial class ct_tipo_ctacble
    {
        public ct_tipo_ctacble()
        {
            this.ct_plancta = new HashSet<ct_plancta>();
        }
    
        public string IdTipoCtaCble { get; set; }
        public string nom_TipoCtaCble { get; set; }
        public string estado { get; set; }
    
        public virtual ICollection<ct_plancta> ct_plancta { get; set; }
    }
}