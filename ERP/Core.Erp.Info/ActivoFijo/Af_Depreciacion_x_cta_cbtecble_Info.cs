﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.ActivoFijo
{
    public class Af_Depreciacion_x_cta_cbtecble_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDepreciacion { get; set; }
        public int IdTipoDepreciacion { get; set; }
        public int ct_IdEmpresa { get; set; }
        public int ct_IdTipoCbte { get; set; }
        public decimal ct_IdCbteCble { get; set; }


        public Af_Depreciacion_x_cta_cbtecble_Info()
        {

        }
    }
}
