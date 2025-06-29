namespace ProductionGladius.WorkOrder
{
    partial class frmWorckOrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorckOrderList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnView = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.dgwWork = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stpEnded = new System.Windows.Forms.ToolStripMenuItem();
            this.grdWork = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDates = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmWorkOrderRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.riledUnitRef = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWork)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnitRef)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 79);
            this.panel1.TabIndex = 6;
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
            // dgwWork
            // 
            this.dgwWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwWork.EmbeddedNavigator.ContextMenuStrip = this.contextMenuStrip1;
            this.dgwWork.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgwWork.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Asterisk;
            this.dgwWork.Location = new System.Drawing.Point(0, 79);
            this.dgwWork.MainView = this.grdWork;
            this.dgwWork.Name = "dgwWork";
            this.dgwWork.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riledStatus,
            this.riledUnitRef});
            this.dgwWork.Size = new System.Drawing.Size(1155, 560);
            this.dgwWork.TabIndex = 56;
            this.dgwWork.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdWork});
            this.dgwWork.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgwWork_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stpEnded});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 30);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // stpEnded
            // 
            this.stpEnded.BackColor = System.Drawing.Color.White;
            this.stpEnded.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stpEnded.Image = global::ProductionGladius.Properties.Resources.apply_32x32;
            this.stpEnded.Name = "stpEnded";
            this.stpEnded.Size = new System.Drawing.Size(210, 26);
            this.stpEnded.Text = "İş Emrini Sonlandır";
            this.stpEnded.Click += new System.EventHandler(this.stpEnded_Click);
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
            this.clmEndDate,
            this.clmDates,
            this.clmWorkOrderRef,
            this.clmNO,
            this.clmStatus});
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
            this.grdWork.OptionsView.ShowAutoFilterRow = true;
            this.grdWork.OptionsView.ShowDetailButtons = false;
            this.grdWork.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grdWork.OptionsView.ShowGroupPanel = false;
            this.grdWork.OptionsView.ShowIndicator = false;
            this.grdWork.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.grdWork_RowStyle);
            this.grdWork.DoubleClick += new System.EventHandler(this.grdWork_DoubleClick);
            // 
            // clmEndDate
            // 
            this.clmEndDate.Caption = "Bitiş Tarihi";
            this.clmEndDate.FieldName = "EndDate";
            this.clmEndDate.MinWidth = 25;
            this.clmEndDate.Name = "clmEndDate";
            this.clmEndDate.Visible = true;
            this.clmEndDate.VisibleIndex = 2;
            this.clmEndDate.Width = 309;
            // 
            // clmDates
            // 
            this.clmDates.Caption = "Başlangıç Tarihi";
            this.clmDates.FieldName = "StartDate";
            this.clmDates.MinWidth = 25;
            this.clmDates.Name = "clmDates";
            this.clmDates.Visible = true;
            this.clmDates.VisibleIndex = 1;
            this.clmDates.Width = 301;
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
            this.clmNO.Caption = "NO";
            this.clmNO.FieldName = "WorkOrderNo";
            this.clmNO.MinWidth = 25;
            this.clmNO.Name = "clmNO";
            this.clmNO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.clmNO.Visible = true;
            this.clmNO.VisibleIndex = 0;
            this.clmNO.Width = 291;
            // 
            // clmStatus
            // 
            this.clmStatus.Caption = "Durum";
            this.clmStatus.ColumnEdit = this.riledStatus;
            this.clmStatus.FieldName = "Status";
            this.clmStatus.MinWidth = 25;
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.Visible = true;
            this.clmStatus.VisibleIndex = 3;
            this.clmStatus.Width = 71;
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
            // frmWorckOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 639);
            this.Controls.Add(this.dgwWork);
            this.Controls.Add(this.panel1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmWorckOrderList.IconOptions.SvgImage")));
            this.Name = "frmWorckOrderList";
            this.Text = "İş Emirleri";
            this.Load += new System.EventHandler(this.frmWorckOrderList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWork)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnitRef)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnView;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNew;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.GridControl dgwWork;
        private DevExpress.XtraGrid.Views.Grid.GridView grdWork;
        private DevExpress.XtraGrid.Columns.GridColumn clmDates;
        private DevExpress.XtraGrid.Columns.GridColumn clmWorkOrderRef;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledStatus;
        private DevExpress.XtraGrid.Columns.GridColumn clmNO;
        private DevExpress.XtraGrid.Columns.GridColumn clmStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledUnitRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmEndDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stpEnded;
    }
}