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
    
    public partial class fa_cotizacion
    {
        public fa_cotizacion()
        {
            this.fa_cotizacion_det = new HashSet<fa_cotizacion_det>();
            this.fa_factura_x_fa_cotizacion = new HashSet<fa_factura_x_fa_cotizacion>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCotizacion { get; set; }
        public string CodCotizacion { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public System.DateTime cc_fecha { get; set; }
        public short cc_diasPlazo { get; set; }
        public System.DateTime cc_fechaVencimiento { get; set; }
        public string cc_observacion { get; set; }
        public string cc_tipopago { get; set; }
        public string cc_estado { get; set; }
        public string cc_dirigidoA { get; set; }
        public double cc_transporte { get; set; }
        public double cc_interes { get; set; }
        public double cc_otroValor1 { get; set; }
        public double cc_otroValor2 { get; set; }
        public string IdUsuario { get; set; }
        public System.DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
    
        public virtual fa_cliente fa_cliente { get; set; }
        public virtual ICollection<fa_cotizacion_det> fa_cotizacion_det { get; set; }
        public virtual fa_Vendedor fa_Vendedor { get; set; }
        public virtual ICollection<fa_factura_x_fa_cotizacion> fa_factura_x_fa_cotizacion { get; set; }
    }
}
