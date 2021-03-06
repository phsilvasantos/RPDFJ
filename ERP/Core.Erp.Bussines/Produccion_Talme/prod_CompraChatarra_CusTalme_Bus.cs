﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.Produccion_Talme;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produccion_Talme
{
    public class prod_CompraChatarra_CusTalme_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prod_CompraChatarra_CusTalme_Data Data = new prod_CompraChatarra_CusTalme_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        public Boolean GuardarDB(prod_CompraChatarra_CusTalme_Info Info, ref decimal IdLiquidacion, ref string Mensaje)
        {
            try
            {
                Info.IdUsuario = param.IdUsuario;
                Info.IdUsuarioUltModi = param.IdUsuario;
                Info.Fecha_Transaccion = param.Fecha_Transac;
                Info.Fecha_UltMod = param.Fecha_Transac;
                Info.ip = param.ip;
                Info.nom_pc = param.nom_pc;
                return Data.GuardarDB(Info, ref IdLiquidacion, ref Mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prod_CompraChatarra_CusTalme_Bus) };

            }

        }


        public List<prod_CompraChatarra_CusTalme_Info> ConsultaGeneral(int IdEmpresa, DateTime fechaInicial, DateTime FechaFin)
        {
            try
            {
              return Data.Get_List_CompraChatarra_CusTalme(IdEmpresa, fechaInicial, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(prod_CompraChatarra_CusTalme_Bus) };

            }
        }


        public Boolean Anular(prod_CompraChatarra_CusTalme_Info Info, ref string Mensaje)
        {
            try
            {
                Info.Fecha_UltAnu = param.Fecha_Transac;
                Info.IdUsuario = param.IdUsuario;
                Info.ip = param.ip;
                Info.nom_pc = param.nom_pc;
                return Data.Anular(Info, ref Mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(prod_CompraChatarra_CusTalme_Bus) };

            }

        }
    }
}
