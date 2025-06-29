namespace ProductionGladius.SubCategoys
{
    partial class frmSubs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubs));
            this.dgwSubCategory = new DevExpress.XtraGrid.GridControl();
            this.grdSubCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ledCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSubCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubCategory)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledCategory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwSubCategory
            // 
            this.dgwSubCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwSubCategory.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgwSubCategory.Location = new System.Drawing.Point(0, 72);
            this.dgwSubCategory.MainView = this.grdSubCategory;
            this.dgwSubCategory.Margin = new System.Windows.Forms.Padding(4);
            this.dgwSubCategory.Name = "dgwSubCategory";
            this.dgwSubCategory.Size = new System.Drawing.Size(493, 511);
            this.dgwSubCategory.TabIndex = 61;
            this.dgwSubCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdSubCategory});
            this.dgwSubCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgwSubCategory_KeyUp);
            // 
            // grdSubCategory
            // 
            this.grdSubCategory.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.grdSubCategory.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdSubCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmRef,
            this.clmCategory});
            this.grdSubCategory.DetailHeight = 437;
            this.grdSubCategory.GridControl = this.dgwSubCategory;
            this.grdSubCategory.Name = "grdSubCategory";
            this.grdSubCategory.OptionsCustomization.AllowGroup = false;
            this.grdSubCategory.OptionsDetail.EnableMasterViewMode = false;
            this.grdSubCategory.OptionsDetail.SmartDetailExpand = false;
            this.grdSubCategory.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grdSubCategory.OptionsView.ShowDetailButtons = false;
            this.grdSubCategory.OptionsView.ShowGroupPanel = false;
            // 
            // clmRef
            // 
            this.clmRef.Caption = "Ref";
            this.clmRef.FieldName = "Ref";
            this.clmRef.MinWidth = 31;
            this.clmRef.Name = "clmRef";
            this.clmRef.Width = 117;
            // 
            // clmCategory
            // 
            this.clmCategory.Caption = "Alt Kategori Adı";
            this.clmCategory.FieldName = "CardName";
            this.clmCategory.MinWidth = 31;
            this.clmCategory.Name = "clmCategory";
            this.clmCategory.Visible = true;
            this.clmCategory.VisibleIndex = 0;
            this.clmCategory.Width = 117;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.ledCategory);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 65);
            this.panel1.TabIndex = 60;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.28571F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(179, 27);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 20);
            this.labelControl1.TabIndex = 45;
            this.labelControl1.Text = "Üst Kategorisi";
            // 
            // ledCategory
            // 
            this.ledCategory.Location = new System.Drawing.Point(322, 25);
            this.ledCategory.Name = "ledCategory";
            this.ledCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CardName", "CardName")});
            this.ledCategory.Properties.DisplayMember = "CardName";
            this.ledCategory.Properties.NullText = "";
            this.ledCategory.Properties.ShowFooter = false;
            this.ledCategory.Properties.ShowHeader = false;
            this.ledCategory.Properties.ValueMember = "Ref";
            this.ledCategory.Size = new System.Drawing.Size(159, 22);
            this.ledCategory.TabIndex = 46;
            this.ledCategory.EditValueChanged += new System.EventHandler(this.ledSub_EditValueChanged);
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
            // frmSubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 583);
            this.Controls.Add(this.dgwSubCategory);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmSubs.IconOptions.SvgImage")));
            this.Name = "frmSubs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alt Kategoriler";
            this.Load += new System.EventHandler(this.frmSubs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSubCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubCategory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledCategory.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgwSubCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView grdSubCategory;
        private DevExpress.XtraGrid.Columns.GridColumn clmRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmCategory;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit ledCategory;
    }
}