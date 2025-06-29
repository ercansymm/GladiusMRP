namespace ProductionGladius.Stock
{
    partial class frmStockCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockCard));
            this.lnk = new System.Windows.Forms.LinkLabel();
            this.tglActive = new DevExpress.XtraEditors.ToggleSwitch();
            this.peImage = new Bunifu.UI.WinForms.BunifuImageButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rchDec = new System.Windows.Forms.RichTextBox();
            this.ledUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.ledCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtStockName = new DevExpress.XtraEditors.TextEdit();
            this.txtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.LedSubCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ledCardType = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.tglActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedSubCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCardType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lnk
            // 
            this.lnk.ActiveLinkColor = System.Drawing.Color.White;
            this.lnk.AutoSize = true;
            this.lnk.LinkColor = System.Drawing.Color.White;
            this.lnk.Location = new System.Drawing.Point(746, 294);
            this.lnk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnk.Name = "lnk";
            this.lnk.Size = new System.Drawing.Size(69, 16);
            this.lnk.TabIndex = 62;
            this.lnk.TabStop = true;
            this.lnk.Text = "Resim Ekle";
            this.lnk.VisitedLinkColor = System.Drawing.Color.White;
            this.lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_LinkClicked);
            // 
            // tglActive
            // 
            this.tglActive.EditValue = true;
            this.tglActive.Location = new System.Drawing.Point(18, 475);
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
            this.tglActive.Properties.OnText = "Aktif ";
            this.tglActive.Size = new System.Drawing.Size(150, 25);
            this.tglActive.TabIndex = 61;
            // 
            // peImage
            // 
            this.peImage.ActiveImage = null;
            this.peImage.AllowAnimations = true;
            this.peImage.AllowBuffering = false;
            this.peImage.AllowToggling = false;
            this.peImage.AllowZooming = true;
            this.peImage.AllowZoomingOnFocus = false;
            this.peImage.BackColor = System.Drawing.Color.Transparent;
            this.peImage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.peImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("peImage.ErrorImage")));
            this.peImage.FadeWhenInactive = false;
            this.peImage.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.peImage.Image = ((System.Drawing.Image)(resources.GetObject("peImage.Image")));
            this.peImage.ImageActive = null;
            this.peImage.ImageLocation = null;
            this.peImage.ImageMargin = 40;
            this.peImage.ImageSize = new System.Drawing.Size(278, 241);
            this.peImage.ImageZoomSize = new System.Drawing.Size(318, 281);
            this.peImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("peImage.InitialImage")));
            this.peImage.Location = new System.Drawing.Point(497, 11);
            this.peImage.Margin = new System.Windows.Forms.Padding(2);
            this.peImage.Name = "peImage";
            this.peImage.Rotation = 0;
            this.peImage.ShowActiveImage = true;
            this.peImage.ShowCursorChanges = true;
            this.peImage.ShowImageBorders = true;
            this.peImage.ShowSizeMarkers = false;
            this.peImage.Size = new System.Drawing.Size(318, 281);
            this.peImage.TabIndex = 59;
            this.peImage.ToolTipText = "";
            this.peImage.WaitOnLoad = false;
            this.peImage.Zoom = 40;
            this.peImage.ZoomSpeed = 10;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(18, 371);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(150, 20);
            this.labelControl8.TabIndex = 53;
            this.labelControl8.Text = "Ürün Açıklaması";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(438, 21);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 20);
            this.labelControl7.TabIndex = 52;
            this.labelControl7.Text = "Resim";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 221);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 20);
            this.labelControl3.TabIndex = 48;
            this.labelControl3.Text = "Kategorisi";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 121);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 20);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "Birimi";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 71);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 20);
            this.labelControl1.TabIndex = 44;
            this.labelControl1.Text = "Ürün Adı";
            // 
            // rchDec
            // 
            this.rchDec.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.rchDec.Location = new System.Drawing.Point(183, 371);
            this.rchDec.Margin = new System.Windows.Forms.Padding(2);
            this.rchDec.Name = "rchDec";
            this.rchDec.Size = new System.Drawing.Size(248, 85);
            this.rchDec.TabIndex = 64;
            this.rchDec.Text = "";
            // 
            // ledUnit
            // 
            this.ledUnit.Location = new System.Drawing.Point(183, 120);
            this.ledUnit.Margin = new System.Windows.Forms.Padding(2);
            this.ledUnit.Name = "ledUnit";
            this.ledUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledUnit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName", 13, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.ledUnit.Properties.DisplayMember = "CardName";
            this.ledUnit.Properties.NullText = "";
            this.ledUnit.Properties.ShowFooter = false;
            this.ledUnit.Properties.ShowHeader = false;
            this.ledUnit.Properties.ShowLines = false;
            this.ledUnit.Properties.ValueMember = "Ref";
            this.ledUnit.Size = new System.Drawing.Size(132, 22);
            this.ledUnit.TabIndex = 65;
            // 
            // ledCategory
            // 
            this.ledCategory.Location = new System.Drawing.Point(183, 222);
            this.ledCategory.Margin = new System.Windows.Forms.Padding(2);
            this.ledCategory.Name = "ledCategory";
            this.ledCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName")});
            this.ledCategory.Properties.DisplayMember = "CardName";
            this.ledCategory.Properties.NullText = "";
            this.ledCategory.Properties.ShowFooter = false;
            this.ledCategory.Properties.ShowHeader = false;
            this.ledCategory.Properties.ShowLines = false;
            this.ledCategory.Properties.ValueMember = "Ref";
            this.ledCategory.Size = new System.Drawing.Size(172, 22);
            this.ledCategory.TabIndex = 66;
            this.ledCategory.EditValueChanged += new System.EventHandler(this.ledCategory_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(18, 321);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(131, 20);
            this.labelControl4.TabIndex = 67;
            this.labelControl4.Text = "Ürüm Barkodu";
            // 
            // txtStockName
            // 
            this.txtStockName.Location = new System.Drawing.Point(183, 69);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(248, 22);
            this.txtStockName.TabIndex = 69;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(183, 324);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(172, 22);
            this.txtBarcode.TabIndex = 70;
            // 
            // LedSubCategory
            // 
            this.LedSubCategory.Location = new System.Drawing.Point(183, 273);
            this.LedSubCategory.Margin = new System.Windows.Forms.Padding(2);
            this.LedSubCategory.Name = "LedSubCategory";
            this.LedSubCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LedSubCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName")});
            this.LedSubCategory.Properties.DisplayMember = "CardName";
            this.LedSubCategory.Properties.NullText = "";
            this.LedSubCategory.Properties.ShowFooter = false;
            this.LedSubCategory.Properties.ShowHeader = false;
            this.LedSubCategory.Properties.ShowLines = false;
            this.LedSubCategory.Properties.ValueMember = "Ref";
            this.LedSubCategory.Size = new System.Drawing.Size(172, 22);
            this.LedSubCategory.TabIndex = 72;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(18, 271);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(124, 20);
            this.labelControl5.TabIndex = 71;
            this.labelControl5.Text = "Alt Kategorisi";
            // 
            // ledCardType
            // 
            this.ledCardType.Location = new System.Drawing.Point(183, 171);
            this.ledCardType.Margin = new System.Windows.Forms.Padding(2);
            this.ledCardType.Name = "ledCardType";
            this.ledCardType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledCardType.Properties.DisplayMember = "Value";
            this.ledCardType.Properties.NullText = "";
            this.ledCardType.Properties.ShowFooter = false;
            this.ledCardType.Properties.ShowHeader = false;
            this.ledCardType.Properties.ShowLines = false;
            this.ledCardType.Properties.ValueMember = "Key";
            this.ledCardType.Size = new System.Drawing.Size(132, 22);
            this.ledCardType.TabIndex = 74;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(18, 171);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(149, 20);
            this.labelControl6.TabIndex = 73;
            this.labelControl6.Text = "Genel Kategorisi";
            // 
            // txtNo
            // 
            this.txtNo.Enabled = false;
            this.txtNo.Location = new System.Drawing.Point(181, 21);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(74, 22);
            this.txtNo.TabIndex = 76;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Enabled = false;
            this.labelControl9.Location = new System.Drawing.Point(16, 23);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(81, 20);
            this.labelControl9.TabIndex = 75;
            this.labelControl9.Text = "Stok Kod";
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
            this.btnSave.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.White;
            this.btnSave.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnSave.Location = new System.Drawing.Point(595, 345);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 51);
            this.btnSave.TabIndex = 77;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.White;
            this.btnClose.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnClose.Location = new System.Drawing.Point(595, 408);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 51);
            this.btnClose.TabIndex = 78;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmStockCard
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 522);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.ledCardType);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.LedSubCategory);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtStockName);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ledCategory);
            this.Controls.Add(this.ledUnit);
            this.Controls.Add(this.rchDec);
            this.Controls.Add(this.lnk);
            this.Controls.Add(this.tglActive);
            this.Controls.Add(this.peImage);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmStockCard.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frmStockCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Kayıt Ekranı";
            this.Load += new System.EventHandler(this.frmStockCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tglActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedSubCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCardType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnk;
        private DevExpress.XtraEditors.ToggleSwitch tglActive;
        private Bunifu.UI.WinForms.BunifuImageButton peImage;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox rchDec;
        private DevExpress.XtraEditors.LookUpEdit ledUnit;
        private DevExpress.XtraEditors.LookUpEdit ledCategory;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtStockName;
        private DevExpress.XtraEditors.TextEdit txtBarcode;
        private DevExpress.XtraEditors.LookUpEdit LedSubCategory;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit ledCardType;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtNo;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
    }
}