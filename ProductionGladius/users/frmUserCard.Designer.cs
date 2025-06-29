namespace ProductionGladius.users
{
    partial class frmUserCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserCard));
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.peImage = new Bunifu.UI.WinForms.BunifuImageButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tglPassive = new DevExpress.XtraEditors.ToggleSwitch();
            this.lnk = new System.Windows.Forms.LinkLabel();
            this.ledStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtUserPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUserNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtPhoneNumber2 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tglPassive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber2.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(678, 329);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 51);
            this.btnSave.TabIndex = 37;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.peImage.ImageSize = new System.Drawing.Size(262, 241);
            this.peImage.ImageZoomSize = new System.Drawing.Size(302, 281);
            this.peImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("peImage.InitialImage")));
            this.peImage.Location = new System.Drawing.Point(553, 12);
            this.peImage.Name = "peImage";
            this.peImage.Rotation = 0;
            this.peImage.ShowActiveImage = true;
            this.peImage.ShowCursorChanges = true;
            this.peImage.ShowImageBorders = true;
            this.peImage.ShowSizeMarkers = false;
            this.peImage.Size = new System.Drawing.Size(302, 281);
            this.peImage.TabIndex = 36;
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
            this.labelControl8.Location = new System.Drawing.Point(19, 303);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(53, 20);
            this.labelControl8.TabIndex = 30;
            this.labelControl8.Text = "Görev";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(19, 258);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(116, 20);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Telefon No 2";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(19, 213);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(99, 20);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "Telefon No";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(19, 168);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 20);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Sifre";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(19, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(115, 20);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Kullanıcı adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(19, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 20);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Soyad";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 20);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Ad";
            // 
            // tglPassive
            // 
            this.tglPassive.EditValue = true;
            this.tglPassive.Location = new System.Drawing.Point(17, 355);
            this.tglPassive.Name = "tglPassive";
            this.tglPassive.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.tglPassive.Properties.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.tglPassive.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.tglPassive.Properties.Appearance.Options.UseBackColor = true;
            this.tglPassive.Properties.Appearance.Options.UseFont = true;
            this.tglPassive.Properties.Appearance.Options.UseForeColor = true;
            this.tglPassive.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tglPassive.Properties.OffText = "Pasif";
            this.tglPassive.Properties.OnText = "Aktif ";
            this.tglPassive.Size = new System.Drawing.Size(193, 25);
            this.tglPassive.TabIndex = 41;
            // 
            // lnk
            // 
            this.lnk.ActiveLinkColor = System.Drawing.Color.White;
            this.lnk.AutoSize = true;
            this.lnk.LinkColor = System.Drawing.Color.White;
            this.lnk.Location = new System.Drawing.Point(765, 296);
            this.lnk.Name = "lnk";
            this.lnk.Size = new System.Drawing.Size(69, 16);
            this.lnk.TabIndex = 42;
            this.lnk.TabStop = true;
            this.lnk.Text = "Resim Ekle";
            this.lnk.VisitedLinkColor = System.Drawing.Color.White;
            this.lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_LinkClicked);
            // 
            // ledStatus
            // 
            this.ledStatus.Location = new System.Drawing.Point(158, 309);
            this.ledStatus.Name = "ledStatus";
            this.ledStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledStatus.Properties.DisplayMember = "Value";
            this.ledStatus.Properties.NullText = "";
            this.ledStatus.Properties.ShowFooter = false;
            this.ledStatus.Properties.ShowHeader = false;
            this.ledStatus.Properties.ShowLines = false;
            this.ledStatus.Properties.ValueMember = "Key";
            this.ledStatus.Size = new System.Drawing.Size(214, 22);
            this.ledStatus.TabIndex = 35;
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
            this.btnClose.Location = new System.Drawing.Point(510, 329);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 51);
            this.btnClose.TabIndex = 43;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 22);
            this.txtName.TabIndex = 44;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(158, 79);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(214, 22);
            this.txtLastName.TabIndex = 45;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(158, 125);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(173, 22);
            this.txtUserName.TabIndex = 46;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(158, 171);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(173, 22);
            this.txtUserPassword.TabIndex = 47;
            // 
            // txtUserNumber
            // 
            this.txtUserNumber.Location = new System.Drawing.Point(158, 213);
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.Size = new System.Drawing.Size(155, 22);
            this.txtUserNumber.TabIndex = 48;
            this.txtUserNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserNumber_KeyPress);
            // 
            // txtPhoneNumber2
            // 
            this.txtPhoneNumber2.Location = new System.Drawing.Point(158, 263);
            this.txtPhoneNumber2.Name = "txtPhoneNumber2";
            this.txtPhoneNumber2.Size = new System.Drawing.Size(155, 22);
            this.txtPhoneNumber2.TabIndex = 49;
            // 
            // frmUserCard
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 424);
            this.Controls.Add(this.txtPhoneNumber2);
            this.Controls.Add(this.txtUserNumber);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lnk);
            this.Controls.Add(this.tglPassive);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.peImage);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ledStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmUserCard.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frmUserCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ekleme Ekranı";
            this.Load += new System.EventHandler(this.frmUserCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tglPassive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.UI.WinForms.BunifuImageButton peImage;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ToggleSwitch tglPassive;
        private System.Windows.Forms.LinkLabel lnk;
        private DevExpress.XtraEditors.LookUpEdit ledStatus;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtUserPassword;
        private DevExpress.XtraEditors.TextEdit txtUserNumber;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber2;
    }
}