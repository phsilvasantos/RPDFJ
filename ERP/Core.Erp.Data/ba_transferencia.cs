//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ba_transferencia
    {
        public decimal IdTransferencia { get; set; }
        public int IdEmpresa_origen { get; set; }
        public decimal IdCbteCble_origen { get; set; }
        public int IdTipocbte_origen { get; set; }
        public int IdEmpresa_destino { get; set; }
        public decimal IdCbteCble_destino { get; set; }
        public int IdTipocbte_destino { get; set; }
        public int IdBanco_origen { get; set; }
        public int IdBanco_destino { get; set; }
        public string tr_observacion { get; set; }
        public double tr_valor { get; set; }
        public System.DateTime tr_fecha { get; set; }
        public string tr_estado { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuario_Anu { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public string ip { get; set; }
        public string nom_pc { get; set; }
        public string tr_MotivoAnulacion { get; set; }
    
        public virtual ba_Banco_Cuenta ba_Banco_Cuenta { get; set; }
        public virtual ba_Banco_Cuenta ba_Banco_Cuenta1 { get; set; }
        public virtual ba_Cbte_Ban ba_Cbte_Ban { get; set; }
        public virtual ba_Cbte_Ban ba_Cbte_Ban1 { get; set; }
    }
}
