//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Reportes
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwACTF_Rpt004
    {
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public string Af_Codigo_Barra { get; set; }
        public int IdTipoDepreciacion { get; set; }
        public string cod_tipo_depreciacion { get; set; }
        public string nom_tipo_depreciacion { get; set; }
        public string Af_Nombre { get; set; }
        public Nullable<int> IdDepartamento { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public System.DateTime Af_fecha_compra { get; set; }
        public double Af_costo_compra { get; set; }
        public string Estado_Proceso { get; set; }
        public decimal IdDepreciacion { get; set; }
        public int Secuencia { get; set; }
        public int Ciclo { get; set; }
        public double Valor_Compra { get; set; }
        public double Valor_Salvamento { get; set; }
        public int Vida_Util { get; set; }
        public double Valor_Depreciacion { get; set; }
        public double Valor_Depre_Acum { get; set; }
        public double Valor_Importe { get; set; }
        public int IdPeriodo { get; set; }
        public int IdanioFiscal { get; set; }
        public byte pe_mes { get; set; }
        public string smes { get; set; }
        public string Nemonico { get; set; }
    }
}
