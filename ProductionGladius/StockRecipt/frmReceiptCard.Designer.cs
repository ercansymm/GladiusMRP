namespace ProductionGladius.StockRecipt
{
    partial class frmReceiptCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceiptCard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tglActive = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtReceiptNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCardName = new DevExpress.XtraEditors.TextEdit();
            this.ledStock = new DevExpress.XtraEditors.LookUpEdit();
            this.rchDescription = new System.Windows.Forms.RichTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgwRecipt = new DevExpress.XtraGrid.GridControl();
            this.grdRecipt = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmUnitRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledUnitRef = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ReciptDetailsRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmStokRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledStock = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clmAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnitRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.tglActive);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtReceiptNo);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.txtCardName);
            this.panel1.Controls.Add(this.ledStock);
            this.panel1.Controls.Add(this.rchDescription);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 236);
            this.panel1.TabIndex = 52;
            // 
            // tglActive
            // 
            this.tglActive.EditValue = true;
            this.tglActive.Location = new System.Drawing.Point(8, 181);
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
            this.tglActive.Size = new System.Drawing.Size(176, 25);
            this.tglActive.TabIndex = 72;
            this.tglActive.Toggled += new System.EventHandler(this.tglActive_Toggled);
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
            this.btnClose.Location = new System.Drawing.Point(284, 163);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 51);
            this.btnClose.TabIndex = 71;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnSave.Location = new System.Drawing.Point(576, 164);
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
            this.txtReceiptNo.Location = new System.Drawing.Point(142, 19);
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.Size = new System.Drawing.Size(75, 22);
            this.txtReceiptNo.TabIndex = 69;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(10, 19);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(113, 20);
            this.labelControl4.TabIndex = 68;
            this.labelControl4.Text = "Reçete Kodu";
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(142, 127);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(257, 22);
            this.txtCardName.TabIndex = 67;
            // 
            // ledStock
            // 
            this.ledStock.Location = new System.Drawing.Point(142, 72);
            this.ledStock.Margin = new System.Windows.Forms.Padding(2);
            this.ledStock.Name = "ledStock";
            this.ledStock.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.865546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ledStock.Properties.Appearance.Options.UseFont = true;
            this.ledStock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledStock.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName", 13, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.ledStock.Properties.DisplayMember = "CardName";
            this.ledStock.Properties.NullText = "";
            this.ledStock.Properties.ShowFooter = false;
            this.ledStock.Properties.ShowHeader = false;
            this.ledStock.Properties.ShowLines = false;
            this.ledStock.Properties.ValueMember = "Ref";
            this.ledStock.Size = new System.Drawing.Size(257, 22);
            this.ledStock.TabIndex = 66;
            // 
            // rchDescription
            // 
            this.rchDescription.Location = new System.Drawing.Point(482, 12);
            this.rchDescription.Name = "rchDescription";
            this.rchDescription.Size = new System.Drawing.Size(253, 139);
            this.rchDescription.TabIndex = 57;
            this.rchDescription.Text = "";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(394, 11);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 20);
            this.labelControl3.TabIndex = 56;
            this.labelControl3.Text = "Açıklama";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 130);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 20);
            this.labelControl2.TabIndex = 54;
            this.labelControl2.Text = "Reçete Adı";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 72);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 20);
            this.labelControl1.TabIndex = 53;
            this.labelControl1.Text = "Ürün Adı";
            // 
            // dgwRecipt
            // 
            this.dgwRecipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwRecipt.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgwRecipt.Location = new System.Drawing.Point(0, 236);
            this.dgwRecipt.MainView = this.grdRecipt;
            this.dgwRecipt.Name = "dgwRecipt";
            this.dgwRecipt.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riledStock,
            this.riledUnitRef});
            this.dgwRecipt.Size = new System.Drawing.Size(747, 437);
            this.dgwRecipt.TabIndex = 53;
            this.dgwRecipt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdRecipt});
            // 
            // grdRecipt
            // 
            this.grdRecipt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.grdRecipt.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grdRecipt.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdRecipt.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdRecipt.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmUnitRef,
            this.ReciptDetailsRef,
            this.clmStokRef,
            this.clmAmount});
            this.grdRecipt.GridControl = this.dgwRecipt;
            this.grdRecipt.Name = "grdRecipt";
            this.grdRecipt.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grdRecipt.OptionsView.ShowDetailButtons = false;
            this.grdRecipt.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grdRecipt.OptionsView.ShowGroupPanel = false;
            this.grdRecipt.OptionsView.ShowIndicator = false;
            // 
            // clmUnitRef
            // 
            this.clmUnitRef.Caption = "Birim";
            this.clmUnitRef.ColumnEdit = this.riledUnitRef;
            this.clmUnitRef.FieldName = "UnitRef";
            this.clmUnitRef.MinWidth = 25;
            this.clmUnitRef.Name = "clmUnitRef";
            this.clmUnitRef.Visible = true;
            this.clmUnitRef.VisibleIndex = 1;
            this.clmUnitRef.Width = 191;
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
            // ReciptDetailsRef
            // 
            this.ReciptDetailsRef.Caption = "Ref";
            this.ReciptDetailsRef.FieldName = "Ref";
            this.ReciptDetailsRef.MinWidth = 25;
            this.ReciptDetailsRef.Name = "ReciptDetailsRef";
            this.ReciptDetailsRef.Width = 93;
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
            this.clmStokRef.Width = 468;
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
            this.clmAmount.VisibleIndex = 2;
            this.clmAmount.Width = 255;
            // 
            // frmReceiptCard
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(48)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 673);
            this.Controls.Add(this.dgwRecipt);
            this.Controls.Add(this.panel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmReceiptCard.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frmReceiptCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reçete Kayıt Ekranı";
            this.Load += new System.EventHandler(this.frnReceiptCard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnitRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rchDescription;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dgwRecipt;
        private DevExpress.XtraGrid.Views.Grid.GridView grdRecipt;
        private DevExpress.XtraGrid.Columns.GridColumn ReciptDetailsRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmStokRef;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledStock;
        private DevExpress.XtraGrid.Columns.GridColumn clmUnitRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledUnitRef;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TextEdit txtCardName;
        private DevExpress.XtraEditors.TextEdit txtReceiptNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private DevExpress.XtraEditors.LookUpEdit ledStock;
        private DevExpress.XtraEditors.ToggleSwitch tglActive;
    }
}