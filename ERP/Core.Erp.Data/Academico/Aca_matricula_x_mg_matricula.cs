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
    
    public partial class Aca_matricula_x_mg_matricula
    {
        public int IdInstitucion { get; set; }
        public int IdSede { get; set; }
        public decimal IdMatricula { get; set; }
        public decimal id_matricula_aca { get; set; }
        public string nota1 { get; set; }
    
        public virtual Aca_matricula Aca_matricula { get; set; }
    }
}
