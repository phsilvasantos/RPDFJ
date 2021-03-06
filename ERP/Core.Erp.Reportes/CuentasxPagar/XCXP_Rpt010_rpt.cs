﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;


namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt010_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_Rpt010_rpt()
        {
            InitializeComponent();
        }

        private void XCXP_Rpt010_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lbl_Fecha_impresion.Text = DateTime.Now.ToLongDateString();
                XCXP_Rpt010_Bus repbus = new XCXP_Rpt010_Bus();
                List<XCXP_Rpt010_Info> ListDataRpt = new List<XCXP_Rpt010_Info>();

                string mensaje = "";
                int IdEmpresa = 0;
                decimal IdProveedorIni=0;
                decimal IdProveedorFin=0;
                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdProveedorIni = Convert.ToDecimal(Parameters["IdProveedorIni"].Value);
                IdProveedorFin = Convert.ToDecimal(Parameters["IdProveedorFin"].Value);
                FechaIni = Convert.ToDateTime(Parameters["FechaIni"].Value);
                FechaFin = Convert.ToDateTime(Parameters["FechaFin"].Value);
                
                
                ListDataRpt = repbus.consultar_data(IdEmpresa, IdProveedorIni, IdProveedorFin, FechaIni, FechaFin, ref mensaje);
                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt010_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt010_rpt) };
            }

        }

    }
}
