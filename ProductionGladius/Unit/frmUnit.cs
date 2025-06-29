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

namespace ProductionGladius.Unit
{
    public partial class frmUnit : DevExpress.XtraEditors.XtraForm
    {
        public frmUnit()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        BindingList<UnitCard> myCards = new BindingList<UnitCard>();

        void fillGrid()
        {
            myCards = mng.GetObjectList<UnitCard>("", "");
            dgwUnit.DataSource = myCards;
        }


        private void frmUnit_Load(object sender, EventArgs e)
        {
            fillGrid();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mng = new ObjectManager(true, "erpConnStr");
            grdUnit.FocusedRowHandle = -1;

            if (dgwUnit.DataSource != null)
            {
                try
                {
                    foreach (UnitCard item in myCards)
                    {
                        if (item.CardName.Trim().Length > 0)
                        {
                            mng.SaveObject<UnitCard>(item);
                        }

                    }
                    mng.Commit();
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
            else
            {
                XtraMessageBox.Show("Lütfen Satır Giriniz. !! ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dgwUnit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (grdUnit.RowCount > 0)
                {
                    if (grdUnit.FocusedRowHandle > -1)
                    {
                        if (XtraMessageBox.Show("Satırı Silmek İstediğinize\nEmin Misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            mng = new ObjectManager(false, "erpConnStr");

                            try
                            {
                                int value = int.Parse(dbm.ExecuteScalar("select count(Ref) from UnitCard where Ref = '" + grdUnit.GetFocusedRowCellValue(clmRef) + "'", CommandType.Text).ToString());
                                if (value > 0)
                                {
                                    mng.DeleteObject<UnitCard>(Guid.Parse(grdUnit.GetFocusedRowCellValue(clmRef).ToString()));
                                    mng.Commit();
                                    grdUnit.DeleteSelectedRows();
                                }
                                else
                                {
                                    grdUnit.DeleteSelectedRows();
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