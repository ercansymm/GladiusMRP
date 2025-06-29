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

namespace ProductionGladius.Categoys
{
    public partial class frmCategory : DevExpress.XtraEditors.XtraForm
    {
        public frmCategory()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        BindingList<Categorys> myCategory = new BindingList<Categorys>();

        void fillGrid()
        {
            myCategory = mng.GetObjectList<Categorys>("", "");
            dgwCategoy.DataSource = myCategory;

        }


        private void frmCategory_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mng = new ObjectManager(true, "erpConnStr");
            
            grdCategory.FocusedRowHandle = -1;

            if (dgwCategoy.DataSource != null)
            {
                try
                {
                    foreach (Categorys item in myCategory)
                    {
                        if (item.CardName.Trim().Length > 0)
                        {
                            mng.SaveObject<Categorys>(item);

                        }
                    }
                    mng.Commit();
                    XtraMessageBox.Show("Kayıt Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (Exception ex )
                {

                    XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
          

            }
        }

        private void dgwCategoy_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                if (grdCategory.RowCount > 0)
                {
                    if (grdCategory.FocusedRowHandle > -1)
                    {
                        if (XtraMessageBox.Show("Satırı Silmek İstediğinize\nEmin Misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            mng = new ObjectManager(false, "erpConnStr");

                            try
                            {
                                int value = int.Parse(dbm.ExecuteScalar("select count(Ref) from Categorys where Ref = '" + grdCategory.GetFocusedRowCellValue(clmRef) + "'", CommandType.Text).ToString());
                                if (value > 0)
                                {
                                    mng.DeleteObject<Categorys>(Guid.Parse(grdCategory.GetFocusedRowCellValue(clmRef).ToString()));
                                    mng.Commit();
                                    grdCategory.DeleteSelectedRows();
                                }
                                else
                                {
                                    grdCategory.DeleteSelectedRows();
                                }
                                XtraMessageBox.Show("Satır Başarıyla Silindi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}