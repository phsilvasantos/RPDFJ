﻿using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario_CG;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Inventario_CG
{
    public class inv_med_cod_forma_farmacologica_Data
    {
        public List<inv_med_cod_forma_farmacologica_Info> Get_List_forma_farmacologica(NpgsqlConnection cc, ref string mensaje)
        {
            try
            {

                List<inv_med_cod_forma_farmacologica_Info> lista_ = new List<inv_med_cod_forma_farmacologica_Info>();
                string sql = string.Empty;
                sql = "SELECT cod_forma_farmacologica, descripcion, unidad_dosificacion FROM inv_med_cod_forma_farmacologica";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cc);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0) == false)
                    {
                        inv_med_cod_forma_farmacologica_Info info = new inv_med_cod_forma_farmacologica_Info();
                        if (!reader.IsDBNull(0))
                        info.cod_forma_farmacologica = reader.GetString(0);
                        if (!reader.IsDBNull(1))
                        info.descripcion = reader.GetString(1);
                        if (!reader.IsDBNull(2))
                        info.unidad_dosificacion = reader.GetString(2);
                        lista_.Add(info);
                    }

                }
                reader.Close();
                cc.Close();
                return lista_;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
