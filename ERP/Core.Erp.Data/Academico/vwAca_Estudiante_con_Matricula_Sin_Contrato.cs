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
    
    public partial class vwAca_Estudiante_con_Matricula_Sin_Contrato
    {
        public int IdInstitucion { get; set; }
        public int IdSede { get; set; }
        public int IdParalelo { get; set; }
        public int IdCurso { get; set; }
        public int IdSeccion { get; set; }
        public int IdJornada { get; set; }
        public int IdAnioLectivo { get; set; }
        public decimal IdMatricula { get; set; }
        public decimal IdEstudiante { get; set; }
        public string Institucion { get; set; }
        public string Sede { get; set; }
        public string Jornada { get; set; }
        public string Seccion { get; set; }
        public string Curso { get; set; }
        public string Paralelo { get; set; }
        public string pe_nombre { get; set; }
        public string pe_apellido { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_direccion { get; set; }
        public string pe_telefonoCasa { get; set; }
        public string pe_telefonoOfic { get; set; }
        public string cod_estudiante { get; set; }
        public System.DateTime FechaMatricula { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
    }
}
