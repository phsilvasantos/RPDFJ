//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Compras
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega_consul
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public System.DateTime oc_fecha { get; set; }
        public string oc_observacion { get; set; }
        public string IdEstadoAprobacion_cat { get; set; }
        public string Estado { get; set; }
        public decimal IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public decimal IdProducto { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public double do_Cantidad { get; set; }
        public double do_precioCompra { get; set; }
        public double do_subtotal { get; set; }
        public string Su_Descripcion { get; set; }
        public string oc_NumDocumento { get; set; }
        public int Secuencia { get; set; }
        public Nullable<double> Cantidad_enviar { get; set; }
        public string observacion_det_gui { get; set; }
        public decimal IdGuia { get; set; }
        public Nullable<System.DateTime> oc_fechaVencimiento { get; set; }
    }
}
