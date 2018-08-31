﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario_CG
{
    public class in_categoria_CG_Info
    {
        public int IdEmpresa { get; set; }
        public string IdCategoria { get; set; }
        public Nullable<bool> sw_medicamento { get; set; }
        public Nullable<bool> sw_vende { get; set; }
        public Nullable<bool> sw_insumos { get; set; }
        public Nullable<bool> sw_formulacion { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public System.DateTime Fecha_Transac { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
    }
}
