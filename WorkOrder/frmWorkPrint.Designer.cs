namespace ProductionGladius.WorkOrder
{
    partial class frmWorkPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkPrint));
            this.riledStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.riledStock = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.riledUnitRef = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgwWork = new DevExpress.XtraGrid.GridControl();
            this.grdWork = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmWorkOrderRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmBarkode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LedBarcode = new DevExpress.XtraEditors.LookUpEdit();
            this.dateTime = new DevExpress.XtraEditors.DateEdit();
            this.LedUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.ledReceipt = new DevExpress.XtraEditors.LookUpEdit();
            this.ledStock = new DevExpress.XtraEditors.LookUpEdit();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtWorckNo = new DevExpress.XtraEditors.TextEdit();
            this.rchDescription = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stpEnded = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.riledStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnitRef)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LedBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReceipt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorckNo.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // riledStatus
            // 
            this.riledStatus.AutoHeight = false;
            this.riledStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riledStatus.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName")});
            this.riledStatus.DisplayMember = "CardName";
            this.riledStatus.Name = "riledStatus";
            this.riledStatus.NullText = "";
            this.riledStatus.ShowFooter = false;
            this.riledStatus.ShowHeader = false;
            this.riledStatus.ShowLines = false;
            this.riledStatus.ValueMember = "Status";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 79);
            this.panel1.TabIndex = 58;
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveBorderThickness = 1;
            this.btnPrint.ActiveCornerRadius = 20;
            this.btnPrint.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(72)))), ((int)(((byte)(106)))));
            this.btnPrint.ActiveForecolor = System.Drawing.Color.White;
            this.btnPrint.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(72)))), ((int)(((byte)(106)))));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.ButtonText = "Yazdır";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnPrint.IdleBorderThickness = 1;
            this.btnPrint.IdleCornerRadius = 20;
            this.btnPrint.IdleFillColor = System.Drawing.Color.White;
            this.btnPrint.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnPrint.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnPrint.Location = new System.Drawing.Point(199, 7);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(156, 51);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.btnClose.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.White;
            this.btnClose.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnClose.Location = new System.Drawing.Point(385, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 51);
            this.btnClose.TabIndex = 2;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnSave.Location = new System.Drawing.Point(15, 7);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 51);
            this.btnSave.TabIndex = 1;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgwWork
            // 
            this.dgwWork.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwWork.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgwWork.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Asterisk;
            this.dgwWork.Location = new System.Drawing.Point(0, 239);
            this.dgwWork.MainView = this.grdWork;
            this.dgwWork.Name = "dgwWork";
            this.dgwWork.Size = new System.Drawing.Size(1161, 402);
            this.dgwWork.TabIndex = 59;
            this.dgwWork.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdWork});
            // 
            // grdWork
            // 
            this.grdWork.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
            this.grdWork.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Black;
            this.grdWork.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdWork.Appearance.FocusedCell.Options.UseBorderColor = true;
            this.grdWork.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent;
            this.grdWork.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black;
            this.grdWork.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdWork.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.grdWork.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.grdWork.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grdWork.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdWork.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdWork.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.grdWork.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdWork.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.grdWork.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmWorkOrderRef,
            this.clmNO,
            this.clmStatus,
            this.clmBarkode,
            this.clmStock,
            this.clmUnit});
            this.grdWork.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdWork.GridControl = this.dgwWork;
            this.grdWork.Name = "grdWork";
            this.grdWork.OptionsBehavior.Editable = false;
            this.grdWork.OptionsCustomization.AllowFilter = false;
            this.grdWork.OptionsMenu.EnableColumnMenu = false;
            this.grdWork.OptionsMenu.EnableFooterMenu = false;
            this.grdWork.OptionsMenu.EnableGroupPanelMenu = false;
            this.grdWork.OptionsPrint.PrintGroupFooter = false;
            this.grdWork.OptionsPrint.PrintSelectedRowsOnly = true;
            this.grdWork.OptionsView.ShowDetailButtons = false;
            this.grdWork.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grdWork.OptionsView.ShowGroupPanel = false;
            this.grdWork.OptionsView.ShowIndicator = false;
            this.grdWork.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.grdWork_RowStyle);
            this.grdWork.DoubleClick += new System.EventHandler(this.grdWork_DoubleClick);
            // 
            // clmWorkOrderRef
            // 
            this.clmWorkOrderRef.Caption = "Ref";
            this.clmWorkOrderRef.FieldName = "Ref";
            this.clmWorkOrderRef.MinWidth = 25;
            this.clmWorkOrderRef.Name = "clmWorkOrderRef";
            this.clmWorkOrderRef.Width = 554;
            // 
            // clmNO
            // 
            this.clmNO.Caption = "Lot No";
            this.clmNO.FieldName = "WorkOrderNo";
            this.clmNO.MinWidth = 25;
            this.clmNO.Name = "clmNO";
            this.clmNO.Width = 156;
            // 
            // clmStatus
            // 
            this.clmStatus.Caption = "Durum";
            this.clmStatus.ColumnEdit = this.riledStatus;
            this.clmStatus.FieldName = "Status";
            this.clmStatus.ImageOptions.Image = global::ProductionGladius.Properties.Resources.apply_32x32;
            this.clmStatus.MinWidth = 25;
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.Visible = true;
            this.clmStatus.VisibleIndex = 2;
            this.clmStatus.Width = 343;
            // 
            // clmBarkode
            // 
            this.clmBarkode.Caption = "Barkod";
            this.clmBarkode.FieldName = "Barcode";
            this.clmBarkode.ImageOptions.Image = global::ProductionGladius.Properties.Resources.barcode_32x32;
            this.clmBarkode.MinWidth = 25;
            this.clmBarkode.Name = "clmBarkode";
            this.clmBarkode.Visible = true;
            this.clmBarkode.VisibleIndex = 1;
            this.clmBarkode.Width = 188;
            // 
            // clmStock
            // 
            this.clmStock.Caption = "Ürün";
            this.clmStock.ColumnEdit = this.riledStock;
            this.clmStock.FieldName = "StockRef";
            this.clmStock.ImageOptions.Image = global::ProductionGladius.Properties.Resources.boproduct_32x32;
            this.clmStock.MinWidth = 25;
            this.clmStock.Name = "clmStock";
            this.clmStock.Visible = true;
            this.clmStock.VisibleIndex = 0;
            this.clmStock.Width = 453;
            // 
            // clmUnit
            // 
            this.clmUnit.Caption = "Birim";
            this.clmUnit.ColumnEdit = this.riledUnitRef;
            this.clmUnit.FieldName = "UnitRef";
            this.clmUnit.MinWidth = 25;
            this.clmUnit.Name = "clmUnit";
            this.clmUnit.Visible = true;
            this.clmUnit.VisibleIndex = 3;
            this.clmUnit.Width = 177;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.LedBarcode);
            this.groupBox1.Controls.Add(this.dateTime);
            this.groupBox1.Controls.Add(this.LedUnit);
            this.groupBox1.Controls.Add(this.ledReceipt);
            this.groupBox1.Controls.Add(this.ledStock);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.txtWorckNo);
            this.groupBox1.Controls.Add(this.rchDescription);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-6, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1167, 161);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Talep Bilgileri";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(809, 105);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 20);
            this.labelControl1.TabIndex = 97;
            this.labelControl1.Text = "Ürün Barkodu";
            // 
            // LedBarcode
            // 
            this.LedBarcode.Location = new System.Drawing.Point(958, 105);
            this.LedBarcode.Name = "LedBarcode";
            this.LedBarcode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LedBarcode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Barcode", "Barcode")});
            this.LedBarcode.Properties.DisplayMember = "Barcode";
            this.LedBarcode.Properties.NullText = "";
            this.LedBarcode.Properties.ShowFooter = false;
            this.LedBarcode.Properties.ShowHeader = false;
            this.LedBarcode.Properties.ValueMember = "Ref";
            this.LedBarcode.Size = new System.Drawing.Size(177, 22);
            this.LedBarcode.TabIndex = 96;
            this.LedBarcode.EditValueChanged += new System.EventHandler(this.LedBarcode_EditValueChanged);
            // 
            // dateTime
            // 
            this.dateTime.EditValue = null;
            this.dateTime.Enabled = false;
            this.dateTime.Location = new System.Drawing.Point(551, 111);
            this.dateTime.Name = "dateTime";
            this.dateTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTime.Size = new System.Drawing.Size(214, 22);
            this.dateTime.TabIndex = 94;
            // 
            // LedUnit
            // 
            this.LedUnit.Enabled = false;
            this.LedUnit.Location = new System.Drawing.Point(551, 18);
            this.LedUnit.Margin = new System.Windows.Forms.Padding(2);
            this.LedUnit.Name = "LedUnit";
            this.LedUnit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.865546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LedUnit.Properties.Appearance.Options.UseFont = true;
            this.LedUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LedUnit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName", 13, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.LedUnit.Properties.DisplayMember = "CardName";
            this.LedUnit.Properties.NullText = "";
            this.LedUnit.Properties.ShowFooter = false;
            this.LedUnit.Properties.ShowHeader = false;
            this.LedUnit.Properties.ShowLines = false;
            this.LedUnit.Properties.ValueMember = "Ref";
            this.LedUnit.Size = new System.Drawing.Size(214, 22);
            this.LedUnit.TabIndex = 92;
            // 
            // ledReceipt
            // 
            this.ledReceipt.Enabled = false;
            this.ledReceipt.Location = new System.Drawing.Point(177, 111);
            this.ledReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.ledReceipt.Name = "ledReceipt";
            this.ledReceipt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.865546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ledReceipt.Properties.Appearance.Options.UseFont = true;
            this.ledReceipt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledReceipt.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName", 13, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.ledReceipt.Properties.DisplayMember = "CardName";
            this.ledReceipt.Properties.NullText = "";
            this.ledReceipt.Properties.ShowFooter = false;
            this.ledReceipt.Properties.ShowHeader = false;
            this.ledReceipt.Properties.ShowLines = false;
            this.ledReceipt.Properties.ValueMember = "Ref";
            this.ledReceipt.Size = new System.Drawing.Size(214, 22);
            this.ledReceipt.TabIndex = 91;
            // 
            // ledStock
            // 
            this.ledStock.Enabled = false;
            this.ledStock.Location = new System.Drawing.Point(177, 66);
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
            this.ledStock.Size = new System.Drawing.Size(214, 22);
            this.ledStock.TabIndex = 90;
            // 
            // txtAmount
            // 
            this.txtAmount.EditValue = "";
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(551, 65);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(214, 22);
            this.txtAmount.TabIndex = 89;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(451, 113);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 20);
            this.labelControl4.TabIndex = 87;
            this.labelControl4.Text = "B. Tarihi";
            // 
            // txtWorckNo
            // 
            this.txtWorckNo.Enabled = false;
            this.txtWorckNo.Location = new System.Drawing.Point(177, 24);
            this.txtWorckNo.Name = "txtWorckNo";
            this.txtWorckNo.Size = new System.Drawing.Size(214, 22);
            this.txtWorckNo.TabIndex = 80;
            // 
            // rchDescription
            // 
            this.rchDescription.Enabled = false;
            this.rchDescription.Location = new System.Drawing.Point(958, 18);
            this.rchDescription.Name = "rchDescription";
            this.rchDescription.Size = new System.Drawing.Size(177, 68);
            this.rchDescription.TabIndex = 79;
            this.rchDescription.Text = " ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(809, 17);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(110, 20);
            this.labelControl8.TabIndex = 78;
            this.labelControl8.Text = "Üretim Notu";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(18, 27);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(58, 20);
            this.labelControl7.TabIndex = 75;
            this.labelControl7.Text = "Lot No";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(18, 111);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(126, 20);
            this.labelControl5.TabIndex = 73;
            this.labelControl5.Text = "Ürün Reçetesi";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(451, 66);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 20);
            this.labelControl3.TabIndex = 72;
            this.labelControl3.Text = "Miktar";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(451, 21);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 20);
            this.labelControl2.TabIndex = 71;
            this.labelControl2.Text = "Birim";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(18, 66);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(142, 20);
            this.labelControl6.TabIndex = 70;
            this.labelControl6.Text = "Üretilecek Ürün";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stpEnded});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 30);
            // 
            // stpEnded
            // 
            this.stpEnded.BackColor = System.Drawing.Color.White;
            this.stpEnded.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stpEnded.Image = global::ProductionGladius.Properties.Resources.apply_32x32;
            this.stpEnded.Name = "stpEnded";
            this.stpEnded.Size = new System.Drawing.Size(179, 26);
            this.stpEnded.Text = "Hepsini yazdır";
            // 
            // frmWorkPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 641);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwWork);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmWorkPrint.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frmWorkPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İş Emri Bitirme Panelii";
            this.Load += new System.EventHandler(this.frmWorkPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.riledStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnitRef)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LedBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReceipt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorckNo.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPrint;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private DevExpress.XtraGrid.GridControl dgwWork;
        private DevExpress.XtraGrid.Views.Grid.GridView grdWork;
        private DevExpress.XtraGrid.Columns.GridColumn clmWorkOrderRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmNO;
        private DevExpress.XtraGrid.Columns.GridColumn clmStatus;
        private DevExpress.XtraGrid.Columns.GridColumn clmBarkode;
        private DevExpress.XtraGrid.Columns.GridColumn clmStock;
        private DevExpress.XtraGrid.Columns.GridColumn clmUnit;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.DateEdit dateTime;
        private DevExpress.XtraEditors.LookUpEdit LedUnit;
        private DevExpress.XtraEditors.LookUpEdit ledReceipt;
        private DevExpress.XtraEditors.LookUpEdit ledStock;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtWorckNo;
        private System.Windows.Forms.RichTextBox rchDescription;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stpEnded;
        private DevExpress.XtraEditors.LookUpEdit LedBarcode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledStock;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledUnitRef;
    }
}