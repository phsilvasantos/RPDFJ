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
    
    public partial class Aca_Contrato_x_Estudiante
    {
        public Aca_Contrato_x_Estudiante()
        {
            this.Aca_Pre_Facturacion_det = new HashSet<Aca_Pre_Facturacion_det>();
        }
    
        public int IdInstitucion { get; set; }
        public decimal IdContrato { get; set; }
        public int IdSede { get; set; }
        public decimal IdMatricula { get; set; }
        public int IdAnioLectivo { get; set; }
        public decimal IdEstudiante { get; set; }
        public string observacion { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }
        public Nullable<bool> estado_contrato_con_prefactura { get; set; }
        public Nullable<bool> estado_contrato_pago_garantizado { get; set; }
        public bool estado { get; set; }
    
        public virtual Aca_matricula Aca_matricula { get; set; }
        public virtual ICollection<Aca_Pre_Facturacion_det> Aca_Pre_Facturacion_det { get; set; }
    }
}
