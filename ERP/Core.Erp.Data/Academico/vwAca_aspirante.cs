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
    
    public partial class vwAca_aspirante
    {
        public int IdInstitucion { get; set; }
        public decimal IdAspirante { get; set; }
        public string cod_aspirante { get; set; }
        public string lugar { get; set; }
        public string IdPais_Nacionalidad { get; set; }
        public string barrio { get; set; }
        public string estado { get; set; }
        public string cod_alterno { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string IdTipoDocumento { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_direccion { get; set; }
        public string pe_telefonoCasa { get; set; }
        public string pe_celular { get; set; }
        public string pe_correo { get; set; }
        public string pe_sexo { get; set; }
        public Nullable<System.DateTime> pe_fechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public byte[] foto { get; set; }
        public decimal IdPersona { get; set; }
    }
}
