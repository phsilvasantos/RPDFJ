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
    
    public partial class vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven
    {
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public Nullable<decimal> IdOrdenCompra { get; set; }
        public Nullable<int> secuencia_oc_det { get; set; }
        public string nom_sucu { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public string Tipo { get; set; }
        public Nullable<System.DateTime> oc_fecha { get; set; }
        public string oc_observacion { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public Nullable<double> oc_precio { get; set; }
        public Nullable<int> secuencia_inv_det { get; set; }
        public Nullable<double> cantidad_pedida_OC { get; set; }
        public double pr_stock { get; set; }
        public string Estado { get; set; }
        public string IdEstadoAprobacion_cat { get; set; }
        public string IdEstadoRecepcion { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string Nom_Motivo { get; set; }
        public Nullable<int> Referencia { get; set; }
        public Nullable<int> IdMotivo_oc { get; set; }
        public Nullable<System.DateTime> Fecha_ing_bod { get; set; }
        public string Observacion { get; set; }
        public Nullable<double> cantidad_ing_a_Inven { get; set; }
        public Nullable<double> cantidad_ingresada { get; set; }
        public string IdEstado_cierre { get; set; }
        public string nom_estado_cierre { get; set; }
        public string Nomsub_centro_costo { get; set; }
        public Nullable<double> do_descuento { get; set; }
        public Nullable<double> do_precioFinal { get; set; }
        public Nullable<double> do_subtotal { get; set; }
        public Nullable<double> do_iva { get; set; }
        public Nullable<double> do_total { get; set; }
        public string IdUnidadMedida_Consumo { get; set; }
        public string Descripcion { get; set; }
        public string IdUnidadMedida { get; set; }
        public string oc_NumDocumento { get; set; }
    }
}
