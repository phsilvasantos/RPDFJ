﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
   public class XCXP_Rpt011_Bus

       
    {
       XCXP_Rpt011_Data odata = new XCXP_Rpt011_Data();
       string mensaje = "";
       public List<XCXP_Rpt011_Info> consultar_data(int IdEmpresa, decimal IdProveedorIni, decimal IdProveedorFin, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
       {
           try
           {
               return odata.consultar_data(IdEmpresa, IdProveedorIni, IdProveedorFin, FechaIni, FechaFin, ref  mensaje);
           }
           catch (Exception ex)
           {
               
               return new List<XCXP_Rpt011_Info>();
           }
       
       }

    }
}
