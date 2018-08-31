﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cus.Erp.Reports.CAH
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class Entities_Inventario_CAH : DbContext
    {
        public Entities_Inventario_CAH()
            : base("name=Entities_Inventario_CAH")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<spINV_CAH_Rpt001_Result> spINV_CAH_Rpt001(Nullable<int> idEmpresa, Nullable<int> idSucursal_ini, Nullable<int> idSucursal_fin, Nullable<int> idBodega_ini, Nullable<int> idBodega_fin, Nullable<System.DateTime> fecha_corte)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idSucursal_iniParameter = idSucursal_ini.HasValue ?
                new ObjectParameter("IdSucursal_ini", idSucursal_ini) :
                new ObjectParameter("IdSucursal_ini", typeof(int));
    
            var idSucursal_finParameter = idSucursal_fin.HasValue ?
                new ObjectParameter("IdSucursal_fin", idSucursal_fin) :
                new ObjectParameter("IdSucursal_fin", typeof(int));
    
            var idBodega_iniParameter = idBodega_ini.HasValue ?
                new ObjectParameter("IdBodega_ini", idBodega_ini) :
                new ObjectParameter("IdBodega_ini", typeof(int));
    
            var idBodega_finParameter = idBodega_fin.HasValue ?
                new ObjectParameter("IdBodega_fin", idBodega_fin) :
                new ObjectParameter("IdBodega_fin", typeof(int));
    
            var fecha_corteParameter = fecha_corte.HasValue ?
                new ObjectParameter("fecha_corte", fecha_corte) :
                new ObjectParameter("fecha_corte", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spINV_CAH_Rpt001_Result>("spINV_CAH_Rpt001", idEmpresaParameter, idSucursal_iniParameter, idSucursal_finParameter, idBodega_iniParameter, idBodega_finParameter, fecha_corteParameter);
        }
    }
}
