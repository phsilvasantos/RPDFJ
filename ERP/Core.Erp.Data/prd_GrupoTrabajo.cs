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
    
    public partial class prd_GrupoTrabajo
    {
        public prd_GrupoTrabajo()
        {
            this.prd_Movimiento_PteGrua = new HashSet<prd_Movimiento_PteGrua>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdGrupoTrabajo { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public decimal IdLider { get; set; }
        public int IdProcesoProductivo { get; set; }
        public int IdEtapa { get; set; }
        public string Estado { get; set; }
        public Nullable<int> IdGrupo { get; set; }
    
        public virtual ICollection<prd_Movimiento_PteGrua> prd_Movimiento_PteGrua { get; set; }
    }
}
