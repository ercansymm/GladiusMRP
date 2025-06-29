using Bunifu.UI.WinForms;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.PRO;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionGladius.StockLine
{
    public partial class frmStockLines : DevExpress.XtraEditors.XtraForm
    {
        public frmStockLines()
        {
            InitializeComponent();
        }

        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        StockLiness myLine = new StockLiness();
        void fillLed()
        {
            riledStock.DataSource = dbm.ExecuteDataTable("Select Ref StockRef,CardName from Stock ", CommandType.Text);
            riledUnitRef.DataSource = dbm.ExecuteDataTable("Select Ref UnitRef,CardName from UnitCard", CommandType.Text);
        }
        void fillGrid()
        {

            dgwStockLine.DataSource = dbm.ExecuteDataTable(


                  "SELECT " +
         "    SC.Ref AS StockRef, " +
         "    SC.UnitRef  AS UnitRef, " +
         "    SUM(CASE SL.LinelIO WHEN 0 THEN SL.Amount ELSE SL.Amount * -1 END) AS Amount " +
         "FROM " +
         "    StockLines SL " +
         "INNER JOIN " +
         "    Stock SC ON SC.Ref = SL.StockRef " +

         "GROUP BY " +
         "    SC.Ref, SC.UnitRef",
                     CommandType.Text
                 );

        }

      
        private void frmStockLİnes_Load(object sender, EventArgs e)
        {
            fillGrid();
            fillLed();
        }


     



        private void grdStockLine_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.RowHandle >= 0)
            {
                var amountValue = view.GetRowCellValue(e.RowHandle, "Amount");
                decimal amount = 0;

                if (decimal.TryParse(amountValue?.ToString(), out amount))
                {
                    if (amount <= 0)
                    {
                        e.Appearance.BackColor = Color.FromArgb(255, 204, 203);
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.FromArgb(204, 255, 204);
                    }
                }
            }
        }

    }
}