//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class imp_ordencompra_ext_x_Condiciones_Pago
    {
        public int IdEmpresa { get; set; }
        public int IdSucusal { get; set; }
        public decimal IdOrdenCompraExt { get; set; }
        public int Secuencia { get; set; }
        public string IdCondicion_Pago { get; set; }
        public System.DateTime Fecha_Pago { get; set; }
        public string IdConfirmacion_Pago { get; set; }
        public double Por_Pago { get; set; }
        public double Valor_Pago { get; set; }
        public string Observacion { get; set; }
    
        public virtual imp_catalogo imp_catalogo { get; set; }
        public virtual imp_catalogo imp_catalogo1 { get; set; }
    }
}
