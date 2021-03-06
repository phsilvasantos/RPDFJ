﻿namespace Core.Erp.Winform.Inventario_Cidersus
{
    partial class frmIn_AjustesInven_Cosulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIn_AjustesInven_Cosulta));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cmbTipoMoviInven = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.inmoviinveInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvAjustes_Cabecera = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodMoviInven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodNomTipoMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdAjustes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReferenciaOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodMoviInven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinveInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAjustes_Cabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(902, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cmbTipoMoviInven
            // 
            this.cmbTipoMoviInven.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMoviInven.FormattingEnabled = true;
            this.cmbTipoMoviInven.Location = new System.Drawing.Point(99, 7);
            this.cmbTipoMoviInven.Name = "cmbTipoMoviInven";
            this.cmbTipoMoviInven.Size = new System.Drawing.Size(378, 21);
            this.cmbTipoMoviInven.TabIndex = 11;
            this.cmbTipoMoviInven.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMoviInven_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo Movimiento:";
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.inmoviinveInfoBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 35);
            this.gridControl.MainView = this.gvAjustes_Cabecera;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(902, 268);
            this.gridControl.TabIndex = 12;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAjustes_Cabecera});
            this.gridControl.Click += new System.EventHandler(this.gridControl_Click);
            // 
            // gvAjustes_Cabecera
            // 
            this.gvAjustes_Cabecera.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sucursal,
            this.Bodega,
            this.CodMoviInven,
            this.CodNomTipoMovi,
            this.IdAjustes,
            this.Fecha,
            this.Tipo,
            this.Estado,
            this.ReferenciaOC,
            this.colCodMoviInven});
            this.gvAjustes_Cabecera.GridControl = this.gridControl;
            this.gvAjustes_Cabecera.Name = "gvAjustes_Cabecera";
            this.gvAjustes_Cabecera.OptionsBehavior.Editable = false;
            this.gvAjustes_Cabecera.OptionsFind.AlwaysVisible = true;
            this.gvAjustes_Cabecera.OptionsView.ShowAutoFilterRow = true;
            this.gvAjustes_Cabecera.OptionsView.ShowViewCaption = true;
            this.gvAjustes_Cabecera.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Fecha, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.IdAjustes, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvAjustes_Cabecera.ViewCaption = "Listado de Ajustes de Inventario";
            this.gvAjustes_Cabecera.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvAjustes_Cabecera_RowCellStyle);
            // 
            // Sucursal
            // 
            this.Sucursal.Caption = "Sucursal";
            this.Sucursal.FieldName = "NomSucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Visible = true;
            this.Sucursal.VisibleIndex = 0;
            this.Sucursal.Width = 90;
            // 
            // Bodega
            // 
            this.Bodega.Caption = "Bodega";
            this.Bodega.FieldName = "NomBodega";
            this.Bodega.Name = "Bodega";
            this.Bodega.OptionsColumn.AllowEdit = false;
            this.Bodega.Visible = true;
            this.Bodega.VisibleIndex = 1;
            this.Bodega.Width = 99;
            // 
            // CodMoviInven
            // 
            this.CodMoviInven.Caption = "Cod Tipo Ajuste";
            this.CodMoviInven.FieldName = "CodTipoMovi";
            this.CodMoviInven.Name = "CodMoviInven";
            this.CodMoviInven.Visible = true;
            this.CodMoviInven.VisibleIndex = 4;
            this.CodMoviInven.Width = 148;
            // 
            // CodNomTipoMovi
            // 
            this.CodNomTipoMovi.Caption = "Tipo Ajuste";
            this.CodNomTipoMovi.FieldName = "CodNomTipoMovi";
            this.CodNomTipoMovi.Name = "CodNomTipoMovi";
            this.CodNomTipoMovi.OptionsColumn.AllowEdit = false;
            this.CodNomTipoMovi.Visible = true;
            this.CodNomTipoMovi.VisibleIndex = 5;
            this.CodNomTipoMovi.Width = 185;
            // 
            // IdAjustes
            // 
            this.IdAjustes.Caption = "Ajuste No.";
            this.IdAjustes.FieldName = "IdNumMovi";
            this.IdAjustes.Name = "IdAjustes";
            this.IdAjustes.OptionsColumn.AllowEdit = false;
            this.IdAjustes.Visible = true;
            this.IdAjustes.VisibleIndex = 3;
            this.IdAjustes.Width = 82;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.DisplayFormat.FormatString = "d";
            this.Fecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Fecha.FieldName = "cm_fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.OptionsColumn.AllowEdit = false;
            this.Fecha.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 2;
            this.Fecha.Width = 65;
            // 
            // Tipo
            // 
            this.Tipo.Caption = "Tipo";
            this.Tipo.FieldName = "cm_tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.OptionsColumn.AllowEdit = false;
            this.Tipo.Width = 103;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.OptionsColumn.AllowEdit = false;
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 7;
            this.Estado.Width = 66;
            // 
            // ReferenciaOC
            // 
            this.ReferenciaOC.AppearanceCell.Options.UseTextOptions = true;
            this.ReferenciaOC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ReferenciaOC.AppearanceHeader.Options.UseTextOptions = true;
            this.ReferenciaOC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReferenciaOC.Caption = "Detalle";
            this.ReferenciaOC.FieldName = "ReferenciaOC";
            this.ReferenciaOC.Name = "ReferenciaOC";
            this.ReferenciaOC.OptionsColumn.AllowEdit = false;
            this.ReferenciaOC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ReferenciaOC.Visible = true;
            this.ReferenciaOC.VisibleIndex = 6;
            this.ReferenciaOC.Width = 171;
            // 
            // colCodMoviInven
            // 
            this.colCodMoviInven.Caption = "Código";
            this.colCodMoviInven.FieldName = "CodMoviInven";
            this.colCodMoviInven.Name = "colCodMoviInven";
            this.colCodMoviInven.Visible = true;
            this.colCodMoviInven.VisibleIndex = 8;
            this.colCodMoviInven.Width = 87;
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.printableComponentLink1});
            // 
            // printableComponentLink1
            // 
            // 
            // 
            // 
            this.printableComponentLink1.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink1.ImageCollection.ImageStream")));
            this.printableComponentLink1.Owner = null;
            this.printableComponentLink1.PrintingSystem = this.printingSystem1;
            this.printableComponentLink1.PrintingSystemBase = this.printingSystem1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 303);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbTipoMoviInven);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 35);
            this.panel2.TabIndex = 13;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 4, 6, 12, 23, 54, 101);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 6, 6, 12, 23, 54, 101);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(902, 155);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 14;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = true;
            // 
            // frmIn_AjustesInven_Cosulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmIn_AjustesInven_Cosulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Ajustes de Inventario";
            this.Load += new System.EventHandler(this.frmIn_AjustesInven_Cosulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinveInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAjustes_Cabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoMoviInven;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAjustes_Cabecera;
        private DevExpress.XtraGrid.Columns.GridColumn Bodega;
        private DevExpress.XtraGrid.Columns.GridColumn CodNomTipoMovi;
        private DevExpress.XtraGrid.Columns.GridColumn IdAjustes;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn Tipo;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn CodMoviInven;
        private DevExpress.XtraGrid.Columns.GridColumn ReferenciaOC;
        private System.Windows.Forms.BindingSource inmoviinveInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCodMoviInven;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
    }
}