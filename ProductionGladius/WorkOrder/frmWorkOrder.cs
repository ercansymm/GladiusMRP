using DevExpress.CodeParser;
using DevExpress.Data;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraScheduler.Native;
using DevExpress.XtraSpreadsheet.Import.Xls;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.PRO;
using GladiusObjex.Provider;
using GladiusObjex.Tool;
using ProductionGladius.SpecialClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.BunifuCheckBox.Transitions;

namespace ProductionGladius.WorkOrder
{
    public partial class frmWorkOrder : DevExpress.XtraEditors.XtraForm
    {
        public frmWorkOrder()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        WorkOrders myOrder = new WorkOrders();
        StockReceipts myRecipt = new StockReceipts();
        StockFiches myfiches = new StockFiches();
        Stocks myStok = new Stocks();
        StockLiness myline = new StockLiness();
        public Guid Ref;
        string code;
        int parsedAmount;
        BaseList mylist = new BaseList();
        public GladiusEnum.enmFormMod ScreenEnum = new GladiusEnum.enmFormMod();
        string ShortCode;


        bool SaveControl()
        {
            StringBuilder stb = new StringBuilder();

            if (txtAmount.Text.Length == 0 || txtAmount.Text == null)
                stb.AppendLine("Miktarı Boş Geçemezsiniz.");


            if (ledStock.Text.Length == 0 || ledStock.EditValue == null)
                stb.AppendLine(" Üst Ürünü Boş Geçemezsiniz.");

            if (grdWork.DataSource == null)
                stb.AppendLine(" Ürünleri Boş Geçemezsiniz.");

            if (ledReceipt.EditValue == null)
                stb.AppendLine(" Stok Fişini Boş Geçemezsiniz.");


            if (LedUnit.Text == "" || LedUnit.EditValue == null)

                stb.AppendLine("Birimi Boş Geçemezsiniz");

            if (dateTime.Text == "" || dateTime.EditValue == null)

                stb.AppendLine("Tarihi Boş Geçemezsiniz");

            if (dateTime.DateTime.Date < DateTime.Now.Date)

                stb.AppendLine("Lütfen Tarihi Kontrol Ediniz");


            if (stb.ToString().Length <= 0)
                return true;
            else
                XtraMessageBox.Show("Hata:" + stb.ToString(), "");
            return false;
        }

        void filamount()
        {
            mng = new ObjectManager(true, "erpConnStr");

            if (int.TryParse(txtAmount.Text, out parsedAmount) && parsedAmount > 0)
            {
                myOrder.Details.Clear();


                foreach (StockReceiptsDetail item in myRecipt.Details)
                {
                    WorkOrderDetails workOrderDetailss = new WorkOrderDetails
                    {

                        Amount = parsedAmount * item.Amount,
                        UnitRef = item.UnitRef,
                        StockRef = item.StockRef,
                        WorkRef = myOrder.Ref,

                    };

                    myOrder.Details.Add(workOrderDetailss);
                }



                dgwWork.DataSource = myOrder.Details;
            }
            else
            {
                XtraMessageBox.Show("Lütfen geçerli bir üretilecek miktar giriniz.");
            }


        }

        void filLed()
        {
            int isOk = int.Parse(dbm.ExecuteScalar("select count(WorkOrderNo) from WorkOrder where WorkOrderNo = '" + txtWorckNo.Text + "'", CommandType.Text).ToString());

            int reciptcount = 1;
            int stockvalue = int.Parse(dbm.ExecuteScalar("Select Count(Stock.Ref) from Stock Where CardType IN (0,1) ", CommandType.Text).ToString());
            int clinetValue = int.Parse(dbm.ExecuteScalar("Select Count(Clinet.Ref) From Clinet", CommandType.Text).ToString());
            int unitValue = int.Parse(dbm.ExecuteScalar("Select Count(UnitCard.Ref) From UnitCard", CommandType.Text).ToString());



            ledStock.Properties.DataSource = dbm.ExecuteDataTable("Select Ref ,CardName from Stock Where CardType IN (0,1) AND IsPassive ='True'   ", CommandType.Text);
            ledStock.Properties.DropDownRows = int.Parse(stockvalue.ToString());




            LedUnit.Properties.DataSource = dbm.ExecuteDataTable("Select Ref ,CardName From UnitCard", CommandType.Text);
            LedUnit.Properties.DropDownRows = int.Parse(unitValue.ToString());


            ledReceipt.Properties.DropDownRows = int.Parse(reciptcount.ToString());

        }
        void fillRiled()
        {
            riledStock.DataSource = dbm.ExecuteDataTable("Select Ref StockRef,CardName from Stock", CommandType.Text);
            riledUnitRef.DataSource = dbm.ExecuteDataTable("Select Ref UnitRef,CardName from UnitCard", CommandType.Text);
        }

