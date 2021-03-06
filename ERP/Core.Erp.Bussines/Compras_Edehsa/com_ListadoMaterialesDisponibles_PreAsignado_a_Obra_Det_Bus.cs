﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Data.Compras_Edehsa;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Compras_Edehsa
{
    public class com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Data Data = new com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Data();
        public Boolean GuardarDB(List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> LstInfo, string IdEstado)
        {
            try
            {
                return Data.GuardarDB(LstInfo, IdEstado);
            
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus) };
            }
        }

        public List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det(int IdEmpresa, string CodObra)
        {
            try
            {
                return Data.Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det(IdEmpresa, CodObra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det", ex.Message), ex) { EntityType = typeof(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus) };
            }
        }
        public List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Get_List_All_DespuntesMP_Preasignado(int IdEmpresa)
        {
            try
            {
                return Data.Get_List_All_DespuntesMP_Preasignado(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det", ex.Message), ex) { EntityType = typeof(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus) };
            }
        }

        public List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Get_List_All_MP_Disponibles(int IdEmpresa)
        {
            try
            {
                return Data.Get_List_All_MP_Disponibles(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det", ex.Message), ex) { EntityType = typeof(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus) };
            }
        }

        //public Boolean EliminarDB(List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> LstInfo, ref string msg)
        //{
        //    try
        //    {
        //        return Data.EliminarDB(LstInfo, ref  msg);
        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus) };
        //    }
        //}

        //public Boolean ActualizarEstadoAprob(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info Info, ref string msg)
        //{
        //    try
        //    {
        //        return Data.ActualizarEstadoAprob(Info, ref  msg);
        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarEstadoAprob", ex.Message), ex) { EntityType = typeof(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus) };
        //    }
        //}

        public List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> TraerMP_Preasignado_a_Obra(int IdEmpresa)
        {
            try
            {
                return Data.TraerMP_Preasignado_a_Obra(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TraerTodoDetalleLstMat", ex.Message), ex) { EntityType = typeof(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus) };
            }
        }
        public List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> TraerTodoMP_Preasignado_a_Obra(int IdEmpresa)
        {
            try
            {
                return Data.TraerTodoMP_Preasignado_a_Obra(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TraerTodoDetalleLstMat", ex.Message), ex) { EntityType = typeof(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus) };
            }
        }
        //public com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det(int IdEmpresa, decimal idlistadoMat, int IdDetalle)
        //{
        //    try
        //    {
        //        return Data.Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det(IdEmpresa, idlistadoMat, IdDetalle);
        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det", ex.Message), ex) { EntityType = typeof(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus) };
        //    }
        //}

        //public List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det(int IdEmpresa, string CodObra)
        //{
        //    try
        //    {
        //        return Data.Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det(IdEmpresa, CodObra);
        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det", ex.Message), ex) { EntityType = typeof(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus) };
        //    }
        //}
        //public List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info> Get_List_ListadoDespunteMaterialesDisponibles_PreAsignado_a_Obra_Det(int IdEmpresa, string CodObra)
        //{
        //    try
        //    {
        //        return Data.Get_List_ListadoDespunteMaterialesDisponibles_PreAsignado_a_Obra_Det(IdEmpresa, CodObra);
        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoDespunteMaterialesDisponibles_PreAsignado_a_Obra_Det", ex.Message), ex) { EntityType = typeof(com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Bus) };
        //    }
        //}
    }
}
