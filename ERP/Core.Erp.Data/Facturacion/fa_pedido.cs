//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Facturacion
{
    using System;
    using System.Collections.Generic;
    
    public partial class fa_pedido
    {
        public fa_pedido()
        {
            this.fa_pedido_det = new HashSet<fa_pedido_det>();
            this.fa_pedido_x_formaPago = new HashSet<fa_pedido_x_formaPago>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdPedido { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public System.DateTime cp_fecha { get; set; }
        public int cp_diasPlazo { get; set; }
        public System.DateTime cp_fechaVencimiento { get; set; }
        public string cp_observacion { get; set; }
        public string cp_tipopago { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string IdUsuario { get; set; }
        public System.DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public decimal interes { get; set; }
        public decimal transporte { get; set; }
        public decimal otro1 { get; set; }
        public decimal otro2 { get; set; }
        public string MotivoAnulacion { get; set; }
        public string CodPedido { get; set; }
        public string Entregado { get; set; }
        public string IdEstadoProduccion { get; set; }
    
        public virtual fa_cliente fa_cliente { get; set; }
        public virtual ICollection<fa_pedido_det> fa_pedido_det { get; set; }
        public virtual fa_pedido_estadoAprobacion fa_pedido_estadoAprobacion { get; set; }
        public virtual fa_Vendedor fa_Vendedor { get; set; }
        public virtual ICollection<fa_pedido_x_formaPago> fa_pedido_x_formaPago { get; set; }
    }
}
