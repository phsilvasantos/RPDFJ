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
    
    public partial class vwAca_matricula
    {
        public int IdInstitucion { get; set; }
        public decimal IdMatricula { get; set; }
        public string CodMatricula { get; set; }
        public System.DateTime Fecha_matricula { get; set; }
        public decimal IdEstudiante { get; set; }
        public Nullable<decimal> IdFamiliar_repre_econ { get; set; }
        public Nullable<decimal> IdFamiliar_repre_legal { get; set; }
        public string Observacion { get; set; }
        public decimal IdPersona { get; set; }
        public string estado { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_nombre { get; set; }
        public string pe_apellido { get; set; }
        public int IdParalelo { get; set; }
        public int IdCurso { get; set; }
        public int IdSeccion { get; set; }
        public int IdJornada { get; set; }
        public int IdSede { get; set; }
        public bool Cod_convivencia_doy_fe { get; set; }
        public bool Si_estoy_deacuerdo_foto { get; set; }
        public bool No_estoy_deacuerdo_foto { get; set; }
        public int IdAnioLectivo { get; set; }
        public Nullable<decimal> IdPersonaFacturar { get; set; }
    }
}
