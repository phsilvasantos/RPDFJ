﻿using Core.Erp.Business.General;
using Core.Erp.Data.Inventario_CG;
using Core.Erp.Info.Inventario_CG;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Inventario_CG
{
    public class inv_med_cod_forma_farmacologica_Bus
    {
        tb_conexion_Postgres_Bus conex_post_bus = new tb_conexion_Postgres_Bus();
        inv_med_cod_forma_farmacologica_Data da = new inv_med_cod_forma_farmacologica_Data();


        public List<inv_med_cod_forma_farmacologica_Info> Get_List_forma_farmacologica(ref string mensaje)
        {
            List<inv_med_cod_forma_farmacologica_Info> lst = new List<inv_med_cod_forma_farmacologica_Info>();
            try
            {
                NpgsqlConnection cc = new NpgsqlConnection();
                string conex_postgres = string.Empty;
                cc = conex_post_bus.Conexion_Postgres(ref mensaje);
                if (conex_postgres != null && mensaje == "")
                    lst = da.Get_List_forma_farmacologica(cc, ref mensaje);

                return lst;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_forma_farmacologica", ex.Message), ex) { EntityType = typeof(inv_med_cod_forma_farmacologica_Bus) };
            }

        }
    }
}
