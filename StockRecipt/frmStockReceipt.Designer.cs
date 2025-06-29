namespace ProductionGladius.StockRecipt
{
    partial class frmStockReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockReceipt));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tglActive = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnDetails = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.grdRecipt = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ReciptRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmStokRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledStock = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dgwRecipt = new DevExpress.XtraGrid.GridControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecipt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.tglActive);
            this.panel1.Controls.Add(this.btnDetails);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 79);
            this.panel1.TabIndex = 4;
            // 
            // tglActive
            // 
            this.tglActive.Dock = System.Windows.Forms.DockStyle.Right;
            this.tglActive.EditValue = true;
            this.tglActive.Location = new System.Drawing.Point(915, 0);
            this.tglActive.Margin = new System.Windows.Forms.Padding(2);
            this.tglActive.Name = "tglActive";
            this.tglActive.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.tglActive.Properties.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.tglActive.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.tglActive.Properties.Appearance.Options.UseBackColor = true;
            this.tglActive.Properties.Appearance.Options.UseFont = true;
            this.tglActive.Properties.Appearance.Options.UseForeColor = true;
            this.tglActive.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tglActive.Properties.OffText = "Pasif";
            this.tglActive.Properties.OnText = "Aktif";
            this.tglActive.Size = new System.Drawing.Size(246, 79);
            this.tglActive.TabIndex = 64;
            this.tglActive.Toggled += new System.EventHandler(this.tglActive_Toggled);
            // 
            // btnDetails
            // 
            this.btnDetails.ActiveBorderThickness = 1;
            this.btnDetails.ActiveCornerRadius = 20;
            this.btnDetails.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(72)))), ((int)(((byte)(106)))));
            this.btnDetails.ActiveForecolor = System.Drawing.Color.White;
            this.btnDetails.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(72)))), ((int)(((byte)(106)))));
            this.btnDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.btnDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetails.BackgroundImage")));
            this.btnDetails.ButtonText = "Detay";
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDetails.IdleBorderThickness = 1;
            this.btnDetails.IdleCornerRadius = 20;
            this.btnDetails.IdleFillColor = System.Drawing.Color.White;
            this.btnDetails.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDetails.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDetails.Location = new System.Drawing.Point(385, 7);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(156, 51);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveBorderThickness = 1;
            this.btnUpdate.ActiveCornerRadius = 20;
            this.btnUpdate.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(72)))), ((int)(((byte)(106)))));
            this.btnUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdate.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(72)))), ((int)(((byte)(106)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.ButtonText = "Düzenle";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 20;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnUpdate.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnUpdate.Location = new System.Drawing.Point(199, 7);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 51);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.ActiveBorderThickness = 1;
            this.btnNew.ActiveCornerRadius = 20;
            this.btnNew.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(72)))), ((int)(((byte)(106)))));
            this.btnNew.ActiveForecolor = System.Drawing.Color.White;
            this.btnNew.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(72)))), ((int)(((byte)(106)))));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.ButtonText = "Yeni";
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnNew.IdleBorderThickness = 1;
            this.btnNew.IdleCornerRadius = 20;
            this.btnNew.IdleFillColor = System.Drawing.Color.White;
            this.btnNew.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnNew.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnNew.Location = new System.Drawing.Point(15, 7);
            this.btnNew.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(156, 51);
            this.btnNew.TabIndex = 1;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // grdRecipt
            // 
            this.grdRecipt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.grdRecipt.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grdRecipt.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdRecipt.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdRecipt.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ReciptRef,
            this.clmCardName,
            this.clmStokRef});
            this.grdRecipt.GridControl = this.dgwRecipt;
            this.grdRecipt.Name = "grdRecipt";
            this.grdRecipt.OptionsBehavior.Editable = false;
            this.grdRecipt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grdRecipt.OptionsView.ShowGroupPanel = false;
            this.grdRecipt.OptionsView.ShowIndicator = false;
            this.grdRecipt.DoubleClick += new System.EventHandler(this.grdRecipt_DoubleClick);
            // 
            // ReciptRef
            // 
            this.ReciptRef.Caption = "Ref";
            this.ReciptRef.FieldName = "Ref";
            this.ReciptRef.MinWidth = 25;
            this.ReciptRef.Name = "ReciptRef";
            this.ReciptRef.Width = 93;
            // 
            // clmCardName
            // 
            this.clmCardName.Caption = "Reçete Adı";
            this.clmCardName.FieldName = "CardName";
            this.clmCardName.MinWidth = 25;
            this.clmCardName.Name = "clmCardName";
            this.clmCardName.Visible = true;
            this.clmCardName.VisibleIndex = 1;
            this.clmCardName.Width = 721;
            // 
            // clmStokRef
            // 
            this.clmStokRef.Caption = "Ürün";
            this.clmStokRef.ColumnEdit = this.riledStock;
            this.clmStokRef.FieldName = "StockRef";
            this.clmStokRef.MinWidth = 25;
            this.clmStokRef.Name = "clmStokRef";
            this.clmStokRef.Visible = true;
            this.clmStokRef.VisibleIndex = 0;
            this.clmStokRef.Width = 438;
            // 
            // riledStock
            // 
            this.riledStock.AutoHeight = false;
            this.riledStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riledStock.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName")});
            this.riledStock.DisplayMember = "CardName";
            this.riledStock.Name = "riledStock";
            this.riledStock.NullText = "";
            this.riledStock.ShowFooter = false;
            this.riledStock.ShowHeader = false;
            this.riledStock.ShowLines = false;
            this.riledStock.ValueMember = "StockRef";
            // 
            // dgwRecipt
            // 
            this.dgwRecipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwRecipt.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgwRecipt.Location = new System.Drawing.Point(0, 79);
            this.dgwRecipt.MainView = this.grdRecipt;
            this.dgwRecipt.Name = "dgwRecipt";
            this.dgwRecipt.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riledStock});
            this.dgwRecipt.Size = new System.Drawing.Size(1161, 560);
            this.dgwRecipt.TabIndex = 5;
            this.dgwRecipt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdRecipt});
            // 
            // frmStockReceipt
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 639);
            this.Controls.Add(this.dgwRecipt);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmStockReceipt.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmStockReceipt";
            this.Text = "Stok Reçeteleri";
            this.Load += new System.EventHandler(this.frmStockReceipt_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tglActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecipt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDetails;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNew;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView grdRecipt;
        private DevExpress.XtraGrid.Columns.GridColumn ReciptRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmCardName;
        private DevExpress.XtraGrid.Columns.GridColumn clmStokRef;
        private DevExpress.XtraGrid.GridControl dgwRecipt;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledStock;
        private DevExpress.XtraEditors.ToggleSwitch tglActive;
    }
}