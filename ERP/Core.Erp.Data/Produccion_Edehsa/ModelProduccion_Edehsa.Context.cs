﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Produccion_Edehsa
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntitiesProduccion_Edehsa : DbContext
    {
        public EntitiesProduccion_Edehsa()
            : base("name=EntitiesProduccion_Edehsa")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<vwprd_Obra> vwprd_Obra { get; set; }
        public DbSet<prd_motivo_traslado> prd_motivo_traslado { get; set; }
        public DbSet<vwprd_Guia_Remision_Electronica> vwprd_Guia_Remision_Electronica { get; set; }
    }
}
