namespace ProductionGladius.Unit
{
    partial class frmUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgwUnit = new DevExpress.XtraGrid.GridControl();
            this.grdUnit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 65);
            this.panel1.TabIndex = 56;
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
            // dgwUnit
            // 
            this.dgwUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwUnit.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgwUnit.Location = new System.Drawing.Point(0, 65);
            this.dgwUnit.MainView = this.grdUnit;
            this.dgwUnit.Margin = new System.Windows.Forms.Padding(4);
            this.dgwUnit.Name = "dgwUnit";
            this.dgwUnit.Size = new System.Drawing.Size(493, 518);
            this.dgwUnit.TabIndex = 57;
            this.dgwUnit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdUnit});
            this.dgwUnit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgwUnit_KeyUp);
            // 
            // grdUnit
            // 
            this.grdUnit.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grdUnit.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdUnit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmRef,
            this.clmUnit});
            this.grdUnit.DetailHeight = 437;
            this.grdUnit.GridControl = this.dgwUnit;
            this.grdUnit.Name = "grdUnit";
            this.grdUnit.OptionsCustomization.AllowGroup = false;
            this.grdUnit.OptionsDetail.EnableMasterViewMode = false;
            this.grdUnit.OptionsDetail.SmartDetailExpand = false;
            this.grdUnit.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grdUnit.OptionsView.ShowDetailButtons = false;
            this.grdUnit.OptionsView.ShowGroupPanel = false;
            // 
            // clmRef
            // 
            this.clmRef.Caption = "Ref";
            this.clmRef.FieldName = "Ref";
            this.clmRef.MinWidth = 31;
            this.clmRef.Name = "clmRef";
            this.clmRef.Width = 117;
            // 
            // clmUnit
            // 
            this.clmUnit.Caption = "Birim Adı";
            this.clmUnit.FieldName = "CardName";
            this.clmUnit.MinWidth = 31;
            this.clmUnit.Name = "clmUnit";
            this.clmUnit.Visible = true;
            this.clmUnit.VisibleIndex = 0;
            this.clmUnit.Width = 117;
            // 
            // frmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 583);
            this.Controls.Add(this.dgwUnit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmUnit.IconOptions.SvgImage")));
            this.Name = "frmUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birimler";
            this.Load += new System.EventHandler(this.frmUnit_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private DevExpress.XtraGrid.GridControl dgwUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView grdUnit;
        private DevExpress.XtraGrid.Columns.GridColumn clmRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmUnit;
    }
}