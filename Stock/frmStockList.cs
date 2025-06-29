using DevExpress.XtraEditors;
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

namespace ProductionGladius.Stock
{
    public partial class frmStockList : DevExpress.XtraEditors.XtraForm
    {
        public frmStockList()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        Stocks myStocks = new Stocks();

        void fillGrid()
        {
            if (tglActive.IsOn == true)
            {
                dgwStock.DataSource = dbm.ExecuteDataTable("Select * From Stock Where IsPassive= 'True' ", CommandType.Text);
            }
            else
            {
                dgwStock.DataSource = dbm.ExecuteDataTable("Select * From Stock Where IsPassive = 'False' ", CommandType.Text);

            }
        }


        private void frmStockList_Load(object sender, EventArgs e)
        {
            fillGrid();
            riledUnit.DataSource = dbm.ExecuteDataTable("Select Ref UnitRef,CardName From UnitCard", CommandType.Text);

        }

        private void tglPassive_Toggled(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmStockCard stockCard = new frmStockCard();

            stockCard.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.NEW;
            if (Application.OpenForms["frmStockCard"] == null)
            {
                stockCard.ShowDialog();
                fillGrid();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grdStock.FocusedRowHandle >= 0)
            {
                frmStockCard stockCards = new frmStockCard();
                if (Application.OpenForms["frmStockCard"] == null)
                {
                    stockCards.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.UPDATE;
                    if (dgwStock.DataSource != null)
                    {
                        stockCards.Ref = Guid.Parse(grdStock.GetFocusedRowCellValue(StockRef).ToString());
                        stockCards.ShowDialog();
                        fillGrid();
                    }

                }
            }
            else
            {

                XtraMessageBox.Show("Önce Bir Satır Seçmeniz Gerekmektedir", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void grdStock_DoubleClick(object sender, EventArgs e)
        {
            btnUpdate_Click(null, null);
            fillGrid();
        }

        private void tglActive_Toggled(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            frmStockCard stockCards = new frmStockCard();
            if (Application.OpenForms["frmStockCard"] == null)
            {
                stockCards.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.VIEW;
                if (dgwStock.DataSource != null)
                {
                    stockCards.Ref = Guid.Parse(grdStock.GetFocusedRowCellValue(StockRef).ToString());
                    stockCards.ShowDialog();
                    fillGrid();

                }


            }
        }
    }
}