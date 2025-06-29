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

namespace ProductionGladius.SubCategoys
{
    public partial class frmSubs : DevExpress.XtraEditors.XtraForm
    {
        public frmSubs()
        {
            InitializeComponent();
        }

        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        BindingList<SubCategorys> subCategorys = new BindingList<SubCategorys>();
        bool SaveControl()
        {
            StringBuilder stb = new StringBuilder();


            if (ledCategory.EditValue == null)
                stb.AppendLine("Lütfen Üst Kategoriyi Seçiniz ! ");

            if (stb.ToString().Length <= 0)
                return true;
            else
                XtraMessageBox.Show("Hata:" + stb.ToString(), "");
            return false;


            return false;
        }
        void filled()
        {
            ledCategory.Properties.DataSource = dbm.ExecuteDataTable("Select * from Categorys", CommandType.Text);

        }
        void filGrid()
        {
            subCategorys = mng.GetObjectList<SubCategorys>(" CategoryRef = '" + Guid.Parse(ledCategory.EditValue.ToString()) + "'", "");
            dgwSubCategory.DataSource = subCategorys;
        }

        private void frmSubs_Load(object sender, EventArgs e)
        {
            filled();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveControl())
                {
                    mng = new ObjectManager(true, "erpConnStr");
                    grdSubCategory.FocusedRowHandle = -1;

                    foreach (SubCategorys item in subCategorys)
                    {
                        if (item.CardName.Trim().Length > 0)
                        {
                            item.CategoryRef = Guid.Parse(ledCategory.EditValue.ToString());
                            mng.SaveObject<SubCategorys>(item);
                        }
                    }
                    mng.Commit();
                }
                XtraMessageBox.Show("Kayıt Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgwSubCategory_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                if (grdSubCategory.RowCount > 0)
                {
                    if (grdSubCategory.FocusedRowHandle > -1)
                    {
                        if (XtraMessageBox.Show("Satırı Silmek İstediğinize\nEmin Misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            mng = new ObjectManager(false, "erpConnStr");

                            try
                            {
                                int value = int.Parse(dbm.ExecuteScalar("select count(Ref) from SubCategorys where Ref = '" + grdSubCategory.GetFocusedRowCellValue(clmRef) + "'", CommandType.Text).ToString());
                                if (value > 0)
                                {
                                    mng.DeleteObject<SubCategorys>(Guid.Parse(grdSubCategory.GetFocusedRowCellValue(clmRef).ToString()));
                                    mng.Commit();
                                    grdSubCategory.DeleteSelectedRows();
                                }
                                else
                                {
                                    grdSubCategory.DeleteSelectedRows();
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

        private void ledSub_EditValueChanged(object sender, EventArgs e)
        {
            filGrid();
        }
    }
}