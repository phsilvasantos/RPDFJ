﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class EntitiesCuentasxPagar : DbContext
    {
        public EntitiesCuentasxPagar()
            : base("name=EntitiesCuentasxPagar")
        {
        }

        //poner esta funcion dentro de la clase entities no viene por defecto
        public void SetCommandTimeOut(int TimeOut)
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = TimeOut;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<cp_Aprobacion_Ing_Bod_x_OC_det> cp_Aprobacion_Ing_Bod_x_OC_det { get; set; }
        public DbSet<cp_Aprobacion_Orden_pago> cp_Aprobacion_Orden_pago { get; set; }
        public DbSet<cp_Aprobacion_Orden_pago_det> cp_Aprobacion_Orden_pago_det { get; set; }
        public DbSet<cp_Autorizacion_x_Doc_x_Pag> cp_Autorizacion_x_Doc_x_Pag { get; set; }
        public DbSet<cp_catalogo> cp_catalogo { get; set; }
        public DbSet<cp_catalogo_tipo> cp_catalogo_tipo { get; set; }
        public DbSet<cp_codigo_SRI> cp_codigo_SRI { get; set; }
        public DbSet<cp_codigo_SRI_tipo> cp_codigo_SRI_tipo { get; set; }
        public DbSet<cp_codigo_SRI_x_CtaCble> cp_codigo_SRI_x_CtaCble { get; set; }
        public DbSet<cp_conciliacion> cp_conciliacion { get; set; }
        public DbSet<cp_conciliacion_det> cp_conciliacion_det { get; set; }
        public DbSet<cp_Conciliacion_Ing_Bodega_x_Orden_Giro> cp_Conciliacion_Ing_Bodega_x_Orden_Giro { get; set; }
        public DbSet<cp_orden_giro_pagos_sri> cp_orden_giro_pagos_sri { get; set; }
        public DbSet<cp_orden_giro_x_com_ordencompra_local> cp_orden_giro_x_com_ordencompra_local { get; set; }
        public DbSet<cp_orden_giro_x_imp_ordencompra_ext> cp_orden_giro_x_imp_ordencompra_ext { get; set; }
        public DbSet<cp_orden_pago> cp_orden_pago { get; set; }
        public DbSet<cp_orden_pago_det> cp_orden_pago_det { get; set; }
        public DbSet<cp_orden_pago_estado_aprob> cp_orden_pago_estado_aprob { get; set; }
        public DbSet<cp_orden_pago_formapago> cp_orden_pago_formapago { get; set; }
        public DbSet<cp_orden_pago_tipo> cp_orden_pago_tipo { get; set; }
        public DbSet<cp_pagos_sri> cp_pagos_sri { get; set; }
        public DbSet<cp_pais_sri> cp_pais_sri { get; set; }
        public DbSet<cp_proveedor_clase> cp_proveedor_clase { get; set; }
        public DbSet<cp_proveedor_codigo_SRI> cp_proveedor_codigo_SRI { get; set; }
        public DbSet<cp_proveedor_contactos> cp_proveedor_contactos { get; set; }
        public DbSet<cp_reembolso> cp_reembolso { get; set; }
        public DbSet<cp_retencion_det> cp_retencion_det { get; set; }
        public DbSet<cp_retencion_x_ct_cbtecble> cp_retencion_x_ct_cbtecble { get; set; }
        public DbSet<cp_TipoDocumento> cp_TipoDocumento { get; set; }
        public DbSet<cp_trans_a_generar_x_FormaPago_OP> cp_trans_a_generar_x_FormaPago_OP { get; set; }
        public DbSet<vwcp_Anticipos_para_Conciliar> vwcp_Anticipos_para_Conciliar { get; set; }
        public DbSet<vwcp_Anticipos_x_NotaCred_Saldo> vwcp_Anticipos_x_NotaCred_Saldo { get; set; }
        public DbSet<vwcp_Cbte_x_pagar_OG> vwcp_Cbte_x_pagar_OG { get; set; }
        public DbSet<vwcp_cbtes_cxp_para_conciliar> vwcp_cbtes_cxp_para_conciliar { get; set; }
        public DbSet<vwcp_cbtes_cxp_para_conciliar_consulta> vwcp_cbtes_cxp_para_conciliar_consulta { get; set; }
        public DbSet<vwcp_codigo_SRI> vwcp_codigo_SRI { get; set; }
        public DbSet<vwcp_codigo_SRI_x_ctaCble> vwcp_codigo_SRI_x_ctaCble { get; set; }
        public DbSet<vwcp_comprobante_x_retencion> vwcp_comprobante_x_retencion { get; set; }
        public DbSet<vwcp_conciliacion_det_x_cbte_pago> vwcp_conciliacion_det_x_cbte_pago { get; set; }
        public DbSet<vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro> vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro { get; set; }
        public DbSet<vwcp_conciliacion_x_cbte_cble> vwcp_conciliacion_x_cbte_cble { get; set; }
        public DbSet<vwcp_conciliacion_x_orden_pago> vwcp_conciliacion_x_orden_pago { get; set; }
        public DbSet<vwcp_Orden_Giro_Conciliado_x_Factura> vwcp_Orden_Giro_Conciliado_x_Factura { get; set; }
        public DbSet<vwcp_Orden_Giro_Pendiente_Conciliar> vwcp_Orden_Giro_Pendiente_Conciliar { get; set; }
        public DbSet<vwcp_orden_giro_sin_retenciones> vwcp_orden_giro_sin_retenciones { get; set; }
        public DbSet<vwcp_orden_pago_Anticipo_Saldo> vwcp_orden_pago_Anticipo_Saldo { get; set; }
        public DbSet<vwcp_orden_pago_con_cancelacion_para_conciliacion> vwcp_orden_pago_con_cancelacion_para_conciliacion { get; set; }
        public DbSet<vwcp_orden_pago_con_cancelacion_x_CbteBan_Debi> vwcp_orden_pago_con_cancelacion_x_CbteBan_Debi { get; set; }
        public DbSet<vwcp_orden_pago_det> vwcp_orden_pago_det { get; set; }
        public DbSet<vwcp_orden_pago_det_activa> vwcp_orden_pago_det_activa { get; set; }
        public DbSet<vwcp_orden_pago_total> vwcp_orden_pago_total { get; set; }
        public DbSet<vwcp_orden_pago_Total_cancelacion> vwcp_orden_pago_Total_cancelacion { get; set; }
        public DbSet<vwcp_orden_pago_Total_Pagado> vwcp_orden_pago_Total_Pagado { get; set; }
        public DbSet<vwcp_OrdenGiroRetencionReport> vwcp_OrdenGiroRetencionReport { get; set; }
        public DbSet<vwcp_Retencion_sri> vwcp_Retencion_sri { get; set; }
        public DbSet<vwcp_Retencion_valor_total_x_cbte_cxp> vwcp_Retencion_valor_total_x_cbte_cxp { get; set; }
        public DbSet<vwcp_retencion_x_RET_FT> vwcp_retencion_x_RET_FT { get; set; }
        public DbSet<vwcp_retencion_x_RET_IVA> vwcp_retencion_x_RET_IVA { get; set; }
        public DbSet<vwcp_Retenciones_x_tipo_impresion> vwcp_Retenciones_x_tipo_impresion { get; set; }
        public DbSet<vwcp_Tipo_Impresion_Cheq> vwcp_Tipo_Impresion_Cheq { get; set; }
        public DbSet<vwcp_TipoServicioxProve> vwcp_TipoServicioxProve { get; set; }
        public DbSet<vwcp_Aprobacion_Ing_Bod_x_OC_det> vwcp_Aprobacion_Ing_Bod_x_OC_det { get; set; }
        public DbSet<cp_retencion> cp_retencion { get; set; }
        public DbSet<vwcp_Orden_Giro_Conciliado_x_Ing_Bod_x_OC> vwcp_Orden_Giro_Conciliado_x_Ing_Bod_x_OC { get; set; }
        public DbSet<vwcp_orden_giro_x_com_ordencompra_local_det_consulta> vwcp_orden_giro_x_com_ordencompra_local_det_consulta { get; set; }
        public DbSet<vwCP_Retencion_Valor_total> vwCP_Retencion_Valor_total { get; set; }
        public DbSet<vwcp_Conciliacion_Caja_det> vwcp_Conciliacion_Caja_det { get; set; }
        public DbSet<cp_conciliacion_Caja_det_Ing_Caja> cp_conciliacion_Caja_det_Ing_Caja { get; set; }
        public DbSet<vwcp_conciliacion_Caja_det_Ing_Caja> vwcp_conciliacion_Caja_det_Ing_Caja { get; set; }
        public DbSet<cp_proveedor_Autorizacion> cp_proveedor_Autorizacion { get; set; }
        public DbSet<cp_nota_DebCre> cp_nota_DebCre { get; set; }
        public DbSet<cp_Aprobacion_Ing_Bod_x_OC_det_Eliminados> cp_Aprobacion_Ing_Bod_x_OC_det_Eliminados { get; set; }
        public DbSet<cp_Aprobacion_Ing_Bod_x_OC_Eliminados> cp_Aprobacion_Ing_Bod_x_OC_Eliminados { get; set; }
        public DbSet<cp_orden_pago_cancelaciones> cp_orden_pago_cancelaciones { get; set; }
        public DbSet<cp_orden_giro_x_com_ordencompra_local_det> cp_orden_giro_x_com_ordencompra_local_det { get; set; }
        public DbSet<cp_conciliacion_Caja_det> cp_conciliacion_Caja_det { get; set; }
        public DbSet<vwcp_orden_pago_tipo_x_empresa> vwcp_orden_pago_tipo_x_empresa { get; set; }
        public DbSet<cp_orden_pago_tipo_x_empresa> cp_orden_pago_tipo_x_empresa { get; set; }
        public DbSet<vwcp_ba_Archivo_Transferencia_Det> vwcp_ba_Archivo_Transferencia_Det { get; set; }
        public DbSet<vwcp_orden_pago_det_con_cta_acreedora> vwcp_orden_pago_det_con_cta_acreedora { get; set; }
        public DbSet<vwcp_Aprobacion_Ing_Bod_x_OC> vwcp_Aprobacion_Ing_Bod_x_OC { get; set; }
        public DbSet<cp_proveedor> cp_proveedor { get; set; }
        public DbSet<vwcp_proveedor_vista_previa> vwcp_proveedor_vista_previa { get; set; }
        public DbSet<vwcp_ProveedorRuc> vwcp_ProveedorRuc { get; set; }
        public DbSet<vwcp_orden_pago_con_Transferencia> vwcp_orden_pago_con_Transferencia { get; set; }
        public DbSet<vwcp_orden_pago_con_cancelacion> vwcp_orden_pago_con_cancelacion { get; set; }
        public DbSet<vwcp_retencion> vwcp_retencion { get; set; }
        public DbSet<cp_Aprobacion_Ing_Bod_x_OC> cp_Aprobacion_Ing_Bod_x_OC { get; set; }
        public DbSet<vwcp_nota_DebCre_total_saldo> vwcp_nota_DebCre_total_saldo { get; set; }
        public DbSet<cp_conciliacion_Caja> cp_conciliacion_Caja { get; set; }
        public DbSet<vwcp_Conciliacion_Caja> vwcp_Conciliacion_Caja { get; set; }
        public DbSet<vwcp_nota_DebCre> vwcp_nota_DebCre { get; set; }
        public DbSet<vwcp_orden_pago> vwcp_orden_pago { get; set; }
        public DbSet<cp_conciliacion_Caja_det_x_ValeCaja> cp_conciliacion_Caja_det_x_ValeCaja { get; set; }
        public DbSet<vwcp_orden_pago_cancelacion_Saldos> vwcp_orden_pago_cancelacion_Saldos { get; set; }
        public DbSet<vwcp_conciliacion_Caja_det_x_ValeCaja> vwcp_conciliacion_Caja_det_x_ValeCaja { get; set; }
        public DbSet<vwcp_nota_DebCre_ATS> vwcp_nota_DebCre_ATS { get; set; }
        public DbSet<cp_parametros> cp_parametros { get; set; }
        public DbSet<vwcp_orden_giro_x_pagar> vwcp_orden_giro_x_pagar { get; set; }
        public DbSet<cp_orden_giro> cp_orden_giro { get; set; }
        public DbSet<vwcp_orden_giro_SRI> vwcp_orden_giro_SRI { get; set; }
        public DbSet<vwcp_orden_giro_total_saldo> vwcp_orden_giro_total_saldo { get; set; }
        public DbSet<vwcp_orden_giro_x_Pagos_saldo> vwcp_orden_giro_x_Pagos_saldo { get; set; }
        public DbSet<vwcp_orden_pago_para_aprobacion> vwcp_orden_pago_para_aprobacion { get; set; }
    
        public virtual ObjectResult<string> spCXP_eliminar_factura_vale_conciliacion_caja(Nullable<int> idEmpresa, Nullable<int> idTipoCbte, Nullable<decimal> idCbteCble, string tipoCbte_conci, Nullable<bool> borrar_o_desvincular)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idTipoCbteParameter = idTipoCbte.HasValue ?
                new ObjectParameter("IdTipoCbte", idTipoCbte) :
                new ObjectParameter("IdTipoCbte", typeof(int));
    
            var idCbteCbleParameter = idCbteCble.HasValue ?
                new ObjectParameter("IdCbteCble", idCbteCble) :
                new ObjectParameter("IdCbteCble", typeof(decimal));
    
            var tipoCbte_conciParameter = tipoCbte_conci != null ?
                new ObjectParameter("TipoCbte_conci", tipoCbte_conci) :
                new ObjectParameter("TipoCbte_conci", typeof(string));
    
            var borrar_o_desvincularParameter = borrar_o_desvincular.HasValue ?
                new ObjectParameter("Borrar_o_desvincular", borrar_o_desvincular) :
                new ObjectParameter("Borrar_o_desvincular", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("spCXP_eliminar_factura_vale_conciliacion_caja", idEmpresaParameter, idTipoCbteParameter, idCbteCbleParameter, tipoCbte_conciParameter, borrar_o_desvincularParameter);
        }
    
        public virtual ObjectResult<spcp_Get_Data_orden_pago_con_Transferencia_data_Result> spcp_Get_Data_orden_pago_con_Transferencia_data(Nullable<int> i_idempresa, Nullable<decimal> i_IdArchivo, Nullable<System.DateTime> i_fecha_ini, Nullable<System.DateTime> i_fecha_fin, string i_IdUsuario)
        {
            var i_idempresaParameter = i_idempresa.HasValue ?
                new ObjectParameter("i_idempresa", i_idempresa) :
                new ObjectParameter("i_idempresa", typeof(int));
    
            var i_IdArchivoParameter = i_IdArchivo.HasValue ?
                new ObjectParameter("i_IdArchivo", i_IdArchivo) :
                new ObjectParameter("i_IdArchivo", typeof(decimal));
    
            var i_fecha_iniParameter = i_fecha_ini.HasValue ?
                new ObjectParameter("i_fecha_ini", i_fecha_ini) :
                new ObjectParameter("i_fecha_ini", typeof(System.DateTime));
    
            var i_fecha_finParameter = i_fecha_fin.HasValue ?
                new ObjectParameter("i_fecha_fin", i_fecha_fin) :
                new ObjectParameter("i_fecha_fin", typeof(System.DateTime));
    
            var i_IdUsuarioParameter = i_IdUsuario != null ?
                new ObjectParameter("i_IdUsuario", i_IdUsuario) :
                new ObjectParameter("i_IdUsuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spcp_Get_Data_orden_pago_con_Transferencia_data_Result>("spcp_Get_Data_orden_pago_con_Transferencia_data", i_idempresaParameter, i_IdArchivoParameter, i_fecha_iniParameter, i_fecha_finParameter, i_IdUsuarioParameter);
        }
    }
}
