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
    
    public partial class vwACTF_Rpt012
    {
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<decimal> IdDepreciacion { get; set; }
        public Nullable<int> IdPeriodo { get; set; }
        public string nom_activo { get; set; }
        public string nom_tipo_depreciacion { get; set; }
        public double Af_costo_compra { get; set; }
        public double Valor_Depre_Acum { get; set; }
        public Nullable<double> Dep_Actual { get; set; }
        public Nullable<double> Porc_Depreciacion { get; set; }
        public Nullable<double> Valor_dep_Ant { get; set; }
        public string Estado { get; set; }
        public int IdActijoFijoTipo { get; set; }
        public string nom_ActijoFijoTipo { get; set; }
        public int IdCategoriaAF { get; set; }
        public string nom_CategoriaAF { get; set; }
        public System.DateTime Af_fecha_compra { get; set; }
        public string Estado_Proceso_Act { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public Nullable<int> IdDepartamento { get; set; }
        public string nom_departamento { get; set; }
        public string CodActivoFijo { get; set; }
    }
}
