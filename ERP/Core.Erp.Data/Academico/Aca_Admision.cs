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
    
    public partial class Aca_Admision
    {
        public int IdInstitucion { get; set; }
        public decimal IdAdmision { get; set; }
        public string cod_Admision { get; set; }
        public decimal IdAspirante { get; set; }
        public int IdAnioLectivo { get; set; }
        public int IdCurso { get; set; }
        public string IdCatalogo_Grupo_Fami_convivencia { get; set; }
        public string IdCatalogo_Tipo_Religion { get; set; }
        public string IdCatalogo_Tipo_Sangre { get; set; }
        public string IdCatalogo_Idioma_Nati { get; set; }
        public string Telefono_Emer { get; set; }
        public bool Posee_Discapacidad { get; set; }
        public bool Hijo_unico { get; set; }
        public bool Actu_Asis_Estable_Edu { get; set; }
        public string Estable_Edu_donde_asis { get; set; }
        public bool Tiene_Her_otros_cole { get; set; }
        public bool Tiene_Her_nuestro_cole { get; set; }
        public string En_q_grado_tiene_her { get; set; }
        public bool Hijo_de_prof_del_coleg { get; set; }
        public string cod_Alterno { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string Estado { get; set; }
        public string MotivoAnulacion { get; set; }
    
        public virtual Aca_Anio_Lectivo Aca_Anio_Lectivo { get; set; }
        public virtual Aca_Aspirante Aca_Aspirante { get; set; }
        public virtual Aca_Catalogo Aca_Catalogo { get; set; }
        public virtual Aca_Catalogo Aca_Catalogo1 { get; set; }
        public virtual Aca_Catalogo Aca_Catalogo2 { get; set; }
        public virtual Aca_Catalogo Aca_Catalogo3 { get; set; }
        public virtual Aca_curso Aca_curso { get; set; }
    }
}
