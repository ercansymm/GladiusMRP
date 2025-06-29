using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.PRO;
using GladiusObjex.Provider;
using GladiusObjex.Tool;
using ProductionGladius.StockFiche;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionGladius.StockLines
{
    public partial class frmStockFicheList : DevExpress.XtraEditors.XtraForm
    {
        public frmStockFicheList()
        {
            InitializeComponent();
        }

        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        StockFiches myFiche = new StockFiches();
        public GladiusEnum.enmFormMod ScreenEnum = new GladiusEnum.enmFormMod();

        void fillGrid()
        {
            if (tglActive.IsOn == true)
            {
                dgwFiche.DataSource = dbm.ExecuteDataTable("Select * From Stockfiche Where Doctype = '0' ", CommandType.Text);
            }
            else
            {
                dgwFiche.DataSource = dbm.ExecuteDataTable("Select * From StockFiche Where Doctype = '1' ", CommandType.Text);

            }
        }

        private void frmStockFicheList_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmStockFicheCard stockFicheCard = new frmStockFicheCard();

            if (Application.OpenForms["frmStockFicheCard"] == null)
            {
                stockFicheCard.ScreenEnum = GladiusEnum.enmFormMod.NEW;
                myFiche = new StockFiches();
                stockFicheCard.ShowDialog();
                fillGrid();


            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grdFiche.FocusedRowHandle >= 0)
            {


                frmStockFicheCard stockFicheCard = new frmStockFicheCard();
                if (Application.OpenForms["frmStockFicheCard"] == null)
                {
                    stockFicheCard.ScreenEnum = GladiusEnum.enmFormMod.UPDATE;
                    stockFicheCard.Ref = Guid.Parse(grdFiche.GetFocusedRowCellValue(StockFicheRef).ToString());
                    stockFicheCard.ShowDialog();
                    fillGrid();

                }
            }
            else
            {

                XtraMessageBox.Show("Önce Bir Satır Seçmeniz Gerekmektedir", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmStockFicheCard stockCard = new frmStockFicheCard();
            if (Application.OpenForms["frmStockFicheCard"] == null)
            {
                stockCard.ScreenEnum = GladiusEnum.enmFormMod.VIEW;
                stockCard.Ref = Guid.Parse(grdFiche.GetFocusedRowCellValue(StockFicheRef).ToString());
                stockCard.ShowDialog();
                fillGrid();

            }
        }

        private void tglPassive_Toggled(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void grdFiche_DoubleClick(object sender, EventArgs e)
        {
            btnUpdate_Click(null, null);
            fillGrid();

        }

        private void tglActive_Toggled(object sender, EventArgs e)
        {
            fillGrid();
        }
    }
}