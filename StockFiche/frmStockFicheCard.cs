using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionGladius.StockFiche
{
    public partial class frmStockFicheCard : DevExpress.XtraEditors.XtraForm
    {
        public frmStockFicheCard()
        {
            InitializeComponent();
        }

        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        StockFiches myFiche = new StockFiches();
        StockLiness myline = new StockLiness();
        public GladiusEnum.enmFormMod ScreenEnum = new GladiusEnum.enmFormMod();
        public Guid Ref;
        string code;
 

        public string createOrderNo(int year, string month, string firmCode)
        {
            string code = firmCode;
            string barcode = "";

            DbManager dbm = new DbManager(false, "erpConnStr");
            int lengthYear = (code.Length) + 1;
            int lengthMonth = (code.Length) + 5;

            int isOk = int.Parse(dbm.ExecuteScalar(String.Format(
       @"select count(LotNo) 
          from WorkOrderDetails 
          where LEFT(Lotno, {0}) = '{1}' 
          AND SUBSTRING(Lotno, {2}, 4) = '{3}' 
          AND SUBSTRING(Lotno, {4}, 2) = '{5}'",
       code.Length, code, lengthYear, year, lengthMonth, month), CommandType.Text).ToString());

            if (isOk > 0)
            {
                string value = dbm.ExecuteScalar(String.Format(
            @"select top 1 Lotno 
              from WorkOrderDetails 
              where LEFT(Lotno, {0}) = '{1}' 
              AND SUBSTRING(Lotno, {2}, 4) = '{3}' 
              AND SUBSTRING(Lotno, {4}, 2) = '{5}' 
              order by CAST(RIGHT(Lotno, 4) AS INT) desc",
            code.Length, code, lengthYear, year, lengthMonth, month), CommandType.Text).ToString();

                int lastValue = int.Parse(value.Substring(value.Length - 4, 4));

                lastValue++;

                string a = "00000" + lastValue.ToString();

                barcode = code + year.ToString() + month + a;
            }
            else
            {
                barcode = code + year.ToString() + month + "000001";
            }

            return barcode;
        }




        bool SaveControl()
        {
            StringBuilder stb = new StringBuilder();

            if (dateTime.Text.Length == 0 || dateTime.EditValue == null)
                stb.AppendLine(" Tarih'i Boş Geçemezsiniz.");

            if (dgwFiche.DataSource == null || grdFiche.RowCount == 0)
                stb.AppendLine(" Gridi'i Boş Geçemezsiniz.");


            if (stb.ToString().Length <= 0)
                return true;
            else

                XtraMessageBox.Show("Hata:" + stb.ToString(), "");
            return false;
        }
        void fillText()
        {
            txtReceiptNo.Text = myFiche.FicheNo.ToString(); ;
            dateTime.EditValue = myFiche.FicheDate;
            rchDescription.Text = myFiche.Description;
            if (myFiche.Doctype == 0)
            {
                tglActive.IsOn = true;
            }
            else
            {
                tglActive.IsOn = false;
            }
        }
        void fillRiled()
        {
            riledStock.DataSource = dbm.ExecuteDataTable("Select Ref StockRef,CardName From Stock ", CommandType.Text);
            riledUnitRef.DataSource = dbm.ExecuteDataTable("Select Ref UnitRef,CardName From UnitCard", CommandType.Text);

        }
        void fillform()
        {
            dgwFiche.DataSource = myFiche.Details;
        }


        private void frmStockFicheCard_Load(object sender, EventArgs e)
        {
            dateTime.DateTime = DateTime.Now;
            fillRiled();

            switch (ScreenEnum)
            {
                case GladiusEnum.enmFormMod.NEW:
                    myFiche = new StockFiches();

                    break;
                case GladiusEnum.enmFormMod.UPDATE:
                    myFiche = myFiche.getfiche(Ref);
                    fillText();
                    break;
                case GladiusEnum.enmFormMod.VIEW:
                    myFiche = myFiche.getfiche(Ref);
                    fillText();
                    tglActive.Enabled = false;
                    grdFiche.OptionsBehavior.Editable = false;
                    txtReceiptNo.Enabled = false;
                    dateTime.Enabled = false;
                    rchDescription.Enabled = false;
                    btnSave.Visible = false;
                    btnSave.Enabled = false;
                    btnClose.Enabled = true;
                    btnClose.Visible = true;
                    btnClose.Location = btnSave.Location;
                    this.FormBorderStyle = FormBorderStyle.None;
                    break;
                default:
                    break;
            }
            fillform();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgwFiche.DataSource is BindingList<StockFichedetailss> bindingList && bindingList.Count > 0)
            {
                mng = new ObjectManager(true, "erpConnStr");
                grdFiche.FocusedRowHandle = -1;
                if (SaveControl())
                {

                    try
                    {
                        myFiche.FicheDate = dateTime.DateTime;
                        myFiche.Description = rchDescription.Text;
                        myFiche.FicheDate = myline.Date_;

                        if (tglActive.IsOn == true)
                        {
                            myFiche.Doctype = 0;
                        }
                        else
                        {
                            myFiche.Doctype = 1;
                        }
                        if (txtReceiptNo.Text == "")
                        {
                            int FicheCode = int.Parse(dbm.ExecuteScalar("Select Count (FicheNo) from StockFiche ", CommandType.Text).ToString());
                            if (FicheCode > 0)
                            {
                                // Mevcut en yüksek ClientNo değerini alıp bir artırıyoruz
                                code = dbm.ExecuteScalar("select top 1 FicheNo From StockFiche order by CAST(FicheNo AS INT) desc", CommandType.Text).ToString();
                                int nextFicheCode = int.Parse(code) + 1;
                                myFiche.FicheNo = nextFicheCode;
                            }
                            else
                            {
                                // Hiç kayıt yoksa ClientNo değerini 1 olarak başlatıyoruz
                                int code = 1;
                                myFiche.FicheNo = code;
                            }
                        }
                        {

                            mng.SaveObject<StockFiches>(myFiche);




                            foreach (StockFichedetailss item in myFiche.Details)
                            {
                                StockLiness myline = new StockLiness(); 

                                if (tglActive.IsOn == true)
                                {
                                    item.LineIO = 0;
                                    myline.LinelIO = 0;
                                }
                                else
                                {
                                    myline.LinelIO = 1;
                                }

                                myline.StockRef = item.StockRef;
                                myline.UnitRef = item.UnitRef;
                                myline.Amount = item.Amount;
                                myline.FicheDetailsRef = item.Ref;
                                item.StockFishRef = myFiche.Ref;
                                myline.FicheRef = item.StockFishRef;

                                mng.SaveObject<StockFichedetailss>(item);
                                mng.SaveObject<StockLiness>(myline);
                            }


                            mng.Commit();
                            XtraMessageBox.Show("Fiş Kaydınız && Düzenlemeniz Başarıyla Sonuçlanmıştır");
                            this.Close();

                        }


                    }
                    catch (Exception ex)
                    {

                        XtraMessageBox.Show("Hata" + ex);
                    }


                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen Ürün Giriniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
      
    }
}
