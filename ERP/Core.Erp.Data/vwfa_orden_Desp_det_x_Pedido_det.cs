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
    
    public partial class vwfa_orden_Desp_det_x_Pedido_det
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdOrdenDespacho { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double od_cantidad { get; set; }
        public double od_Precio { get; set; }
        public double od_PorDescUnitario { get; set; }
        public double od_DescUnitario { get; set; }
        public double od_PrecioFinal { get; set; }
        public double od_Subtotal { get; set; }
        public double od_iva { get; set; }
        public double od_total { get; set; }
        public double od_costo { get; set; }
        public string od_tieneIVA { get; set; }
        public string od_detallexItems { get; set; }
        public Nullable<int> pe_IdEmpresa { get; set; }
        public Nullable<int> pe_IdSucursal { get; set; }
        public Nullable<int> pe_IdBodega { get; set; }
        public Nullable<decimal> pe_IdPedido { get; set; }
        public Nullable<int> pe_Secuencia { get; set; }
        public double od_peso { get; set; }
        public string pr_descripcion { get; set; }
        public string Tiene_guia { get; set; }
    }
}
