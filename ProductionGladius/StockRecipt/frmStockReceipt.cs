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

namespace ProductionGladius.StockRecipt
{
    public partial class frmStockReceipt : DevExpress.XtraEditors.XtraForm
    {
        public frmStockReceipt()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        StockReceipts myRecipt = new StockReceipts();
        void filLed()
        {

            riledStock.DataSource = dbm.ExecuteDataTable("Select Ref StockRef,CardName From Stock", CommandType.Text);
        }
        void fillGrid()
        {
            if (tglActive.IsOn == true)
            {
                dgwRecipt.DataSource = dbm.ExecuteDataTable("Select * From StockReceipt WHERE IsPassive = 'True' ", CommandType.Text);
            }
            else
            {
                dgwRecipt.DataSource = dbm.ExecuteDataTable("Select * From StockReceipt WHERE IsPassive = 'False'", CommandType.Text);
            }
        }



   

        private void frmStockReceipt_Load(object sender, EventArgs e)
        {
            fillGrid();
            filLed();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grdRecipt.FocusedRowHandle >= 0)
            {


                frmReceiptCard frmReceiptCard = new frmReceiptCard();
                if (Application.OpenForms["frmReceiptCard"] == null)
                {
                    frmReceiptCard.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.UPDATE;
                    frmReceiptCard.Ref = Guid.Parse(grdRecipt.GetFocusedRowCellValue(ReciptRef).ToString());
                    frmReceiptCard.ShowDialog();

                    fillGrid();

                }

            }
            else
            {

                XtraMessageBox.Show("Önce Bir Satır Seçmeniz Gerekmektedir", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            frmReceiptCard newReceiptCard = new frmReceiptCard();
            if (Application.OpenForms["frmReceiptCard"] == null)
            {
                newReceiptCard.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.NEW;
                newReceiptCard.ShowDialog();

                fillGrid();
            }

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            frmReceiptCard frmReceiptCard = new frmReceiptCard();
            if (Application.OpenForms["frmReceiptCard"] == null)
            {
                frmReceiptCard.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.VIEW;
                frmReceiptCard.Ref = Guid.Parse(grdRecipt.GetFocusedRowCellValue(ReciptRef).ToString());
                frmReceiptCard.ShowDialog();

            }

        }

        private void grdRecipt_DoubleClick(object sender, EventArgs e)
        {
            btnUpdate_Click(null, null);
            fillGrid();
        }

        private void tglActive_Toggled(object sender, EventArgs e)
        {
            fillGrid();
            filLed();
        }
    }
}