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
    
    public partial class vwro_marcaciones_x_empleado
    {
        public int IdEmpresa { get; set; }
        public string IdRegistro { get; set; }
        public decimal IdEmpleado { get; set; }
        public string IdTipoMarcaciones { get; set; }
        public decimal secuencia { get; set; }
        public Nullable<System.TimeSpan> es_Hora { get; set; }
        public Nullable<System.DateTime> es_fechaRegistro { get; set; }
        public Nullable<int> es_anio { get; set; }
        public Nullable<int> es_mes { get; set; }
        public Nullable<int> es_semana { get; set; }
        public Nullable<int> es_dia { get; set; }
        public string es_sdia { get; set; }
        public Nullable<int> es_idDia { get; set; }
        public string es_EsActualizacion { get; set; }
        public string IdTipoMarcaciones_Biometrico { get; set; }
        public string nom_compl_empleado { get; set; }
        public string Motivo_Anu { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
        public string IdUsuario { get; set; }
        public System.DateTime Fecha_Transac { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string em_codigo { get; set; }
        public string pe_cedulaRuc { get; set; }
    }
}
