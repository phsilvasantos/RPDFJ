﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Compras_Edehsa
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntitiesCompras_Edehsa : DbContext
    {
        public EntitiesCompras_Edehsa()
            : base("name=EntitiesCompras_Edehsa")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<com_Registro_OrdenCompra_x_Cotizacion> com_Registro_OrdenCompra_x_Cotizacion { get; set; }
        public DbSet<com_ListadoDisenoTipo> com_ListadoDisenoTipo { get; set; }
        public DbSet<com_ListadoDiseno> com_ListadoDiseno { get; set; }
        public DbSet<com_ListadoDiseno_Det> com_ListadoDiseno_Det { get; set; }
        public DbSet<vwcom_ListadoDiseno_Detalle> vwcom_ListadoDiseno_Detalle { get; set; }
        public DbSet<vwcom_ListadoDiseno> vwcom_ListadoDiseno { get; set; }
        public DbSet<vwcom_ListadoMateriales_x_OC_x_Obra_x_OT> vwcom_ListadoMateriales_x_OC_x_Obra_x_OT { get; set; }
        public DbSet<vwcom_OC_local_det_x_MoviInven_SaldoItem_x_Obra_x_OT> vwcom_OC_local_det_x_MoviInven_SaldoItem_x_Obra_x_OT { get; set; }
        public DbSet<com_ListadoElementos_x_OT> com_ListadoElementos_x_OT { get; set; }
        public DbSet<com_ListadoElementos_x_OT_Det> com_ListadoElementos_x_OT_Det { get; set; }
        public DbSet<vwcom_ListadoElementos_x_OT> vwcom_ListadoElementos_x_OT { get; set; }
        public DbSet<vwcom_ListadoElementos_x_OT_Detalle> vwcom_ListadoElementos_x_OT_Detalle { get; set; }
        public DbSet<vwcom_AllListDetElementos_x_OT> vwcom_AllListDetElementos_x_OT { get; set; }
        public DbSet<vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Detalle> vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Detalle { get; set; }
        public DbSet<vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra> vwcom_ListadoMaterialesDisponibles_PreAsignado_a_Obra { get; set; }
        public DbSet<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det> com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det { get; set; }
        public DbSet<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra> com_ListadoMaterialesDisponibles_PreAsignado_a_Obra { get; set; }
        public DbSet<vwcom_AllListDetMaterialesDisponibles_PreAsignado_a_Obra> vwcom_AllListDetMaterialesDisponibles_PreAsignado_a_Obra { get; set; }
        public DbSet<vwcom_AllListDetMateriales_PreAsignado_a_Obra> vwcom_AllListDetMateriales_PreAsignado_a_Obra { get; set; }
        public DbSet<vwcom_ListadoMaterialesDisponibles> vwcom_ListadoMaterialesDisponibles { get; set; }
    }
}