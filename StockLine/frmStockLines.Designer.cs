namespace ProductionGladius.StockLine
{
    partial class frmStockLines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockLines));
            this.dgwStockLine = new DevExpress.XtraGrid.GridControl();
            this.grdStockLine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledStock = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clmStockLineRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmUnitRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riledUnitRef = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStockLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnitRef)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwStockLine
            // 
            this.dgwStockLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwStockLine.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgwStockLine.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Asterisk;
            this.dgwStockLine.Location = new System.Drawing.Point(0, 0);
            this.dgwStockLine.MainView = this.grdStockLine;
            this.dgwStockLine.Name = "dgwStockLine";
            this.dgwStockLine.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riledUnitRef,
            this.riledStock});
            this.dgwStockLine.Size = new System.Drawing.Size(936, 677);
            this.dgwStockLine.TabIndex = 59;
            this.dgwStockLine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdStockLine});
            // 
            // grdStockLine
            // 
            this.grdStockLine.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
            this.grdStockLine.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Black;
            this.grdStockLine.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdStockLine.Appearance.FocusedCell.Options.UseBorderColor = true;
            this.grdStockLine.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent;
            this.grdStockLine.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black;
            this.grdStockLine.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdStockLine.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.grdStockLine.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.grdStockLine.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grdStockLine.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdStockLine.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdStockLine.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.grdStockLine.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdStockLine.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.grdStockLine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmAmount,
            this.clmStock,
            this.clmStockLineRef,
            this.clmUnitRef});
            this.grdStockLine.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdStockLine.GridControl = this.dgwStockLine;
            this.grdStockLine.Name = "grdStockLine";
            this.grdStockLine.OptionsBehavior.Editable = false;
            this.grdStockLine.OptionsCustomization.AllowFilter = false;
            this.grdStockLine.OptionsMenu.EnableColumnMenu = false;
            this.grdStockLine.OptionsMenu.EnableFooterMenu = false;
            this.grdStockLine.OptionsMenu.EnableGroupPanelMenu = false;
            this.grdStockLine.OptionsPrint.EnableAppearanceEvenRow = true;
            this.grdStockLine.OptionsPrint.EnableAppearanceOddRow = true;
            this.grdStockLine.OptionsPrint.PrintHorzLines = false;
            this.grdStockLine.OptionsPrint.PrintSelectedRowsOnly = true;
            this.grdStockLine.OptionsPrint.PrintVertLines = false;
            this.grdStockLine.OptionsView.ShowDetailButtons = false;
            this.grdStockLine.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grdStockLine.OptionsView.ShowGroupPanel = false;
            this.grdStockLine.OptionsView.ShowIndicator = false;
            this.grdStockLine.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.grdStockLine_RowStyle);
            // 
            // clmAmount
            // 
            this.clmAmount.Caption = "Miktar";
            this.clmAmount.FieldName = "Amount";
            this.clmAmount.MinWidth = 25;
            this.clmAmount.Name = "clmAmount";
            this.clmAmount.Visible = true;
            this.clmAmount.VisibleIndex = 2;
            this.clmAmount.Width = 250;
            // 
            // clmStock
            // 
            this.clmStock.Caption = "Ürün";
            this.clmStock.ColumnEdit = this.riledStock;
            this.clmStock.FieldName = "StockRef";
            this.clmStock.MinWidth = 25;
            this.clmStock.Name = "clmStock";
            this.clmStock.Visible = true;
            this.clmStock.VisibleIndex = 0;
            this.clmStock.Width = 404;
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
            // clmStockLineRef
            // 
            this.clmStockLineRef.Caption = "Ref";
            this.clmStockLineRef.FieldName = "Ref";
            this.clmStockLineRef.MinWidth = 25;
            this.clmStockLineRef.Name = "clmStockLineRef";
            this.clmStockLineRef.Width = 554;
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
            this.clmUnitRef.Width = 282;
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
            // frmStockLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 677);
            this.Controls.Add(this.dgwStockLine);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmStockLines.IconOptions.SvgImage")));
            this.Name = "frmStockLines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takibi";
            this.Load += new System.EventHandler(this.frmStockLİnes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStockLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riledUnitRef)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl dgwStockLine;
        private DevExpress.XtraGrid.Views.Grid.GridView grdStockLine;
        private DevExpress.XtraGrid.Columns.GridColumn clmAmount;
        private DevExpress.XtraGrid.Columns.GridColumn clmStock;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledStock;
        private DevExpress.XtraGrid.Columns.GridColumn clmStockLineRef;
        private DevExpress.XtraGrid.Columns.GridColumn clmUnitRef;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riledUnitRef;
    }
}