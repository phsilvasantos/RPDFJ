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
    
    public partial class vwfa_liquidacion_x_punto_cargo
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string IdCentroCosto { get; set; }
        public decimal IdLiquidacion { get; set; }
        public string Su_Descripcion { get; set; }
        public string nom_Centro_costo { get; set; }
        public int IdPunto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }
        public System.DateTime li_fecha { get; set; }
        public string IdTerminoPago { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string nom_Centro_costo_sub_centro_costo { get; set; }
        public string li_num_orden { get; set; }
        public string li_num_horas { get; set; }
        public string li_atencion_a { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public string li_tipo_pedido { get; set; }
        public bool estado { get; set; }
        public Nullable<decimal> lo_IdProducto { get; set; }
        public string li_reporte_mantenimiento { get; set; }
        public Nullable<decimal> in_IdProducto { get; set; }
        public Nullable<decimal> eg_IdProducto { get; set; }
        public double li_por_iva { get; set; }
        public double li_subtotal { get; set; }
        public double li_valor_iva { get; set; }
        public double li_total { get; set; }
        public string IdCod_Impuesto { get; set; }
        public string li_observacion { get; set; }
        public int numero_lineas { get; set; }
        public decimal IdCliente_cli { get; set; }
        public string cod_liquidacion { get; set; }
        public Nullable<System.DateTime> li_fecha_orden_mantenimiento { get; set; }
        public Nullable<System.DateTime> li_fecha_reporte_mantenimiento { get; set; }
        public string li_referencia_facturas { get; set; }
    }
}
