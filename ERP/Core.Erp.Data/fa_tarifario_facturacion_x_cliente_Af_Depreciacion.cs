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
    
    public partial class fa_tarifario_facturacion_x_cliente_Af_Depreciacion
    {
        public fa_tarifario_facturacion_x_cliente_Af_Depreciacion()
        {
            this.fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det = new HashSet<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdDepreciacion { get; set; }
        public decimal IdTarifario { get; set; }
        public int IdTipoDepreciacion { get; set; }
        public int IdPeriodo { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime Fecha_Depreciacion { get; set; }
        public int Num_Act_Depre { get; set; }
        public double Valor_Tot_Act { get; set; }
        public double Valor_Tot_Depre { get; set; }
        public double Valor_Tot_DepreAcum { get; set; }
        public double Valot_Tot_Importe { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnula { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
    
        public virtual fa_tarifario_facturacion_x_cliente fa_tarifario_facturacion_x_cliente { get; set; }
        public virtual ICollection<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det> fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det { get; set; }
    }
}
