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
    
    public partial class Aca_estudiante
    {
        public Aca_estudiante()
        {
            this.Aca_estudiante_x_Alergia = new HashSet<Aca_estudiante_x_Alergia>();
            this.fa_factura_aca = new HashSet<fa_factura_aca>();
            this.Aca_matricula = new HashSet<Aca_matricula>();
            this.fa_notaCredDeb_aca = new HashSet<fa_notaCredDeb_aca>();
            this.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula = new HashSet<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula>();
            this.Aca_Familiar_x_Estudiante = new HashSet<Aca_Familiar_x_Estudiante>();
            this.Aca_Pre_Facturacion_det = new HashSet<Aca_Pre_Facturacion_det>();
        }
    
        public int IdInstitucion { get; set; }
        public decimal IdEstudiante { get; set; }
        public string cod_estudiante { get; set; }
        public string lugar { get; set; }
        public string IdPais_Nacionalidad { get; set; }
        public string barrio { get; set; }
        public byte[] foto { get; set; }
        public string estado { get; set; }
        public string cod_alterno { get; set; }
        public decimal IdPersona { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public Nullable<decimal> IdAspirante { get; set; }
        public string MotivoAnulacion { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string IdPais_Nacionalidad2 { get; set; }
        public string IdPais_Nacionalidad3 { get; set; }
        public string cod_estudiante2 { get; set; }
    
        public virtual ICollection<Aca_estudiante_x_Alergia> Aca_estudiante_x_Alergia { get; set; }
        public virtual Aca_ficha_medica Aca_ficha_medica { get; set; }
        public virtual ICollection<fa_factura_aca> fa_factura_aca { get; set; }
        public virtual ICollection<Aca_matricula> Aca_matricula { get; set; }
        public virtual ICollection<fa_notaCredDeb_aca> fa_notaCredDeb_aca { get; set; }
        public virtual ICollection<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula> Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula { get; set; }
        public virtual ICollection<Aca_Familiar_x_Estudiante> Aca_Familiar_x_Estudiante { get; set; }
        public virtual Aca_Institucion Aca_Institucion { get; set; }
        public virtual ICollection<Aca_Pre_Facturacion_det> Aca_Pre_Facturacion_det { get; set; }
    }
}
