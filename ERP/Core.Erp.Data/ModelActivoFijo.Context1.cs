﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class EntitiesActivoFijo : DbContext
    {
        public EntitiesActivoFijo()
            : base("name=EntitiesActivoFijo")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Af_Activo_fijo_Categoria> Af_Activo_fijo_Categoria { get; set; }
        public DbSet<Af_Activo_fijo_CtasCbles_Tipo> Af_Activo_fijo_CtasCbles_Tipo { get; set; }
        public DbSet<Af_Activo_fijo_x_Af_Activo_fijo> Af_Activo_fijo_x_Af_Activo_fijo { get; set; }
        public DbSet<Af_CambioUbicacion_Activo> Af_CambioUbicacion_Activo { get; set; }
        public DbSet<Af_Catalogo> Af_Catalogo { get; set; }
        public DbSet<Af_CatalogoTipo> Af_CatalogoTipo { get; set; }
        public DbSet<Af_Departamento> Af_Departamento { get; set; }
        public DbSet<Af_Depreciacion> Af_Depreciacion { get; set; }
        public DbSet<Af_Depreciacion_Det_His_Anulacion> Af_Depreciacion_Det_His_Anulacion { get; set; }
        public DbSet<Af_Depreciacion_His_Anulacion> Af_Depreciacion_His_Anulacion { get; set; }
        public DbSet<Af_Depreciacion_x_cta_cbtecble> Af_Depreciacion_x_cta_cbtecble { get; set; }
        public DbSet<Af_Encargado> Af_Encargado { get; set; }
        public DbSet<Af_Mej_Baj_Activo> Af_Mej_Baj_Activo { get; set; }
        public DbSet<Af_Parametros> Af_Parametros { get; set; }
        public DbSet<Af_PeriodoDepreciacion> Af_PeriodoDepreciacion { get; set; }
        public DbSet<Af_Retiro_Activo> Af_Retiro_Activo { get; set; }
        public DbSet<Af_Tipo_Depreciacion> Af_Tipo_Depreciacion { get; set; }
        public DbSet<Af_TipoTransac_x_Cta_CbteCble> Af_TipoTransac_x_Cta_CbteCble { get; set; }
        public DbSet<Af_Venta_Activo> Af_Venta_Activo { get; set; }
        public DbSet<vwAf_CambioUbicacion> vwAf_CambioUbicacion { get; set; }
        public DbSet<vwAf_Catalogo_IdAuto_numeric> vwAf_Catalogo_IdAuto_numeric { get; set; }
        public DbSet<vwAf_Depre_x_Ciclo_Valor> vwAf_Depre_x_Ciclo_Valor { get; set; }
        public DbSet<vwAf_Depreciacion> vwAf_Depreciacion { get; set; }
        public DbSet<vwAf_Mej_Baj_Activo> vwAf_Mej_Baj_Activo { get; set; }
        public DbSet<vwAF_OrdenCompra_x_Proveedor_Factura_ActivoFijo> vwAF_OrdenCompra_x_Proveedor_Factura_ActivoFijo { get; set; }
        public DbSet<vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo> vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo { get; set; }
        public DbSet<vwaf_Periodo_Sin_Depreciar> vwaf_Periodo_Sin_Depreciar { get; set; }
        public DbSet<vwAf_Retiro_Activo> vwAf_Retiro_Activo { get; set; }
        public DbSet<vwAf_Venta_Activo> vwAf_Venta_Activo { get; set; }
        public DbSet<Af_Activo_fijo_CtasCbles> Af_Activo_fijo_CtasCbles { get; set; }
        public DbSet<vwAf_Activo_fijo_Categoria> vwAf_Activo_fijo_Categoria { get; set; }
        public DbSet<vwAf_Valores_Depre_Contabilizar> vwAf_Valores_Depre_Contabilizar { get; set; }
        public DbSet<vwAf_ValoresDepre_x_AF> vwAf_ValoresDepre_x_AF { get; set; }
        public DbSet<Af_Activo_fijo> Af_Activo_fijo { get; set; }
        public DbSet<vwAf_Depreciacion_Detalle> vwAf_Depreciacion_Detalle { get; set; }
        public DbSet<Af_Activo_fijo_tipo> Af_Activo_fijo_tipo { get; set; }
        public DbSet<Af_Depreciacion_Det> Af_Depreciacion_Det { get; set; }
        public DbSet<vwAf_Activo_fijo_CtasCbles> vwAf_Activo_fijo_CtasCbles { get; set; }
        public DbSet<Af_ruta> Af_ruta { get; set; }
        public DbSet<vwAf_ActivoFijo> vwAf_ActivoFijo { get; set; }
        public DbSet<vwAf_Activo_fijo> vwAf_Activo_fijo { get; set; }
        public DbSet<vwAf_ActivoCtasCbles> vwAf_ActivoCtasCbles { get; set; }
    
        public virtual ObjectResult<spACTF_activos_a_depreciar_Result> spACTF_activos_a_depreciar(Nullable<int> idEmpresa, Nullable<System.DateTime> fecha_ini, Nullable<System.DateTime> fecha_fin, string idUsuario)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var fecha_iniParameter = fecha_ini.HasValue ?
                new ObjectParameter("Fecha_ini", fecha_ini) :
                new ObjectParameter("Fecha_ini", typeof(System.DateTime));
    
            var fecha_finParameter = fecha_fin.HasValue ?
                new ObjectParameter("Fecha_fin", fecha_fin) :
                new ObjectParameter("Fecha_fin", typeof(System.DateTime));
    
            var idUsuarioParameter = idUsuario != null ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spACTF_activos_a_depreciar_Result>("spACTF_activos_a_depreciar", idEmpresaParameter, fecha_iniParameter, fecha_finParameter, idUsuarioParameter);
        }
    }
}