        void filGrid()
        {
            mng = new ObjectManager(true, "erpConnStr");

            myOrder.Details.Clear();

            if (txtAmount.Text == "")
            {
                if (ledReceipt.EditValue != null)
                {
                    myRecipt = myRecipt.getFiche(Guid.Parse(ledReceipt.EditValue.ToString()));

                    foreach (StockReceiptsDetail item in myRecipt.Details)
                    {
                        WorkOrderDetails workOrderDetailss = new WorkOrderDetails
                        {

                            Amount = item.Amount,
                            UnitRef = item.UnitRef,
                            StockRef = item.StockRef,
                            WorkRef = myOrder.Ref
                        };


                        myOrder.Details.Add(workOrderDetailss);
                    }

                    dgwWork.DataSource = myOrder.Details;
                }
            }
            else
            {
                if (ledReceipt.EditValue != null)
                {
                    myRecipt = myRecipt.getFiche(Guid.Parse(ledReceipt.EditValue.ToString()));

                    foreach (StockReceiptsDetail item in myRecipt.Details)
                    {
                        WorkOrderDetails workOrderDetailss = new WorkOrderDetails
                        {

                            Amount = item.Amount * parsedAmount,     // int.Parse(txtAmount.Text),
                            UnitRef = item.UnitRef,
                            StockRef = item.StockRef,
                            WorkRef = myOrder.Ref
                        };


                        myOrder.Details.Add(workOrderDetailss);
                    }

                    dgwWork.DataSource = myOrder.Details;
                }

            }

        }


        void fillText()
        {
            ledStock.EditValue = myOrder.StockRef;
            ledReceipt.EditValue = myOrder.StockReceiptRef;
            txtAmount.Text = myOrder.ParsedAmount.ToString();
            LedUnit.EditValue = myOrder.UnitRef;
            dateTime.EditValue = myOrder.StartDate;
            txtWorckNo.Text = myOrder.WorkOrderNo.ToString();
            rchDescription.Text = myOrder.Description;

        }
        void fillot()
        {

            int isOk = int.Parse(dbm.ExecuteScalar("select count(WorkOrderNo) from WorkOrder where WorkOrderNo = '" + txtWorckNo.Text + "'", CommandType.Text).ToString());

            if (isOk > 0)
            {
                txtWorckNo.Text = myOrder.WorkOrderNo;

            }
            else
            {

                string myMounth = "00" + DateTime.Now.Month.ToString();
                string myDay = "00" + DateTime.Now.Day.ToString();

                myOrder.WorkOrderNo = mylist.createOrderNo(DateTime.Now.Year, myMounth.Substring(myMounth.Length - 2, 2), "LTNO");
                txtWorckNo.Text = myOrder.WorkOrderNo;
            }


        }

        private void frmWorkOrder_Load(object sender, EventArgs e)
        {
            dateTime.DateTime = DateTime.Now;


            filLed();
            fillRiled();
            switch (ScreenEnum)
            {
                case GladiusEnum.enmFormMod.NEW:
                    btnPrint.Visible = false;
                    btnClose.Location = btnPrint.Location;
                    myOrder = new WorkOrders();

                    string myMounth = "00" + DateTime.Now.Month.ToString();
                    string myDay = "00" + DateTime.Now.Day.ToString();

                    txtWorckNo.Text = mylist.createOrderNo(DateTime.Now.Year, myMounth.Substring(myMounth.Length - 2, 2), "LTNO");
                    ShortCode = (Convert.ToInt64(mylist.GetShortCode(DateTime.Today)) - 1).ToString();
                    break;

                case GladiusEnum.enmFormMod.UPDATE:
                    myOrder = myOrder.getWork(Ref);
                    fillText();
                    filGrid();
                    btnPrint.Visible = true;
                    fillot();
                    break;
                case
                GladiusEnum.enmFormMod.VIEW:

                    myOrder = myOrder.getWork(Ref);
                    fillText();
                    filGrid();
                    filamount();

                    ledStock.Enabled = false;
                    btnPrint.Visible = true;
                    ledReceipt.Enabled = false;
                    LedUnit.Enabled = false;
                    rchDescription.Enabled = false;
                    dateTime.Enabled = false;
                    txtWorckNo.Enabled = false;
                    txtAmount.Enabled = false;
                    btnSave.Enabled = false;
                    grdWork.OptionsBehavior.Editable = false;
                    btnSave.Visible = false;
                    btnClose.Location = new Point(199, 7);
                    btnPrint.Location = btnSave.Location;
                    this.FormBorderStyle = FormBorderStyle.None;
                    break;
                default:
                    break;
            }

        }


