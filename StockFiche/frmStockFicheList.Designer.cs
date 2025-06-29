namespace ProductionGladius.StockLines
{
    partial class frmStockFicheList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockFicheList));
            this.dgwFiche = new DevExpress.XtraGrid.GridControl();
            this.grdFiche = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.StockFicheRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmFicheNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tglActive = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnView = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFiche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwFiche
            // 
            this.dgwFiche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwFiche.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgwFiche.Location = new System.Drawing.Point(0, 79);
            this.dgwFiche.MainView = this.grdFiche;
            this.dgwFiche.Name = "dgwFiche";
            this.dgwFiche.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riledUnit});
            this.dgwFiche.Size = new System.Drawing.Size(1161, 560);
            this.dgwFiche.TabIndex = 5;
            this.dgwFiche.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdFiche});
            // 
            // grdFiche
            // 
            this.grdFiche.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.grdFiche.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grdFiche.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdFiche.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdFiche.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.StockFicheRef,
            this.clmFicheNo,
            this.clmDate,
            this.clmDescription});
            this.grdFiche.GridControl = this.dgwFiche;
            this.grdFiche.Name = "grdFiche";
            this.grdFiche.OptionsBehavior.Editable = false;
            this.grdFiche.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grdFiche.OptionsView.ShowGroupPanel = false;
            this.grdFiche.OptionsView.ShowIndicator = false;
            this.grdFiche.DoubleClick += new System.EventHandler(this.grdFiche_DoubleClick);
            // 
            // StockFicheRef
            // 
            this.StockFicheRef.Caption = "Ref";
            this.StockFicheRef.FieldName = "Ref";
            this.StockFicheRef.MinWidth = 25;
            this.StockFicheRef.Name = "StockFicheRef";
            this.StockFicheRef.Width = 93;
            // 
            // clmFicheNo
            // 
            this.clmFicheNo.Caption = "Fiş No";
            this.clmFicheNo.FieldName = "FicheNo";
            this.clmFicheNo.MinWidth = 25;
            this.clmFicheNo.Name = "clmFicheNo";
            this.clmFicheNo.Visible = true;
            this.clmFicheNo.VisibleIndex = 0;
            this.clmFicheNo.Width = 121;
            // 
            // clmDate
            // 
            this.clmDate.Caption = "Tarih";
            this.clmDate.FieldName = "FicheDate";
            this.clmDate.MinWidth = 25;
            this.clmDate.Name = "clmDate";
            this.clmDate.Visible = true;
            this.clmDate.VisibleIndex = 1;
            this.clmDate.Width = 254;
            // 
            // clmDescription
            // 
            this.clmDescription.Caption = "Detay Notu";
            this.clmDescription.FieldName = "Description";
            this.clmDescription.MinWidth = 25;
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.Visible = true;
            this.clmDescription.VisibleIndex = 2;
            this.clmDescription.Width = 288;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.tglActive);
            this.panel1.Controls.Add(this.btnView);
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
            this.tglActive.Location = new System.Drawing.Point(942, 0);
            this.tglActive.Margin = new System.Windows.Forms.Padding(2);
            this.tglActive.Name = "tglActive";
            this.tglActive.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.tglActive.Properties.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.tglActive.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.tglActive.Properties.Appearance.Options.UseBackColor = true;
            this.tglActive.Properties.Appearance.Options.UseFont = true;
            this.tglActive.Properties.Appearance.Options.UseForeColor = true;
            this.tglActive.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tglActive.Properties.OffText = "Çıkıs";
            this.tglActive.Properties.OnText = "Giris";
            this.tglActive.Size = new System.Drawing.Size(219, 79);
            this.tglActive.TabIndex = 64;
            this.tglActive.Toggled += new System.EventHandler(this.tglActive_Toggled);
            // 
            // btnView
            // 
            this.btnView.ActiveBorderThickness = 1;
            this.btnView.ActiveCornerRadius = 20;
            this.btnView.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(72)))), ((int)(((byte)(106)))));
            this.btnView.ActiveForecolor = System.Drawing.Color.White;
            this.btnView.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(72)))), ((int)(((byte)(106)))));
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.btnView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnView.BackgroundImage")));
            this.btnView.ButtonText = "Detay";
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.btnView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnView.IdleBorderThickness = 1;
            this.btnView.IdleCornerRadius = 20;
            this.btnView.IdleFillColor = System.Drawing.Color.White;
            this.btnView.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnView.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnView.Location = new System.Drawing.Point(385, 7);
            this.btnView.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(156, 51);
            this.btnView.TabIndex = 36;
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
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
            // frmStockFicheList
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 639);
            this.Controls.Add(this.dgwFiche);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmStockFicheList.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmStockFicheList";
            this.Text = "Fişler";
            this.Load += new System.EventHandler(this.frmStockFicheList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFiche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnit)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tglActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgwFiche;
        private DevExpress.XtraGrid.Views.Grid.GridView grdFiche;
        private DevExpress.XtraGrid.Columns.GridColumn StockFicheRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmFicheNo;
        private DevExpress.XtraGrid.Columns.GridColumn clmDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledUnit;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNew;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn clmDescription;
        private Bunifu.Framework.UI.BunifuThinButton2 btnView;
        private DevExpress.XtraEditors.ToggleSwitch tglActive;
    }
}