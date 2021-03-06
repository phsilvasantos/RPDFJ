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
    
    public partial class vwin_GeneracionCompraCidersus
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public decimal IdProveedor { get; set; }
        public string oc_NumDocumento { get; set; }
        public string Tipo { get; set; }
        public string IdTerminoPago { get; set; }
        public int oc_plazo { get; set; }
        public System.DateTime oc_fecha { get; set; }
        public double oc_flete { get; set; }
        public string oc_observacion { get; set; }
        public string Estado { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public Nullable<System.DateTime> co_fecha_aprobacion { get; set; }
        public string IdUsuario_Aprueba { get; set; }
        public string IdUsuario_Reprue { get; set; }
        public Nullable<System.DateTime> co_fechaReproba { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> FechaHoraAnul { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string EstadoRecepcion { get; set; }
        public string AfectaCosto { get; set; }
        public string MotivoAnulacion { get; set; }
        public string MotivoReprobacion { get; set; }
        public string Solicitante { get; set; }
        public Nullable<decimal> IdPersona_Sol { get; set; }
        public Nullable<decimal> IdDepartamento { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<int> IdMotivo { get; set; }
        public Nullable<System.DateTime> oc_fechaVencimiento { get; set; }
        public string IdEstado_cierre { get; set; }
        public decimal IdComprador { get; set; }
        public string IdUnidadMedida { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string IdCentroCosto { get; set; }
        public string do_observacion { get; set; }
        public double do_peso { get; set; }
        public string do_Costeado { get; set; }
        public bool do_ManejaIva { get; set; }
        public double do_total { get; set; }
        public double do_iva { get; set; }
        public double do_subtotal { get; set; }
        public double do_descuento { get; set; }
        public double do_porc_des { get; set; }
        public double do_precioCompra { get; set; }
        public double do_Cantidad { get; set; }
        public decimal IdProducto { get; set; }
        public int Secuencia { get; set; }
        public string pr_descripcion { get; set; }
        public string pr_observacion { get; set; }
        public string Expr1 { get; set; }
        public double pr_precio_publico { get; set; }
        public Nullable<int> IdCtaCble_Vta { get; set; }
        public Nullable<int> IdCtaCble_CosBaseIva { get; set; }
        public Nullable<int> IdCtaCble_CosBase0 { get; set; }
        public Nullable<int> IdCtaCble_VenIva { get; set; }
        public Nullable<int> IdCtaCble_Ven0 { get; set; }
        public Nullable<int> IdCtaCble_DesIva { get; set; }
        public Nullable<int> IdCtaCble_Des0 { get; set; }
        public Nullable<int> IdCtaCble_DevIva { get; set; }
        public Nullable<int> IdCtaCble_Dev0 { get; set; }
        public double pr_stock_minimo { get; set; }
    }
}
