namespace ProductionGladius.StockFiche
{
    partial class frmStockFicheCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockFicheCard));
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tglActive = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dateTime = new DevExpress.XtraEditors.DateEdit();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtReceiptNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.rchDescription = new System.Windows.Forms.RichTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgwFiche = new DevExpress.XtraGrid.GridControl();
            this.grdFiche = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FicheDetailsRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmStokRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledStock = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clmAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledUnitRef = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFiche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnitRef)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName")});
            this.repositoryItemLookUpEdit1.DisplayMember = "CardName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ShowFooter = false;
            this.repositoryItemLookUpEdit1.ShowHeader = false;
            this.repositoryItemLookUpEdit1.ShowLines = false;
            this.repositoryItemLookUpEdit1.ValueMember = "UnitRef";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName")});
            this.repositoryItemLookUpEdit3.DisplayMember = "CardName";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "";
            this.repositoryItemLookUpEdit3.ShowFooter = false;
            this.repositoryItemLookUpEdit3.ShowHeader = false;
            this.repositoryItemLookUpEdit3.ShowLines = false;
            this.repositoryItemLookUpEdit3.ValueMember = "StockRef";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.tglActive);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.dateTime);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtReceiptNo);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.rchDescription);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 181);
            this.panel1.TabIndex = 53;
            // 
            // tglActive
            // 
            this.tglActive.EditValue = true;
            this.tglActive.Location = new System.Drawing.Point(12, 138);
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
            this.tglActive.Size = new System.Drawing.Size(176, 25);
            this.tglActive.TabIndex = 74;
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 20;
            this.btnClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(72)))), ((int)(((byte)(106)))));
            this.btnClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(72)))), ((int)(((byte)(106)))));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = "Vazgeç";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Enabled = false;
            this.btnClose.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.White;
            this.btnClose.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnClose.Location = new System.Drawing.Point(475, 121);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 51);
            this.btnClose.TabIndex = 73;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dateTime
            // 
            this.dateTime.EditValue = null;
            this.dateTime.Location = new System.Drawing.Point(125, 77);
            this.dateTime.Name = "dateTime";
            this.dateTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTime.Size = new System.Drawing.Size(138, 22);
            this.dateTime.TabIndex = 72;
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(72)))), ((int)(((byte)(106)))));
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(72)))), ((int)(((byte)(106)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Kaydet";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.White;
            this.btnSave.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSave.Location = new System.Drawing.Point(675, 121);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 51);
            this.btnSave.TabIndex = 70;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.Enabled = false;
            this.txtReceiptNo.Location = new System.Drawing.Point(125, 25);
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.Size = new System.Drawing.Size(49, 22);
            this.txtReceiptNo.TabIndex = 69;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 25);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 20);
            this.labelControl4.TabIndex = 68;
            this.labelControl4.Text = "Fis Kodu";
            // 
            // rchDescription
            // 
            this.rchDescription.Location = new System.Drawing.Point(475, 25);
            this.rchDescription.Name = "rchDescription";
            this.rchDescription.Size = new System.Drawing.Size(357, 83);
            this.rchDescription.TabIndex = 57;
            this.rchDescription.Text = "";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(353, 25);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 20);
            this.labelControl3.TabIndex = 56;
            this.labelControl3.Text = "Açıklama";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 77);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 20);
            this.labelControl1.TabIndex = 53;
            this.labelControl1.Text = "Tarih";
            // 
            // dgwFiche
            // 
            this.dgwFiche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwFiche.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgwFiche.Location = new System.Drawing.Point(0, 181);
            this.dgwFiche.MainView = this.grdFiche;
            this.dgwFiche.Name = "dgwFiche";
            this.dgwFiche.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riledStock,
            this.riledUnitRef});
            this.dgwFiche.Size = new System.Drawing.Size(845, 410);
            this.dgwFiche.TabIndex = 54;
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
            this.FicheDetailsRef,
            this.clmStokRef,
            this.clmAmount});
            this.grdFiche.GridControl = this.dgwFiche;
            this.grdFiche.Name = "grdFiche";
            this.grdFiche.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grdFiche.OptionsView.ShowDetailButtons = false;
            this.grdFiche.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grdFiche.OptionsView.ShowGroupPanel = false;
            this.grdFiche.OptionsView.ShowIndicator = false;
            // 
            // FicheDetailsRef
            // 
            this.FicheDetailsRef.Caption = "Ref";
            this.FicheDetailsRef.FieldName = "Ref";
            this.FicheDetailsRef.MinWidth = 25;
            this.FicheDetailsRef.Name = "FicheDetailsRef";
            this.FicheDetailsRef.Width = 93;
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
            this.clmStokRef.Width = 554;
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
            // clmAmount
            // 
            this.clmAmount.Caption = "Miktar";
            this.clmAmount.FieldName = "Amount";
            this.clmAmount.MinWidth = 25;
            this.clmAmount.Name = "clmAmount";
            this.clmAmount.Visible = true;
            this.clmAmount.VisibleIndex = 1;
            this.clmAmount.Width = 316;
            // 
            // riledUnitRef
            // 
            this.riledUnitRef.AutoHeight = false;
            this.riledUnitRef.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riledUnitRef.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName")});
            this.riledUnitRef.DisplayMember = "CardName";
            this.riledUnitRef.Name = "riledUnitRef";
            this.riledUnitRef.NullText = "";
            this.riledUnitRef.ShowFooter = false;
            this.riledUnitRef.ShowHeader = false;
            this.riledUnitRef.ShowLines = false;
            this.riledUnitRef.ValueMember = "UnitRef";
            // 
            // frmStockFicheCard
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(48)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 591);
            this.Controls.Add(this.dgwFiche);
            this.Controls.Add(this.panel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmStockFicheCard.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frmStockFicheCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiş Kayıt Ekranı";
            this.Load += new System.EventHandler(this.frmStockFicheCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFiche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnitRef)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private DevExpress.XtraEditors.TextEdit txtReceiptNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.RichTextBox rchDescription;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraGrid.GridControl dgwFiche;
        private DevExpress.XtraGrid.Views.Grid.GridView grdFiche;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledUnitRef;
        private DevExpress.XtraGrid.Columns.GridColumn FicheDetailsRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmStokRef;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledStock;
        private DevExpress.XtraGrid.Columns.GridColumn clmAmount;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private DevExpress.XtraEditors.ToggleSwitch tglActive;
    }
}