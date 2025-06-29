using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Internal;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.PRO;
using GladiusObjex.Provider;
using GladiusObjex.Tool;
using ProductionGladius.Stock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionGladius.Clinet
{
    public partial class frmClinetList : DevExpress.XtraEditors.XtraForm
    {
        public frmClinetList()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        Clinets myClinets = new Clinets();

        void fillGrid()
        {
            if (tglActive.IsOn == true)
            {
                dgwClinet.DataSource = dbm.ExecuteDataTable("Select * from Clinet Where IsPassive = 'True' ", CommandType.Text);
            }
            else
            {
                dgwClinet.DataSource = dbm.ExecuteDataTable("Select * from Clinet Where IsPassive = 'False' ", CommandType.Text);
            }
        }
        private void frmClinetList_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void tglPassive_Toggled(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //frmClinetCard clinetCard = new frmClinetCard();
            //if (Application.OpenForms["frmClinetCard"] == null)
            //{
            //    clinetCard.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.NEW;
            //    if (dgwClinet.DataSource != null)
            //    {
            //        clinetCard.Ref = Guid.Parse(grdClinet.GetFocusedRowCellValue(ClinetRef).ToString());
            //        clinetCard.ShowDialog();
            //        fillGrid();

            //    }


            //}

            frmClinetCard Clinet = new frmClinetCard();
            Clinet.ScreenEnum = GladiusEnum.enmFormMod.NEW;

            if (Application.OpenForms["frmClinetCard"] == null)
            {
                Clinet.ShowDialog();
                fillGrid();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grdClinet.FocusedRowHandle >= 0)
            {
                frmClinetCard clinetCard = new frmClinetCard();
                if (Application.OpenForms["frmClinetCard"] == null)
                {
                    clinetCard.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.UPDATE;
                    if (dgwClinet.DataSource != null)
                    {
                        clinetCard.Ref = Guid.Parse(grdClinet.GetFocusedRowCellValue(ClinetRef).ToString());
                        clinetCard.ShowDialog();
                        fillGrid();

                    }


                }
            }
            else
            {

                XtraMessageBox.Show("Önce Bir Satır Seçmeniz Gerekmektedir", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

            frmClinetCard clinetCard = new frmClinetCard();
            if (Application.OpenForms["frmClinetCard"] == null)
            {
                clinetCard.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.VIEW;
                if (dgwClinet.DataSource != null)
                {
                    clinetCard.Ref = Guid.Parse(grdClinet.GetFocusedRowCellValue(ClinetRef).ToString());
                    clinetCard.ShowDialog();
                    fillGrid();

                }


            }

            //frmClinetCard Details = new frmClinetCard();
            //Details.ScreenEnum = GladiusEnum.enmFormMod.VIEW;

            //if (Application.OpenForms["frmClinetCard"] == null)
            //{
            //    Details.Ref = Guid.Parse(grdClinet.GetFocusedRowCellValue(ClinetkRef).ToString());
            //    Details.ShowDialog();
            //    fillGrid();
            //}

        }

        private void grdClinet_DoubleClick(object sender, EventArgs e)
        {
            btnUpdate_Click(null, null);
        }

        private void dgwClinet_DoubleClick(object sender, EventArgs e)
        {

        }

        private void tglActive_Toggled(object sender, EventArgs e)
        {
            fillGrid();
        }
    }
}