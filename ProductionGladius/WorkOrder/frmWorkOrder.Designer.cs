namespace ProductionGladius.WorkOrder
{
    partial class frmWorkOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkOrder));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataUpdate formatConditionRuleDataUpdate2 = new DevExpress.XtraEditors.FormatConditionRuleDataUpdate();
            this.clmStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgwWork = new DevExpress.XtraGrid.GridControl();
            this.grdWork = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmWorkOrderRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledStock = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clmStockRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledUnitRef = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReceipt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorckNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnitRef)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clmStatus
            // 
            this.clmStatus.Caption = "Status";
            this.clmStatus.FieldName = "Status";
            this.clmStatus.MinWidth = 25;
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.Width = 94;
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
            this.panel1.Size = new System.Drawing.Size(1161, 92);
            this.panel1.TabIndex = 6;
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
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
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
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1161, 154);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Talep Bilgileri";
            // 
            // dateTime
            // 
            this.dateTime.EditValue = null;
            this.dateTime.Location = new System.Drawing.Point(581, 111);
            this.dateTime.Name = "dateTime";
            this.dateTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTime.Size = new System.Drawing.Size(214, 22);
            this.dateTime.TabIndex = 94;
            this.dateTime.Leave += new System.EventHandler(this.dateTime_Leave);
            // 
            // LedUnit
            // 
            this.LedUnit.Location = new System.Drawing.Point(581, 18);
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
            this.ledReceipt.EditValueChanged += new System.EventHandler(this.ledReceipt_EditValueChanged);
            // 
            // ledStock
            // 
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
            this.ledStock.EditValueChanged += new System.EventHandler(this.ledStock_EditValueChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.EditValue = "";
            this.txtAmount.Location = new System.Drawing.Point(581, 65);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(214, 22);
            this.txtAmount.TabIndex = 89;
            this.txtAmount.EditValueChanged += new System.EventHandler(this.txtAmount_EditValueChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(419, 114);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(146, 20);
            this.labelControl4.TabIndex = 87;
            this.labelControl4.Text = "Baslangıç Tarihi";
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
            this.rchDescription.Location = new System.Drawing.Point(959, 18);
            this.rchDescription.Name = "rchDescription";
            this.rchDescription.Size = new System.Drawing.Size(177, 115);
            this.rchDescription.TabIndex = 79;
            this.rchDescription.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(831, 18);
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
            this.labelControl3.Location = new System.Drawing.Point(419, 69);
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
            this.labelControl2.Location = new System.Drawing.Point(419, 24);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 20);
            this.labelControl2.TabIndex = 71;
            this.labelControl2.Text = "Birim";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 66);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(142, 20);
            this.labelControl1.TabIndex = 70;
            this.labelControl1.Text = "Üretilecek Ürün";
            // 
            // dgwWork
            // 
            this.dgwWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwWork.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgwWork.Location = new System.Drawing.Point(0, 0);
            this.dgwWork.MainView = this.grdWork;
            this.dgwWork.Name = "dgwWork";
            this.dgwWork.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riledStock,
            this.riledUnitRef});
            this.dgwWork.Size = new System.Drawing.Size(1161, 408);
            this.dgwWork.TabIndex = 55;
            this.dgwWork.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdWork});
            this.dgwWork.Load += new System.EventHandler(this.frmWorkOrder_Load);
            // 
            // grdWork
            // 
            this.grdWork.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.grdWork.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grdWork.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdWork.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdWork.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmWorkOrderRef,
            this.clmStockRef,
            this.clmAmount,
            this.UnitRef,
            this.clmStatus});
            gridFormatRule2.Column = this.clmStatus;
            gridFormatRule2.Name = "Format0";
            formatConditionRuleDataUpdate2.Appearance.BackColor = System.Drawing.Color.Green;
            formatConditionRuleDataUpdate2.Appearance.Options.UseBackColor = true;
            formatConditionRuleDataUpdate2.HighlightTime = 500;
            gridFormatRule2.Rule = formatConditionRuleDataUpdate2;
            this.grdWork.FormatRules.Add(gridFormatRule2);
            this.grdWork.GridControl = this.dgwWork;
            this.grdWork.Name = "grdWork";
            this.grdWork.OptionsBehavior.Editable = false;
            this.grdWork.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grdWork.OptionsView.ShowDetailButtons = false;
            this.grdWork.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grdWork.OptionsView.ShowGroupPanel = false;
            this.grdWork.OptionsView.ShowIndicator = false;
            // 
            // clmWorkOrderRef
            // 
            this.clmWorkOrderRef.Caption = "Ref";
            this.clmWorkOrderRef.ColumnEdit = this.riledStock;
            this.clmWorkOrderRef.FieldName = "Ref";
            this.clmWorkOrderRef.MinWidth = 25;
            this.clmWorkOrderRef.Name = "clmWorkOrderRef";
            this.clmWorkOrderRef.Width = 554;
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
            // clmStockRef
            // 
            this.clmStockRef.Caption = "Hammadde/Yarı Mamüller";
            this.clmStockRef.ColumnEdit = this.riledStock;
            this.clmStockRef.FieldName = "StockRef";
            this.clmStockRef.MinWidth = 25;
            this.clmStockRef.Name = "clmStockRef";
            this.clmStockRef.Visible = true;
            this.clmStockRef.VisibleIndex = 0;
            this.clmStockRef.Width = 763;
            // 
            // clmAmount
            // 
            this.clmAmount.Caption = "Miktar";
            this.clmAmount.FieldName = "Amount";
            this.clmAmount.MinWidth = 25;
            this.clmAmount.Name = "clmAmount";
            this.clmAmount.Visible = true;
            this.clmAmount.VisibleIndex = 2;
            this.clmAmount.Width = 186;
            // 
            // UnitRef
            // 
            this.UnitRef.Caption = "Birim";
            this.UnitRef.ColumnEdit = this.riledUnitRef;
            this.UnitRef.FieldName = "UnitRef";
            this.UnitRef.MinWidth = 25;
            this.UnitRef.Name = "UnitRef";
            this.UnitRef.Visible = true;
            this.UnitRef.VisibleIndex = 1;
            this.UnitRef.Width = 210;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dgwWork);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1161, 408);
            this.panel2.TabIndex = 56;
            // 
            // frmWorkOrder
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmWorkOrder.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frmWorkOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İş Emri Kayıt Ekranı";
            this.Load += new System.EventHandler(this.frmWorkOrder_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledReceipt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorckNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnitRef)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.RichTextBox rchDescription;
        private DevExpress.XtraEditors.TextEdit txtWorckNo;
        private DevExpress.XtraGrid.GridControl dgwWork;
        private DevExpress.XtraGrid.Views.Grid.GridView grdWork;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledUnitRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmWorkOrderRef;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledStock;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn clmAmount;
        private DevExpress.XtraGrid.Columns.GridColumn clmStockRef;
        private DevExpress.XtraGrid.Columns.GridColumn UnitRef;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.LookUpEdit ledStock;
        private DevExpress.XtraEditors.LookUpEdit ledReceipt;
        private DevExpress.XtraEditors.LookUpEdit LedUnit;
        private DevExpress.XtraEditors.DateEdit dateTime;
        private DevExpress.XtraGrid.Columns.GridColumn clmStatus;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPrint;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}