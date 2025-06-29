using DevExpress.Data;
using DevExpress.XtraEditors;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.PRO;
using GladiusObjex.Provider;
using GladiusObjex.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionGladius.StockRecipt
{
    public partial class frmReceiptCard : DevExpress.XtraEditors.XtraForm
    {
        public frmReceiptCard()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        public GladiusEnum.enmFormMod ScreenEnum = new GladiusEnum.enmFormMod();
        StockReceipts myReceipt = new StockReceipts();
        public Guid Ref;

        string Code;

        bool SaveControl()
        {
            StringBuilder stb = new StringBuilder();

            if (txtCardName.Text.Length == 0 || txtCardName.Text == null)
                stb.AppendLine("Fiş Adını Boş Geçemezsiniz.");


            if (ledStock.Text.Length == 0 || ledStock.EditValue == null)
                stb.AppendLine(" Üst Ürünü Boş Geçemezsiniz.");

            if (grdRecipt.DataSource == null || grdRecipt.RowCount == 1)
                stb.AppendLine(" Fişi Boş Geçemezsiniz.");


            if (stb.ToString().Length <= 0)
                return true;
            else
                XtraMessageBox.Show("Hata:" + stb.ToString(), "");
            return false;
        }
        void fillLed()
        {
            riledStock.DataSource = dbm.ExecuteDataTable("Select Ref StockRef,CardName from Stock Where CardType = '2' ", CommandType.Text);
            riledUnitRef.DataSource = dbm.ExecuteDataTable("Select Ref UnitRef,CardName from UnitCard", CommandType.Text);
            ledStock.Properties.DataSource = dbm.ExecuteDataTable("Select * From Stock Where CardType IN  ('0','1') ", CommandType.Text);

        }
        void fillText()
        {
            txtCardName.Text = myReceipt.CardName;
            ledStock.EditValue = myReceipt.StockRef;
            rchDescription.Text = myReceipt.Description;
            tglActive.IsOn = myReceipt.IsPassive;
            txtReceiptNo.Text = myReceipt.ReciptNo;

        }
        void fillGrid()
        {
            dgwRecipt.DataSource = myReceipt.Details;
        }
        private void frnReceiptCard_Load(object sender, EventArgs e)
        {
            fillLed();
            switch (ScreenEnum)
            {
                case GladiusEnum.enmFormMod.NEW:
                    myReceipt = new StockReceipts();

                    break;
                case GladiusEnum.enmFormMod.UPDATE:
                    myReceipt = myReceipt.getFiche(Ref);
                    fillText();
                    break;
                case
                GladiusEnum.enmFormMod.VIEW:
                    myReceipt = myReceipt.getFiche(Ref);
                    fillText();
                    btnSave.Visible = false;
                    btnSave.Enabled = false;
                    btnClose.Visible = true;
                    txtCardName.Enabled = false;
                    txtReceiptNo.Enabled = false;
                    rchDescription.Enabled = false;
                    ledStock.Enabled = false;
                    tglActive.Enabled = false;
                    grdRecipt.OptionsBehavior.Editable = false;
                    btnClose.Location = btnSave.Location;
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.FormBorderEffect = FormBorderEffect.Shadow;
                    btnClose.Enabled=true;
                    break;

                default:
                    break;
            }

            fillGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdRecipt.FocusedRowHandle = -1;

            mng = new ObjectManager(true, "erpConnStr");

            if (dgwRecipt.DataSource != null )
            {


                if (SaveControl())
                {

                    try
                    {
                        myReceipt.StockRef = Guid.Parse(ledStock.EditValue.ToString());
                        myReceipt.CardName = txtCardName.Text;
                        myReceipt.Description = rchDescription.Text;
                        if (tglActive.IsOn == true)
                        {
                            myReceipt.IsPassive = true;

                        }
                        else
                        {

                            myReceipt.IsPassive = false;
                        }
                        if (txtReceiptNo.Text == "")
                        {
                            int ReciptCode = int.Parse(dbm.ExecuteScalar("Select Count (ReciptNo) from StockReceipt ", CommandType.Text).ToString());
                            if (ReciptCode > 0)
                            {
                                // Mevcut en yüksek ClientNo değerini alıp bir artırıyoruz
                                Code = dbm.ExecuteScalar("select top 1 ReciptNo From StockReceipt order by ReciptNo desc", CommandType.Text).ToString();
                                int nextStockCode = int.Parse(Code) + 1;
                                myReceipt.ReciptNo = nextStockCode.ToString();
                            }
                            else
                            {
                                // Hiç kayıt yoksa ClientNo değerini 1 olarak başlatıyoruz
                                Code = "1";
                                myReceipt.ReciptNo = Code;
                            }
                        }

                        mng.SaveObject<StockReceipts>(myReceipt);

                        foreach (StockReceiptsDetail item in myReceipt.Details)
                        {
                            item.LineIO = 0;
                            item.ReciptRef = myReceipt.Ref;
                            item.CardName = myReceipt.CardName;
                            mng.SaveObject<StockReceiptsDetail>(item);
                        }
                        mng.Commit();
                        XtraMessageBox.Show("Reçete Kaydınız && Düzenlemeniz Başarıyla Sonuçlanmıştır");
                        this.Close();



                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Hata" + ex);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Lütfen Önce Ürün Seçin");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tglActive_Toggled(object sender, EventArgs e)
        {

        }
    }
}