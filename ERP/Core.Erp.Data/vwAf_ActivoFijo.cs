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
    
    public partial class vwAf_ActivoFijo
    {
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public int IdTipoDepreciacion { get; set; }
        public string cod_tipo_depreciacion { get; set; }
        public string Af_Nombre { get; set; }
        public double Af_costo_compra { get; set; }
        public double Af_ValorSalvamento { get; set; }
        public int Af_Vida_Util { get; set; }
        public Nullable<int> Af_Vida_TipDepre { get; set; }
        public Nullable<System.DateTime> Af_fecha_ini_depre { get; set; }
        public Nullable<System.DateTime> Af_fecha_fin_depre { get; set; }
        public Nullable<int> Af_Meses_depreciar { get; set; }
        public int Ciclo { get; set; }
        public double Af_porcentaje_deprec { get; set; }
        public Nullable<double> Valor_Depre { get; set; }
        public Nullable<double> Valor_Depreciacion_Acum { get; set; }
        public Nullable<double> Valor_Importe { get; set; }
        public string Estado_Proceso { get; set; }
        public int Es_Activo_x_Mejora { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
    }
}