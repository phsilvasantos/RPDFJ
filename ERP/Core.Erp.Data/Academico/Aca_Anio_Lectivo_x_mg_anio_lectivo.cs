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
    
    public partial class Aca_Anio_Lectivo_x_mg_anio_lectivo
    {
        public int IdInstitucion { get; set; }
        public int IdAnioLectivo { get; set; }
        public decimal id_anio_lectivo_aca { get; set; }
        public string nota1 { get; set; }
    
        public virtual Aca_Anio_Lectivo Aca_Anio_Lectivo { get; set; }
    }
}
