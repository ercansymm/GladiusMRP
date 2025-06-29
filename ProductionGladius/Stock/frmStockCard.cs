using DevExpress.Office.Utils;
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
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace ProductionGladius.Stock
{
    public partial class frmStockCard : DevExpress.XtraEditors.XtraForm
    {
        public frmStockCard()
        {
            InitializeComponent();
        }

        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        Stocks myStocks = new Stocks();
        public Guid Ref;
        byte[] myImage = new byte[] { };
        public GladiusEnum.enmFormMod ScreenEnum = new GladiusEnum.enmFormMod();
        BaseList mylist = new BaseList();
        StockBarcode myBarcode = new StockBarcode();

        string Code;

        bool SaveControl()
        {
            StringBuilder stb = new StringBuilder();

            if (txtStockName.Text.Length == 0 || txtStockName.Text == null)
                stb.AppendLine("Ürün Adını Boş Geçemezsiniz.");


            if (ledCategory.Text.Length == 0 || ledCategory.EditValue == null)
                stb.AppendLine(" Ürün Tipini Boş Geçemezsiniz.");

            if (ledUnit.Text.Length == 0 || ledUnit.EditValue == null)
                stb.AppendLine(" Birimi Boş Geçemezsiniz.");

            if (ledCardType.Text.Length == 0 || ledCardType.EditValue == null)
                stb.AppendLine(" Genel Kategoriyi Boş Geçemezsiniz.");

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
        void filled()
        {
            DataTable unitDataTable = dbm.ExecuteDataTable("Select Ref,CardName from UnitCard", CommandType.Text);
            DataTable categoryTable = dbm.ExecuteDataTable("Select Ref, CardName From Categorys", CommandType.Text);

            ledCardType.Properties.DataSource = mylist.CardType();
            ledCardType.Properties.DropDownRows = mylist.CardType().Count();

            ledCategory.Properties.DataSource = categoryTable;
            ledCategory.Properties.DropDownRows = categoryTable.Rows.Count;
            ledUnit.Properties.DataSource = unitDataTable;
            ledUnit.Properties.DropDownRows = unitDataTable.Rows.Count;
            LedSubCategory.Properties.DataSource = null;
        }
        void fillForm()
        {
            txtNo.Text = myStocks.StockCode;
            txtStockName.Text = myStocks.CardName;
            ledUnit.EditValue = myStocks.UnitRef;
            ledCategory.EditValue = myStocks.CategoryRef;
            LedSubCategory.EditValue = myStocks.SubCategoryRef;
            rchDec.Text = myStocks.Description;
            tglActive.EditValue = myStocks.IsPassive;
            ledCardType.EditValue = myStocks.CardType;
            txtBarcode.Text = myStocks.Barcode;

            if (myStocks.Image != null && myStocks.Image.Length > 0)
            {
                MemoryStream ms = new MemoryStream(myStocks.Image);
                peImage.Image = Image.FromStream(ms);
                myImage = myStocks.Image;
            }
        }
        private void frmStockCard_Load(object sender, EventArgs e)
        {
            filled();

            switch (ScreenEnum)
            {
                case GladiusEnum.enmFormMod.NEW:
                    myStocks = new Stocks();
                    btnClose.Visible = false;
                    btnClose.Enabled = false;

                    break;
                case GladiusEnum.enmFormMod.UPDATE:

                    myStocks = myStocks.GetStocks(Ref);
                    btnClose.Visible = false;
                    btnClose.Enabled = false;

                    fillForm();

                    break;
                case GladiusEnum.enmFormMod.VIEW:

                    myStocks = myStocks.GetStocks(Ref);
                    btnClose.Visible = true;
                    btnClose.Enabled = true;
                    btnSave.Visible = true;
                    btnSave.Enabled = true;
                    txtStockName.Enabled = false;
                    rchDec.Enabled = false;
                    ledCategory.Enabled = false;
                    ledUnit.Enabled = false;
                    tglActive.Enabled = false;
                    lnk.Enabled = false;
                    lnk.Visible = false;
                    btnSave.Enabled = false;
                    btnSave.Visible = false;
                    btnClose.Location = btnSave.Location;
                    lnk.Visible=false;
                    LedSubCategory.Enabled = false;
                    txtBarcode.Enabled = false;
                    ledCardType.Enabled=false;
                    fillForm();
                    break;
                default:
                    break;
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

                    myStocks.Image = System.IO.File.ReadAllBytes(fi.FullName);

                    using (var ms = new MemoryStream(myStocks.Image))
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


        private void ledCategory_EditValueChanged(object sender, EventArgs e)
        {

            DataTable subCategoryTable = dbm.ExecuteDataTable("Select Ref,CardName From SubCategorys Where CategoryRef = '" + Guid.Parse(ledCategory.EditValue.ToString()) + "'", CommandType.Text);

            LedSubCategory.Properties.DataSource = subCategoryTable;
            LedSubCategory.Properties.DropDownRows = subCategoryTable.Rows.Count;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveControl())
            {

                try
                {

                    mng = new ObjectManager(true, "erpConnStr");

                    myStocks.CardName = txtStockName.Text;
                    myStocks.CategoryRef = Guid.Parse(ledCategory.EditValue.ToString());
                    myStocks.SubCategoryRef = Guid.Parse(LedSubCategory.EditValue.ToString());
                    myStocks.UnitRef = Guid.Parse(ledUnit.EditValue.ToString());
                    myStocks.IsPassive = tglActive.IsOn;
                    myStocks.Description = rchDec.Text;
                    myStocks.Barcode = txtBarcode.Text;
                    myBarcode.StockRef = myStocks.Ref;
                    myBarcode.Barcode = myStocks.Barcode;
                    myStocks.CardType = int.Parse(ledCardType.EditValue.ToString());

                    if (ledCategory.EditValue != null)
                    {
                        if (LedSubCategory.EditValue == null)
                        {
                            XtraMessageBox.Show("Lütfen Bir Alt Kategori Seçiniz");

                        }

                    }

                    if (myStocks.Image != null && myStocks.Image.Length > 0)
                    {
                        MemoryStream ms = new MemoryStream(myStocks.Image);
                        peImage.Image = Image.FromStream(ms);
                        myImage = myStocks.Image;
                    }

                    int StockCode = int.Parse(dbm.ExecuteScalar("Select Count (StockCode) from Stock", CommandType.Text).ToString());
                    if (StockCode > 0)
                    {
                        // Mevcut en yüksek ClientNo değerini alıp bir artırıyoruz
                        Code = dbm.ExecuteScalar("select top 1 StockCode From Stock order by StockCode desc", CommandType.Text).ToString();
                        int nextStockCode = int.Parse(Code) + 1;
                        myStocks.StockCode = nextStockCode.ToString();
                    }
                    else
                    {
                        // Hiç kayıt yoksa ClientNo değerini 1 olarak başlatıyoruz
                        Code = "1";
                        myStocks.StockCode = Code;
                    }
                    mng.SaveObject<Stocks>(myStocks);
                    mng.Commit();
                    XtraMessageBox.Show("Ürün Kaydınız && Güncellemeniz Tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show("" + ex);
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}