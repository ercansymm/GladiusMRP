using DevExpress.XtraEditors;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.PRO;
using GladiusObjex.Provider;
using GladiusObjex.Tool;
using ProductionGladius.SpecialClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionGladius.users
{
    public partial class frmUserCard : DevExpress.XtraEditors.XtraForm
    {
        public frmUserCard()
        {
            InitializeComponent();
        }

        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        UserCard myUser = new UserCard();
        public Guid Ref;
        byte[] myImage = new byte[] { };
        public GladiusEnum.enmFormMod ScreenEnum = new GladiusEnum.enmFormMod();
        BaseList mylist = new BaseList();


        string UserCode;


        bool SaveControl()
        {
            StringBuilder stb = new StringBuilder();

            if (txtName.Text.Length == 0 || txtName.Text == null)
                stb.AppendLine("Ad'ı Boş Geçemezsiniz.");


            if (txtLastName.Text.Length == 0 || txtLastName.Text == null)
                stb.AppendLine(" Soyad'ı Boş Geçemezsiniz.");

            if (txtUserName.Text.Length == 0 || txtUserName.Text == null)
                stb.AppendLine(" Kullanıcı Adını Boş Geçemezsiniz.");

            if (txtUserPassword.Text.Length == 0 || txtUserPassword.Text == null)
                stb.AppendLine(" Kullanıcı Şifresini Boş Geçemezsiniz.");

            if (txtUserPassword.Text.Length == 0 || txtUserPassword.Text == null)
                stb.AppendLine(" Kullanıcı Şifresini Boş Geçemezsiniz.");

            if (txtUserNumber.Text.Length == 0 || txtUserNumber.Text == null)
                stb.AppendLine(" Kullanıcı Telefon Numarası'nı Boş Geçemezsiniz.");

            if (ledStatus.Text.Length == 0 || ledStatus.EditValue == null)
                stb.AppendLine(" Kullanıcı Tipini Boş Geçemezsiniz.");

            if (peImage.Image == null)
            {
                stb.AppendLine(" Resmini Boş Geçemezsiniz.");
            }

            if (stb.ToString().Length <= 0)
                return true;
            else
                XtraMessageBox.Show("Hata:" + stb.ToString(), "");
            return false;
        }

        void fillForm()
        {
            txtName.Text = myUser.Name;
            txtLastName.Text = myUser.LastName;
            txtUserName.Text = myUser.UserName;
            txtUserPassword.Text = myUser.UserPassword;
            txtUserNumber.Text = myUser.UserPhone.ToString();
            txtPhoneNumber2.Text = myUser.UserPhone2.ToString();
            ledStatus.EditValue = myUser.UserType;
            tglPassive.EditValue = myUser.IsPassive;


            if (myUser.Image != null && myUser.Image.Length > 0)
            {
                MemoryStream ms = new MemoryStream(myUser.Image);
                peImage.Image = Image.FromStream(ms);
                myImage = myUser.Image;
            }
        }



        private void frmUserCard_Load(object sender, EventArgs e)
        {
            txtPhoneNumber2.Properties.MaxLength = 11;
            txtUserNumber.Properties.MaxLength = 11;
            ledStatus.Properties.DataSource = mylist.UserType();
            ledStatus.Properties.DropDownRows = mylist.UserType().Count;
            ledStatus.Text = null;
            ledStatus.EditValue = null;


            switch (ScreenEnum)
            {
                case GladiusEnum.enmFormMod.NEW:
                    myUser = new UserCard();
                    btnClose.Enabled = false;
                    btnClose.Visible = false;
                    break;
                case GladiusEnum.enmFormMod.UPDATE:

                    myUser = myUser.getuser(Ref);
                    btnClose.Enabled = false;
                    btnClose.Visible = false;
                    fillForm();

                    break;

                case GladiusEnum.enmFormMod.VIEW:

                    myUser = myUser.getuser(Ref);
                    txtName.Enabled = false;
                    txtLastName.Enabled = false;
                    txtUserName.Enabled = false;
                    txtUserPassword.Enabled = false;
                    txtUserNumber.Enabled = false;
                    txtPhoneNumber2.Enabled = false;
                    tglPassive.Enabled = false;
                    ledStatus.Enabled = false;
                    btnClose.Enabled = true;
                    lnk.Visible = false;
                    btnClose.Visible = true;
                    btnSave.Visible = false;
                    btnClose.Location = btnSave.Location;
                    this.FormBorderStyle = FormBorderStyle.None;
                    fillForm();
                    break;


                default:

                    break;


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveControl())
            {
                try
                {

                    mng = new ObjectManager(true, "erpConnStr");

                    myUser.Name = txtName.Text;
                    myUser.LastName = txtLastName.Text;
                    myUser.UserPhone = txtUserNumber.Text;
                    myUser.UserPhone2 = txtPhoneNumber2.Text;
                    myUser.UserName = txtUserName.Text;
                    myUser.Image = myImage;
                    myUser.UserPassword = txtUserPassword.Text;
                    myUser.UserType = int.Parse(ledStatus.EditValue.ToString());




                    if (tglPassive.IsOn == true)
                    {
                        myUser.IsPassive = true;

                    }
                    else
                    {
                        myUser.IsPassive = false;
                    }
                    if (myUser.Image != null && myUser.Image.Length > 0)
                    {
                        MemoryStream ms = new MemoryStream(myUser.Image);
                        peImage.Image = Image.FromStream(ms);
                        myImage = myUser.Image;
                    }
                    int UserCount = int.Parse(dbm.ExecuteScalar("Select Count(UserNo) from UserCard", CommandType.Text).ToString());
                    if (UserCount > 0)
                    {
                        // Mevcut en yüksek ClientNo değerini alıp bir artırıyoruz
                        UserCode = dbm.ExecuteScalar("select top 1 UserNo From UserCard order by UserNo desc", CommandType.Text).ToString();
                        int nextUserNo = int.Parse(UserCode) + 1;
                        myUser.UserNo = nextUserNo;
                    }
                    else
                    {
                        // Hiç kayıt yoksa ClientNo değerini 1 olarak başlatıyoruz
                        UserCode = "1";
                        myUser.UserNo = int.Parse(UserCode);
                    }

                    mng.SaveObject<UserCard>(myUser);
                    mng.Commit();
                    XtraMessageBox.Show("Kişi Kaydınız && Güncellemeniz Tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("burası çalışıyor" + ex + "");

                }
            }


        }

        private void lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files(.jpg; *.jpeg; *.gif; *.bmp)|.png;*.jpg; *.jpeg; *.gif; *.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);

                    myUser.Image = System.IO.File.ReadAllBytes(fi.FullName);

                    using (var ms = new MemoryStream(myUser.Image))
                    {
                        peImage.Image = Image.FromStream(ms);
                        myImage = System.IO.File.ReadAllBytes(fi.FullName);
                    }
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("" + ex, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtUserNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void txtUserNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
