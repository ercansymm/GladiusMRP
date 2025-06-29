namespace ProductionGladius.Stock
{
    partial class frmStockList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockList));
            this.dgwStock = new DevExpress.XtraGrid.GridControl();
            this.grdStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.StockRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clmStockcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetail = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tglActive = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwStock
            // 
            this.dgwStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwStock.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgwStock.Location = new System.Drawing.Point(0, 79);
            this.dgwStock.MainView = this.grdStock;
            this.dgwStock.Name = "dgwStock";
            this.dgwStock.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riledUnit});
            this.dgwStock.Size = new System.Drawing.Size(1161, 560);
            this.dgwStock.TabIndex = 3;
            this.dgwStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdStock});
            // 
            // grdStock
            // 
            this.grdStock.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.grdStock.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grdStock.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdStock.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdStock.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.StockRef,
            this.clmCardName,
            this.clmUnit,
            this.clmStockcode});
            this.grdStock.GridControl = this.dgwStock;
            this.grdStock.Name = "grdStock";
            this.grdStock.OptionsBehavior.Editable = false;
            this.grdStock.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grdStock.OptionsView.ShowGroupPanel = false;
            this.grdStock.OptionsView.ShowIndicator = false;
            this.grdStock.DoubleClick += new System.EventHandler(this.grdStock_DoubleClick);
            // 
            // StockRef
            // 
            this.StockRef.Caption = "Ref";
            this.StockRef.FieldName = "Ref";
            this.StockRef.MinWidth = 25;
            this.StockRef.Name = "StockRef";
            this.StockRef.Width = 93;
            // 
            // clmCardName
            // 
            this.clmCardName.Caption = "Ürün Adı";
            this.clmCardName.FieldName = "CardName";
            this.clmCardName.MinWidth = 25;
            this.clmCardName.Name = "clmCardName";
            this.clmCardName.Visible = true;
            this.clmCardName.VisibleIndex = 1;
            this.clmCardName.Width = 540;
            // 
            // clmUnit
            // 
            this.clmUnit.Caption = "Birim";
            this.clmUnit.ColumnEdit = this.riledUnit;
            this.clmUnit.FieldName = "UnitRef";
            this.clmUnit.MinWidth = 25;
            this.clmUnit.Name = "clmUnit";
            this.clmUnit.Visible = true;
            this.clmUnit.VisibleIndex = 2;
            this.clmUnit.Width = 544;
            // 
            // riledUnit
            // 
            this.riledUnit.AutoHeight = false;
            this.riledUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riledUnit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName")});
            this.riledUnit.DisplayMember = "CardName";
            this.riledUnit.Name = "riledUnit";
            this.riledUnit.NullText = "";
            this.riledUnit.ShowFooter = false;
            this.riledUnit.ShowHeader = false;
            this.riledUnit.ValueMember = "UnitRef";
            // 
            // clmStockcode
            // 
            this.clmStockcode.Caption = "No";
            this.clmStockcode.FieldName = "StockCode";
            this.clmStockcode.MinWidth = 25;
            this.clmStockcode.Name = "clmStockcode";
            this.clmStockcode.Visible = true;
            this.clmStockcode.VisibleIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.btnDetail);
            this.panel1.Controls.Add(this.tglActive);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 79);
            this.panel1.TabIndex = 2;
            // 
            // btnDetail
            // 
            this.btnDetail.ActiveBorderThickness = 1;
            this.btnDetail.ActiveCornerRadius = 20;
            this.btnDetail.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(72)))), ((int)(((byte)(106)))));
            this.btnDetail.ActiveForecolor = System.Drawing.Color.White;
            this.btnDetail.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(72)))), ((int)(((byte)(106)))));
            this.btnDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.btnDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetail.BackgroundImage")));
            this.btnDetail.ButtonText = "Detay";
            this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetail.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.btnDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDetail.IdleBorderThickness = 1;
            this.btnDetail.IdleCornerRadius = 20;
            this.btnDetail.IdleFillColor = System.Drawing.Color.White;
            this.btnDetail.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDetail.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDetail.Location = new System.Drawing.Point(385, 7);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(156, 51);
            this.btnDetail.TabIndex = 64;
            this.btnDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
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
            this.tglActive.TabIndex = 63;
            this.tglActive.Toggled += new System.EventHandler(this.tglActive_Toggled);
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
            // frmStockList
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 639);
            this.Controls.Add(this.dgwStock);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmStockList.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmStockList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stoklar";
            this.Load += new System.EventHandler(this.frmStockList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnit)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tglActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgwStock;
        private DevExpress.XtraGrid.Views.Grid.GridView grdStock;
        private DevExpress.XtraGrid.Columns.GridColumn StockRef;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNew;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn clmCardName;
        private DevExpress.XtraGrid.Columns.GridColumn clmUnit;
        private DevExpress.XtraGrid.Columns.GridColumn clmStockcode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledUnit;
        private DevExpress.XtraEditors.ToggleSwitch tglActive;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDetail;
    }
}