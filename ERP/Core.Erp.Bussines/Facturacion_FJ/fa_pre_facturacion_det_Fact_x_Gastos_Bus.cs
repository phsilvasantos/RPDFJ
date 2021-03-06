﻿using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Info.Facturacion_FJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion_FJ
{
    public class fa_pre_facturacion_det_Fact_x_Gastos_Bus
    {
        fa_pre_facturacion_det_Fact_x_Gastos_Data oData = new fa_pre_facturacion_det_Fact_x_Gastos_Data();

        public List<fa_pre_facturacion_det_Fact_x_Gastos_Info> Get_List(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                return oData.Get_List(IdEmpresa, IdPrefacturacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List", ex.Message), ex) { EntityType = typeof(fa_pre_facturacion_det_Fact_x_Gastos_Bus) };
            }
        }

        public List<fa_pre_facturacion_det_Fact_x_Gastos_Info> Get_List(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin, string IdCentroCosto)
        {
            try
            {
                return oData.Get_List(IdEmpresa, Fecha_ini, Fecha_fin, IdCentroCosto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List", ex.Message), ex) { EntityType = typeof(fa_pre_facturacion_det_Fact_x_Gastos_Bus) };
            }
        }

        public Boolean EliminarDB(fa_pre_facturacion_Info info)
        {
            try
            {
                return oData.EliminarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(fa_pre_facturacion_det_Fact_x_Gastos_Bus) };
            }
        }

        public Boolean GuardarDB(List<fa_pre_facturacion_det_Fact_x_Gastos_Info> Lista)
        {
            try
            {
                return oData.GuardarDB(Lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_pre_facturacion_det_Fact_x_Gastos_Bus) };
            }
        }
    }
}
