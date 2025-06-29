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

namespace ProductionGladius.Clinet
{
    public partial class frmClinetCard : DevExpress.XtraEditors.XtraForm
    {
        public frmClinetCard()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        Clinets myClinets = new Clinets();
        public Guid Ref;
        public GladiusEnum.enmFormMod ScreenEnum = new GladiusEnum.enmFormMod();
        string ClinetCode;
        byte[] myImage = new byte[] { };

        bool SaveControl()
        {
            StringBuilder stb = new StringBuilder();

            if (txtClinetCardName.Text.Length == 0 || txtClinetCardName.Text == null)
                stb.AppendLine("Adı Boş Geçemezsiniz.");


            if (txtClinetTaxNumber.Text.Length == 0 || txtClinetTaxNumber.Text == null)
                stb.AppendLine("Vergi Numarasını Boş Geçemezsiniz.");


            if (txtTaxOffice.Text.Length == 0 || txtTaxOffice.Text == null)
                stb.AppendLine("Vegi Dairesini Boş Geçemezsiniz.");



            if (rchAddres.Text.Length == 0 || rchAddres.Text == null)
                stb.AppendLine("Adresi Boş Geçemezsiniz.");

            if (txtClinetPhone.Text.Length == 0 || txtClinetPhone.Text == null)
                stb.AppendLine("Telefon Numarasını Geçemezsiniz.");


            if (stb.ToString().Length <= 0)
                return true;
            else
                XtraMessageBox.Show("Hata:" + stb.ToString(), "");
            return false;
        }

        void fillForm()
        {
            txtClinetNo.Text = myClinets.ClinetNo.ToString();
            txtClinetCardName.Text = myClinets.CardName;
            txtClinetEmail.Text = myClinets.ClinetEmail;
            txtTaxOffice.Text = myClinets.Taxoffice;
            txtClinetTaxNumber.Text = myClinets.TaxNumber.ToString();
            rchDecription.Text = myClinets.Description;
            txtClinetPhone.Text = myClinets.ClinetPhone.ToString();
            txtClinetPhone2.Text = myClinets.ClinetPhone2.ToString();
            txtClinetPhone3.Text = myClinets.ClinetPhone3.ToString();
            rchAddres.Text = myClinets.ClinetAddres.ToString();
            

            if (myClinets.Image != null && myClinets.Image.Length > 0)
            {
                MemoryStream ms = new MemoryStream(myClinets.Image);
                peImage.Image = Image.FromStream(ms);
                myImage = myClinets.Image;
            }

            if (myClinets.IsPassive == true)
            {
                tglActive.Enabled = true;
            }

            else
            {
                tglActive.Enabled = false;
            }



        }
        private void ClinetCard_Load(object sender, EventArgs e)
        {
            txtClinetPhone.Properties.MaxLength = 11;
            txtClinetPhone2.Properties.MaxLength = 11;
            txtClinetPhone3.Properties.MaxLength = 11;

            switch (ScreenEnum)
            {
                case GladiusEnum.enmFormMod.NEW:
                    myClinets = new Clinets();
                    btnClose.Enabled = false;
                    btnClose.Visible = false;
                    break;
                case GladiusEnum.enmFormMod.UPDATE:

                    myClinets = myClinets.GetClinets(Ref);
                    btnClose.Enabled = false;
                    btnClose.Visible = false;
                    fillForm();
                    break;
                case GladiusEnum.enmFormMod.VIEW:
                    myClinets = myClinets.GetClinets(Ref);
                    btnSave.Enabled = false;
                    btnSave.Visible = false;
                    rchAddres.Enabled = false;
                    rchDecription.Enabled = false;
                    tglActive.Enabled = false;
                    txtClinetCardName.Enabled = false;
                    txtClinetEmail.Enabled = false;
                    txtTaxOffice.Enabled = false;
                    txtClinetTaxNumber.Enabled = false;
                    txtClinetPhone.Enabled = false;
                    txtClinetPhone2.Enabled = false;
                    txtClinetPhone3.Enabled = false;
                    lnk.Enabled = false;
                    lnk.Visible = false;
                    btnClose.Enabled = true;
                    btnClose.Visible = true;
                    btnClose.Location=btnSave.Location;

                    this.FormBorderStyle = FormBorderStyle.None;
                    this.FormBorderEffect = FormBorderEffect.Shadow;
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
                    ObjectManager mng = new ObjectManager(true, "erpConnStr");

                    myClinets.CardName = txtClinetCardName.Text;
                    myClinets.ClinetPhone = int.Parse(txtClinetPhone.Text);
                    myClinets.ClinetPhone2 = int.Parse(txtClinetPhone2.Text);
                    myClinets.ClinetPhone3 = int.Parse(txtClinetPhone3.Text);
                    myClinets.Taxoffice = txtTaxOffice.Text;
                    myClinets.TaxNumber = int.Parse(txtClinetTaxNumber.Text);
                    myClinets.ClinetAddres = rchAddres.Text;
                    myClinets.Description = rchDecription.Text;
                    myClinets.ClinetEmail = txtClinetEmail.Text;

                    if (myClinets.Image != null && myClinets.Image.Length > 0)
                    {
                        MemoryStream ms = new MemoryStream(myClinets.Image);
                        peImage.Image = Image.FromStream(ms);
                        myImage = myClinets.Image;
                    }


                    if (tglActive.IsOn == true)
                    {
                        myClinets.IsPassive = true;
                    }
                    else
                    {
                        myClinets.IsPassive = false;
                    }

                    if (myClinets.ClinetNo > 0)
                    {
                        myClinets.ClinetNo = myClinets.ClinetNo;
                    }
                    else
                    {
                        // Yeni kayıt için işlem yap
                        int Code = int.Parse(dbm.ExecuteScalar("Select Count(Clinet.ClinetNo) from Clinet", CommandType.Text).ToString());

                        if (Code > 0)
                        {
                            // Mevcut en yüksek ClientNo değerini alıp bir artırıyoruz
                            ClinetCode = dbm.ExecuteScalar("select top 1 ClinetNo From Clinet order by ClinetNo desc", CommandType.Text).ToString();
                            int Nextcode = int.Parse(ClinetCode) + 1;
                            myClinets.ClinetNo = Nextcode;
                        }
                        else
                        {
                            // Hiç kayıt yoksa ClientNo değerini 1 olarak başlatıyoruz
                            ClinetCode = "1";
                            myClinets.ClinetNo = int.Parse(ClinetCode);
                        }
                    }


                    mng.SaveObject<Clinets>(myClinets);
                    mng.Commit();
                    XtraMessageBox.Show("Cari Kaydınız && Güncellemeniz Tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

                    myClinets.Image = System.IO.File.ReadAllBytes(fi.FullName);

                    using (var ms = new MemoryStream(myClinets.Image))
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

 
        private void txtClinetPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtClinetPhone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtClinetPhone3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmClinetCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtClinetTaxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}