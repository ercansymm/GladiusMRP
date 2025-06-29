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

namespace ProductionGladius.users
{
    public partial class frmUserList : DevExpress.XtraEditors.XtraForm
    {
        public frmUserList()
        {
            InitializeComponent();
        }

        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        UserCard myUser = new UserCard();

        void fillGrid()
        {
            if (tglActive.IsOn == true)
            {
                dgwUser.DataSource = dbm.ExecuteDataTable("Select * From UserCard where IsPassive ='True' ", CommandType.Text);
            }
            else
            {
                dgwUser.DataSource = dbm.ExecuteDataTable("Select * From UserCard where IsPassive ='False' ", CommandType.Text);
            }

        }

        private void UserList_Load(object sender, EventArgs e)
        {

            fillGrid();
            tglActive.IsOn = true;
            riledStatüs.DataSource = dbm.ExecuteDataTable(@"select '0' State, 'Yönetici' StateName
            union ALL 
            select '1','Müdür'
            union ALL 
            select '2','İşçi'", CommandType.Text);


        }

        private void tglPassive_Toggled(object sender, EventArgs e)
        {
            fillGrid();
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grdUser.FocusedRowHandle >= 0)
            {

                if (Application.OpenForms["frmUserCard"] == null)
                {
                    frmUserCard frmUserCards = new frmUserCard();
                    frmUserCards.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.UPDATE;
                    frmUserCards.Ref = Guid.Parse(grdUser.GetFocusedRowCellValue(usrRef).ToString());
                    frmUserCards.ShowDialog();
                    fillGrid();
                }
            }
            else
            {

                XtraMessageBox.Show("Önce Bir Satır Seçmeniz Gerekmektedir", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grdUser_DoubleClick(object sender, EventArgs e)
        {
            btnUpdate_Click(null, null);
            fillGrid();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmUserCard"] == null)
            {
                frmUserCard frmUserCard = new frmUserCard();
                frmUserCard.ShowDialog();
                fillGrid();
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmUserCard"] == null)
            {
                frmUserCard usercard = new frmUserCard();
                usercard.ScreenEnum = GladiusObjex.Tool.GladiusEnum.enmFormMod.VIEW;
                usercard.Ref = Guid.Parse(grdUser.GetFocusedRowCellValue(usrRef).ToString());
                usercard.ShowDialog();
                fillGrid();
            }
        }

        private void tglActive_Toggled(object sender, EventArgs e)
        {
            fillGrid();
        }
    }
}