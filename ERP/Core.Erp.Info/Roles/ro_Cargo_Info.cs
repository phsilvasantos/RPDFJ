﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_Cargo_Info
    {
        public int  IdEmpresa { get; set; }
        public int IdCargo { get; set; }
        //public int IdDepartamento { get; set; }
        public string ca_descripcion { get; set; }
        public string IdUsuario { get; set; }
        public DateTime?  Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string MotivoAnulacion { get; set; }
        //public string DepDescripcion { get; set; }
        public Nullable<bool> considera_pago_utilidad { get; set; }


        public ro_Cargo_Info()  { }


    }
}
