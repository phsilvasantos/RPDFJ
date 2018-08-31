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
    
    public partial class prd_Movimiento_PteGrua
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdPuenteGrua { get; set; }
        public int IdOperador { get; set; }
        public int IdProcesoProductivo { get; set; }
        public int IdMovimiento { get; set; }
        public string CodigoBarra { get; set; }
        public string DescripcionPieza { get; set; }
        public int IdEtapaInicio { get; set; }
        public int IdEtapaSiguiente { get; set; }
        public int ToneladasMover { get; set; }
        public int IdSubgrupoAnt { get; set; }
        public int IdSubgrupoSig { get; set; }
        public string Observacion { get; set; }
        public Nullable<System.DateTime> FechaTransaccion { get; set; }
        public Nullable<System.DateTime> FechaFinProceso { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public Nullable<System.DateTime> FechaAnu { get; set; }
        public Nullable<System.DateTime> FechaUltModi { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> FechaFinTraslado { get; set; }
        public Nullable<System.DateTime> FechaEnEspera { get; set; }
    
        public virtual prd_GrupoTrabajo prd_GrupoTrabajo { get; set; }
        public virtual prd_Movimiento_PteGrua prd_Movimiento_PteGrua1 { get; set; }
        public virtual prd_Movimiento_PteGrua prd_Movimiento_PteGrua2 { get; set; }
    }
}
