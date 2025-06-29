using DevExpress.Pdf.Native.BouncyCastle.Ocsp;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionGladius.WorkOrder
{
    public partial class frmWorkPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmWorkPrint()
        {
            InitializeComponent();
        }
        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        WorkOrders myOrder = new WorkOrders();
        WorkPrint myPr = new WorkPrint();
        public GladiusEnum.enmFormMod ScreenEnum = new GladiusEnum.enmFormMod();
        public Guid Ref;
        public DialogResult result;
        public string WorkOrderNo;

        int Counter;
        void filLookup()
        {
            ledStock.Properties.DataSource = dbm.ExecuteDataTable("Select Ref ,CardName from Stock ", CommandType.Text);
            ledReceipt.Properties.DataSource = dbm.ExecuteDataTable("Select Ref ,CardName from StockReceipt", CommandType.Text);
            LedUnit.Properties.DataSource = dbm.ExecuteDataTable("Select Ref ,CardName From UnitCard", CommandType.Text);

        }
        void filltext()
        {
            ledStock.EditValue = myOrder.StockRef;
            ledReceipt.EditValue = myOrder.StockReceiptRef;
            txtAmount.Text = myOrder.ParsedAmount.ToString();
            LedUnit.EditValue = myOrder.UnitRef;
            dateTime.EditValue = myOrder.StartDate;
            txtWorckNo.Text = myOrder.WorkOrderNo.ToString();
            rchDescription.Text = myOrder.Description;
        }
        void fillLed()
        {
            riledStock.DataSource = dbm.ExecuteDataTable("Select Ref StockRef,CardName From Stock ", CommandType.Text);
            riledUnitRef.DataSource = dbm.ExecuteDataTable("Select Ref UnitRef,CardName From UnitCard", CommandType.Text);

            string query = @"
        SELECT '0' AS Status, 'İş Başlatıldı' AS CardName
        UNION ALL
        SELECT '1', 'İş Sonlandırıldı'";

            riledStatus.DataSource = dbm.ExecuteDataTable(query, CommandType.Text);

        }
        void fillBarcode()
        {
            Counter = int.Parse(dbm.ExecuteScalar("Select Count(Ref) From WorkPrint Where WorkOrderRef = '" + Ref + "' AND Status = '0' ", CommandType.Text).ToString());

            LedBarcode.Properties.DataSource = dbm.ExecuteDataTable("Select Ref,Barcode From  WorkPrint Where WorkOrderRef = '" + Ref + "' AND Status = '0' ", CommandType.Text);

            LedBarcode.Properties.DropDownRows = Counter;

        }
        void state()
        {
            grdWork.Columns["Status"].ColumnEdit = riledStatus;
        }
        void fillGrid()
        {
            dgwWork.DataSource = myOrder.Print;

        }
        private void grdWork_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.RowHandle >= 0)
            {
                string status = view.GetRowCellValue(e.RowHandle, "Status")?.ToString();

                if (status == 0.ToString())
                {
                    e.Appearance.BackColor = Color.FromArgb(204, 255, 204); // Pastel yeşil
                }
                else if (status == 1.ToString())
                {
                    e.Appearance.BackColor = Color.FromArgb(255, 204, 203); // Pastel mavi
                }
            }
        }

        private void frmWorkPrint_Load(object sender, EventArgs e)
        {


            myOrder = myOrder.getWork(Ref);
            dateTime.DateTime = myOrder.StartDate;
            filLookup();
            filltext();
            state();
            fillLed();
            fillGrid();
            fillBarcode();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            mng = new ObjectManager(true, "erpConnStr");

            bool allStatusOne = true;

            GridView view = dgwWork.MainView as GridView;

            if (view != null)
            {
                for (int i = 0; i < view.RowCount; i++)
                {
                    if (view.GetRowCellValue(i, "Status")?.ToString() == "1")
                    {
                        string barcode = view.GetRowCellValue(i, "Barcode")?.ToString();

                        WorkPrint tempPrint = mng.GetObject<WorkPrint>("Barcode = '" + barcode + "'");

                        tempPrint.Status = 1;
                        mng.SaveObject<WorkPrint>(tempPrint);
                    }
                }

                XtraMessageBox.Show("Tüm değişiklikler kaydedildi.");

                for (int i = 0; i < view.RowCount; i++)
                {
                    var status = view.GetRowCellValue(i, "Status");

                    if (status == null || status.ToString() != "1")
                    {
                        allStatusOne = false;
                        break;
                    }

                }
                if (allStatusOne)
                {
                    WorkOrders myOrders = mng.GetObject<WorkOrders>(Ref);
                    myOrders.Status = 1;
                    myOrders.EndDate = DateTime.Now;
                    mng.SaveObject<WorkOrders>(myOrders);


                }
                foreach (WorkOrderDetails item in myOrder.Details)
                {
                    StockLiness myline = new StockLiness
                    {
                        LinelIO = 1,
                        Amount = item.Amount,
                        UnitRef = item.UnitRef,
                        StockRef = item.StockRef,
                        FicheRef = myOrder.Ref,
                        FicheDetailsRef = item.Ref,
                        Date_ = myOrder.StartDate,

                    };

                    mng.SaveObject<StockLiness>(myline);

                }
            }
            StockLiness mylines = new StockLiness
            {
                LinelIO = 0,
                Amount = myOrder.ParsedAmount,
                UnitRef = myOrder.UnitRef,
                StockRef = myOrder.StockRef,
                FicheRef = myOrder.Ref,
                Date_ = myOrder.StartDate,

            };

            mng.SaveObject<StockLiness>(mylines);
            mng.Commit();
            btnPrint_Click(null, null);
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            mng = new ObjectManager(true, "erpConnStr");

            BindingList<WorkPrint> wPrint = new BindingList<WorkPrint>();

            wPrint = mng.GetObjectList<WorkPrint>("WorkOrderRef = '" + myOrder.Ref + "' AND Status = '1' ", "");

            int PrintSoruce = 0;

            foreach (WorkPrint item in wPrint)
            {
                XtraReport Rep = new XtraReport();
                Rep.LoadLayout(Application.StartupPath + @"\Reports\GüncelBarkod.repx");

                DataSet Ds = new DataSet();
                DataTable dtBarcodef = dbm.ExecuteDataTable(
                    @"select SC.CardName UrunAdi, SU.CardName Birim, WRP.Amount Miktar, ORD.WorkOrderNo LotNO,
WRP.Barcode Barcode
from WorkPrint WRP
left join Stock SC ON SC.Ref = WRP.StockRef
left Join WorkOrder ORD ON ORD.Ref = WRP.WorkOrderRef
left join UnitCard SU ON SU.Ref = WRP.UnitRef
where WRP.Ref = '" + item.Ref + "' AND WRP.Status = '1'", CommandType.Text);

                if (dtBarcodef.Rows.Count > 0)
                {

                    DataTable dtProdBarcode = dtBarcodef.Copy();
                    dtProdBarcode.TableName = "WorkPrint";
                    Ds.Tables.Add(dtProdBarcode);
                    PrintSoruce++;

                    Rep.DataSource = Ds;
                    //Rep.ShowDesigner();
                    Rep.Print();

                }


            }
            if (PrintSoruce > 0)
            {
                XtraMessageBox.Show("Üretilen Ürünlerin  Barkodları Yazdırılmıştır...", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }



        }

        private void grdWork_DoubleClick(object sender, EventArgs e)
        {
            mng = new ObjectManager(true, "erpConnStr");

            int scor;
            int statusControl;
            string barcodes = grdWork.GetFocusedRowCellValue("Barcode")?.ToString();


            scor = int.Parse(dbm.ExecuteScalar("Select Count(Ref) from WorkPrint Where Barcode = '" + barcodes + "' AND  WorkOrderRef = '" + Ref + "'", CommandType.Text).ToString());
            statusControl = int.Parse(dbm.ExecuteScalar("Select Count(Ref) from WorkPrint Where Barcode = '" + barcodes + "' AND WorkOrderRef = '" + Ref + "' AND Status = '0' ", CommandType.Text).ToString());


            if (scor > 0)
            {
                if (statusControl > 0)
                {


                    foreach (var item in myOrder.Print)
                    {
                        if (item.Barcode == barcodes)
                        {

                            if (item.Status != 1)
                            {
                                GridView view = dgwWork.MainView as GridView; // GridView'i al

                                if (view != null)
                                {

                                    for (int i = 0; i < view.RowCount; i++)
                                    {
                                        string barcode = view.GetRowCellValue(i, "Barcode")?.ToString();

                                        if (barcode == barcodes)
                                        {
                                            // Status değerini 1 
                                            view.SetRowCellValue(i, "Status", 1);
                                            XtraMessageBox.Show("Durum geçici olarak güncellendi. Henüz kaydedilmedi.");
                                            break;

                                        }
                                    }


                                }
                            }

                        }

                    }
                }
                else
                {
                    XtraMessageBox.Show("Bu Barkod Numarasına Ait Ürün Zaten Üretilmiş '" + LedBarcode.EditValue.ToString() + "'", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                XtraMessageBox.Show("Böyle Bir Ürün Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void LedBarcode_EditValueChanged(object sender, EventArgs e)
        {
            mng = new ObjectManager(true, "erpConnStr");

            string BarcodeValue = LedBarcode.Text;
            int scor;
            int statusControl;


            scor = int.Parse(dbm.ExecuteScalar("Select Count(Ref) from WorkPrint Where Barcode = '" + decimal.Parse(BarcodeValue).ToString() + "' AND  WorkOrderRef = '" + Ref + "'", CommandType.Text).ToString());
            statusControl = int.Parse(dbm.ExecuteScalar("Select Count(Ref) from WorkPrint Where Barcode = '" + decimal.Parse(BarcodeValue).ToString() + "' AND WorkOrderRef = '" + Ref + "' AND Status = '0' ", CommandType.Text).ToString());


            if (scor > 0)
            {
                if (statusControl > 0)
                {


                    foreach (var item in myOrder.Print)
                    {
                        if (item.Barcode == BarcodeValue)
                        {

                            if (item.Status != 1)
                            {
                                GridView view = dgwWork.MainView as GridView; // GridView'i al

                                if (view != null)
                                {

                                    for (int i = 0; i < view.RowCount; i++)
                                    {
                                        string barcode = view.GetRowCellValue(i, "Barcode")?.ToString();

                                        if (barcode == BarcodeValue)
                                        {
                                            // Status değerini 1 
                                            view.SetRowCellValue(i, "Status", 1);
                                            XtraMessageBox.Show("Durum geçici olarak güncellendi. Henüz kaydedilmedi.");

                                            break;

                                        }
                                    }


                                }
                            }

                        }

                    }
                }
                else
                {
                    XtraMessageBox.Show("Bu Barkod Numarasına Ait Ürün Zaten Üretilmiş '" + LedBarcode.EditValue.ToString() + "'", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                XtraMessageBox.Show("Böyle Bir Ürün Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}