        private void ledStock_EditValueChanged(object sender, EventArgs e)
        {


            if (ledStock.EditValue != null)
            {
                ledReceipt.Properties.DataSource = dbm.ExecuteDataTable("Select Ref,CardName from StockReceipt WHERE StockRef ='" + Guid.Parse(ledStock.EditValue.ToString()) + "' ", CommandType.Text);
            }

            if (dgwWork.DataSource != null)
            {
                dgwWork.DataSource = null;
            }

        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            mng = new ObjectManager(true, "erpConnStr");
            if (SaveControl())
            {
                try
                {
                    myOrder.StockRef = Guid.Parse(ledStock.EditValue.ToString());
                    myOrder.UnitRef = Guid.Parse(LedUnit.EditValue.ToString());
                    myOrder.StockReceiptRef = Guid.Parse(ledReceipt.EditValue.ToString());
                    myOrder.StartDate = dateTime.DateTime;
                    myOrder.Status = 0;
                    myOrder.ParsedAmount = int.Parse(txtAmount.Text);
                    myOrder.StockReceiptRef = Guid.Parse(ledReceipt.EditValue.ToString());
                    myOrder.WorkOrderNo = txtWorckNo.Text;
                    myOrder.Description = rchDescription.Text;

                    mng.SaveObject<WorkOrders>(myOrder);


                    foreach (WorkOrderDetails item in myOrder.Details)
                    {
                        item.WorkRef = myOrder.Ref;
                        mng.SaveObject<WorkOrderDetails>(item);
                    }

                    parsedAmount = int.Parse(txtAmount.Text);


                    if (ScreenEnum == GladiusEnum.enmFormMod.NEW)
                    {
                        string shortCode = mylist.GetShortCode(DateTime.Today);
                        for (int i = 0; i < parsedAmount; i++)
                        {
                            string newBarcode = shortCode.Substring(0, 6) + (int.Parse(shortCode.Substring(6)) + i).ToString("D4");

                            WorkPrint orderPrints = new WorkPrint
                            {
                                WorkOrderRef = myOrder.Ref,
                                StockRef = myOrder.StockRef,
                                Barcode = newBarcode,
                                Amount = 1,
                                Status = 0,
                                UnitRef = myOrder.UnitRef,
                                WorkOrderNo = myOrder.WorkOrderNo,

                            };

                            mng.SaveObject<WorkPrint>(orderPrints);
                        }
                    }
                    else
                    {
                        if (myOrder.Print.Count < parsedAmount)
                        {
                            int amountValue = parsedAmount - myOrder.Print.Count;

                            string shortCode = mylist.GetShortCode(DateTime.Today);

                            for (int i = 0; i < amountValue; i++)
                            {
                                string newBarcode = shortCode.Substring(0, 6) + (int.Parse(shortCode.Substring(6)) + i).ToString("D4");

                                WorkPrint orderPrints = new WorkPrint
                                {
                                    WorkOrderRef = myOrder.Ref,
                                    StockRef = myOrder.StockRef,
                                    Barcode = newBarcode,
                                    Amount = 1,
                                    Status = 0,
                                    UnitRef = myOrder.UnitRef,
                                    WorkOrderNo = myOrder.WorkOrderNo,

                                };

                                mng.SaveObject<WorkPrint>(orderPrints);
                            }
                        }
                        else if (myOrder.Print.Count > parsedAmount)
                        {
                            int amountValue = myOrder.Print.Count - parsedAmount;

                            var excessPrints = myOrder.Print
                                .OrderByDescending(p => p.Ref)
                                .Take(amountValue)
                                .ToList();

                            foreach (var print in excessPrints)
                            {
                                mng.DeleteObject<WorkPrint>(print.Ref);
                            }
                        }
                    }

                    mng.Commit();
                    XtraMessageBox.Show("Kaydınız Tamamlanmıştır.");
                    btnPrint_Click(null, null);
                    this.Close();


                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show("hata" + ex);
                }


                foreach (WorkOrderDetails item in myOrder.Details)
                {

                    List<string> missingProducts = new List<string>();

                    double value = Convert.ToDouble(dbm.ExecuteScalar(
                        "SELECT SUM(CASE SL.LinelIO WHEN 0 THEN SL.Amount ELSE SL.Amount * -1 END) AS Amount " +
                        "FROM StockLines SL " +
                        "INNER JOIN Stock SC ON SC.Ref = SL.StockRef " +
                        "WHERE SL.StockRef = '" + item.StockRef + "' " +
                        "GROUP BY SC.CardName",
                        CommandType.Text
                    ));


                    if (value < item.Amount)
                    {
                        double missingAmount = item.Amount - value;

                        string cardName = Convert.ToString(dbm.ExecuteScalar(
                            "SELECT CardName FROM Stock WHERE Ref = '" + item.StockRef + "'",
                            CommandType.Text
                        ));

                        string productInfo = $"Ürün: {cardName}, Eksik Miktar: {missingAmount}";
                        missingProducts.Add(productInfo);
                    }

                    if (missingProducts.Count > 0)
                    {
                        string message = string.Join(Environment.NewLine, missingProducts);
                        MessageBox.Show("Eksik Ürünler:\n" + message, "Eksik Stok Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
        }


        private void ledReceipt_EditValueChanged(object sender, EventArgs e)
        {
            filGrid();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmount_EditValueChanged(object sender, EventArgs e)
        {
            filamount();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            XtraReport Rep = new XtraReport();

            Rep.LoadLayout(Application.StartupPath + @"\Reports\TeklifTurkdce.repx");
            DataSet Ds = new DataSet();
            DataTable dtBarcodef = dbm.ExecuteDataTable(@"select SC.CardName UrunAdi, SU.CardName Birim,WRK.ParsedAmount Miktar,WRK.WorkOrderNO LotNO,WRK.StartDate Date_,
                                         WRK.Description des,RC.CardName Recipts
                                         from WorkOrder WRK
                                         left join Stock SC ON SC.Ref = WRK.StockRef
                                         left join UnitCard SU ON SU.Ref = WRK.UnitRef
                                         left join StockReceipt RC ON RC.Ref = WRK.StockReceiptRef
                                         where WRK.Ref  =  '" + myOrder.Ref + "' ", CommandType.Text);




            DataTable dataTable = dbm.ExecuteDataTable(@"SELECT SC.CardName AS Ürün, WP.Barcode, WP.Amount AS Miktar, UNT.CardName AS unit " +
               "FROM WorkPrint WP " +
               "LEFT JOIN Stock SC ON SC.Ref = WP.StockRef " +
               "LEFT JOIN UnitCard UNT ON UNT.Ref = WP.UnitRef " +
               "LEFT JOIN WorkOrder ORD ON ORD.ParsedAmount = WP.Amount " +
               "WHERE WP.WorkOrderRef = '" + myOrder.Ref + "' " +
               "GROUP BY SC.CardName, WP.Barcode, WP.Amount, UNT.CardName;", CommandType.Text);

            DataTable dtProdBarcode = dtBarcodef.Copy();
            dtProdBarcode.TableName = "WorkOrder";
            Ds.Tables.Add(dtProdBarcode);

            DataTable dataSoruce = dataTable.Copy();
            dataSoruce.TableName = "WorkPrint";
            Ds.Tables.Add(dataSoruce);


            Rep.DataSource = Ds;
            Rep.DataMember = "WorkPrint";
            Rep.Print();

            //Rep.ShowDesigner();
            XtraMessageBox.Show("İş Emirleri Yazdırılıyor...", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }



        private void dateTime_Leave(object sender, EventArgs e)
        {
            if (dateTime.DateTime.Date < DateTime.Now.Date)
            {
                XtraMessageBox.Show("Başlangıç Tarihi Bu Günden Önce Olamaz.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
