using DevExpress.CodeParser;
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
using System.Diagnostics;
namespace ProductionGladius.Login_Screen
{
    public partial class frmLoginScreen : DevExpress.XtraEditors.XtraForm
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        UserCard myUser = new UserCard();
        int userExisting;
        int userStating;
        int UserPass;
        public DialogResult res = DialogResult.OK;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Çıkmak İstediğinize Emin Misiniz ? ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                return;
            }

        }



        private void frmLoginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }

        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            txtUserName.Focus();
        }

        private void frmLoginScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter_Click(null, null);
            }
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {

            try
            {
                if ((txtUserName.Text != null && txtUserName.Text != "") && (txtPassword.Text != null && txtPassword.Text != ""))
                {
                    userExisting = int.Parse(dbm.ExecuteScalar(
                        "SELECT COUNT(Ref) FROM UserCard WHERE UserType IN ('0', '1') AND UserName = '"
                        + txtUserName.Text + "' AND UserPassword = '" + txtPassword.Text + "'",
                        CommandType.Text).ToString());
                    userStating = int.Parse(dbm.ExecuteScalar(
                        "SELECT COUNT(Ref) FROM UserCard WHERE IsPassive = 'True' AND UserType IN ('0', '1') AND UserName = '"
                        + txtUserName.Text + "' AND UserPassword = '" + txtPassword.Text + "'",
                        CommandType.Text).ToString());
                    if (userExisting == 1)
                    {
                        if (userStating == 1)
                        {
                            res = DialogResult.OK;
                            this.Hide();

                        }
                        else
                        {
                            XtraMessageBox.Show("Kullanıcı Pasif Durumda Lütfen Yöneticiniz İle İrtibata Geçiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Lütfen Kullanıcı Adı Veya Şifrenizi Kontrol Ediniz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Lütfen Tüm Alanları doldurunuz");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("", ex.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Çıkmak İstediğinize Emin Misiniz ? ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

       
    }
}