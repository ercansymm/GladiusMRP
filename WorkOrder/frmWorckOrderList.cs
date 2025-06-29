using DevExpress.CodeParser;
using DevExpress.Utils.DirectXPaint;
using DevExpress.Utils.VisualEffects;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using GladiusObjex.GKernel;
using GladiusObjex.PrgClass.PRO;
using GladiusObjex.Provider;
using GladiusObjex.Tool;
using ProductionGladius.SpecialClass;
using ProductionGladius.users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionGladius.WorkOrder
{
    public partial class frmWorckOrderList : DevExpress.XtraEditors.XtraForm
    {
        public frmWorckOrderList()
        {
            InitializeComponent();
        }

        ObjectManager mng = new ObjectManager(true, "erpConnStr");
        DbManager dbm = new DbManager(false, "erpConnStr");
        WorkOrders myOrder = new WorkOrders();
        public GladiusEnum.enmFormMod ScreenEnum = new GladiusEnum.enmFormMod();
        BaseList mylist = new BaseList();
        void state()
        {

            grdWork.Columns["Status"].ColumnEdit = riledStatus;
        }
        void fillRiled()
        {
            string query = @"
        SELECT '0' AS Status, 'İş Başlatıldı' AS CardName
        UNION ALL
        SELECT '1', 'İş Sonlandırıldı'";

            riledStatus.DataSource = dbm.ExecuteDataTable(query, CommandType.Text);
        }

        void fillGrid()
        {
            dgwWork.DataSource = dbm.ExecuteDataTable("Select * From WorkOrder", CommandType.Text);

        }
        private void frmWorckOrderList_Load(object sender, EventArgs e)
        {
            fillGrid();
            fillRiled();
            state();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            frmWorkOrder frmWork = new frmWorkOrder();
            if (Application.OpenForms["frmWorkOrder"] == null)
            {

                frmWork.ScreenEnum = GladiusEnum.enmFormMod.NEW;
                frmWork.ShowDialog();
                fillGrid();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grdWork.FocusedRowHandle >= 0) 
            {
                frmWorkOrder order = new frmWorkOrder();

                int value = int.Parse(dbm.ExecuteScalar("SELECT COUNT(Ref) FROM WorkOrder WHERE Ref = '" + Guid.Parse(grdWork.GetFocusedRowCellValue(clmWorkOrderRef).ToString()) + "'", CommandType.Text).ToString());

                var stat = dbm.ExecuteScalar("SELECT Status FROM WorkOrder WHERE Ref = '" + Guid.Parse(grdWork.GetFocusedRowCellValue(clmWorkOrderRef).ToString()) + "'", CommandType.Text);

                int Print = int.Parse(dbm.ExecuteScalar("SELECT COUNT(Ref) FROM WorkPrint WHERE WorkOrderRef = '" + Guid.Parse(grdWork.GetFocusedRowCellValue(clmWorkOrderRef).ToString()) + "' AND Status = '1'", CommandType.Text).ToString());

                if (Application.OpenForms["frmWorkOrder"] == null)
                {
                    if (Print < 1 )
                    {
                        if (value > 0)
                        {
                            if (stat != null && int.TryParse(stat.ToString(), out int statusValue))
                            {
                                if (statusValue != 1)
                                {
                                    order.ScreenEnum = GladiusEnum.enmFormMod.UPDATE;
                                    order.Ref = Guid.Parse(grdWork.GetFocusedRowCellValue(clmWorkOrderRef).ToString());
                                    order.ShowDialog();
                                    fillGrid();
                                }
                                else
                                {
                                    XtraMessageBox.Show("Biten İş Emrini Düzenleyemezsiniz", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Önce Bir Satır Seçmeniz Gerekmektedir", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Düzenleme Talebiniz Başarısız. Düzenlemek İstediğin İş Emrinin İçerisinde Üretimi Sonlandırılmış Ürünler Var", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    XtraMessageBox.Show("Lütfen bir satır seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

         

        }
        

        private void btnView_Click(object sender, EventArgs e)
        {
            frmWorkOrder order = new frmWorkOrder();
            if (Application.OpenForms["frmWorkOrder"] == null)
            {
                if (dgwWork.DataSource != null)
                {
                    order.ScreenEnum = GladiusEnum.enmFormMod.VIEW;
                    order.Ref = Guid.Parse(grdWork.GetFocusedRowCellValue(clmWorkOrderRef).ToString());
                    order.ShowDialog();
                    fillGrid();

                }
                else
                {
                    XtraMessageBox.Show("Lütfen Geçerli Bir Satır Seçini.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void grdWork_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;

            // Eğer DataSource'e bağlı bir veri varsa
            if (e.RowHandle >= 0)
            {
                // Durum sütununun değerini al
                string status = view.GetRowCellValue(e.RowHandle, "Status")?.ToString();

                // Duruma göre renklendirme
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



        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        //private void stpAppointed_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        mng = new ObjectManager(true, "erpConnStr");

        //        string statusRef = grdWork.GetFocusedRowCellValue(clmWorkOrderRef).ToString();

        //        dbm.ExecuteNonQuery("Update WorkOrder SET Status = 0 Where Ref = '" + Guid.Parse(statusRef).ToString() + "'", CommandType.Text);

        //        //myOrder.Status = 0;

        //        grdWork.SetFocusedRowCellValue("Status", 0); // Statüyü 1 yap

        //        if (myOrder.EndDate != null)
        //        {
        //            dbm.ExecuteNonQuery("UPDATE WorkOrder SET EndDate = NULL WHERE Status IN (0, 1) AND Ref = '" + statusRef + "' ", CommandType.Text);
        //            grdWork.SetFocusedRowCellValue("EndDate", null);

        //        }
        //        mng.Commit();




        //    }
        //    catch (Exception ex)
        //    {

        //        XtraMessageBox.Show("Dikkat" + ex);
        //    }
        //    XtraMessageBox.Show("Seçilen Satırın Durum Güncellemesi Tamamlanmıştır");





        //}

        private void stpEnded_Click(object sender, EventArgs e)
        {
            frmWorkPrint Print = new frmWorkPrint();
            
            if (Application.OpenForms["frmWorkPrint"] == null)
            {
                Print.ScreenEnum = GladiusEnum.enmFormMod.UPDATE;
                Print.Ref = Guid.Parse(grdWork.GetFocusedRowCellValue(clmWorkOrderRef).ToString());
                Print.WorkOrderNo = grdWork.GetFocusedRowCellValue(clmNO).ToString();
                Print.ShowDialog();
                if (Print.result == DialogResult.OK)
                {
                    try
                    {
                        mng = new ObjectManager(true, "erpConnStr");

                        // Seçili satırdaki Ref değerini al
                        string statusRef = grdWork.GetFocusedRowCellValue(clmWorkOrderRef).ToString();

                        // Statüyü 1 olarak güncelle
                        dbm.ExecuteNonQuery("Update WorkOrder SET Status = 1 Where Ref = '" + Guid.Parse(statusRef).ToString() + "'", CommandType.Text);

                        grdWork.SetFocusedRowCellValue("Status", 1); // Griddeki statüyü güncelle




                        DateTime currentDate = DateTime.Now;
                        dbm.ExecuteNonQuery("UPDATE WorkOrder SET EndDate = '" + currentDate.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE Ref = '" + statusRef + "'", CommandType.Text);

                        grdWork.SetFocusedRowCellValue("EndDate", currentDate);

                        mng.Commit();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Dikkat: " + ex.Message);
                    }
                }

                fillGrid(); // Grid'i yenile

            }
        }



        private void dgwWork_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Sağ tıklanan konumda hangi satırın olduğunu bul
                var hitInfo = grdWork.CalcHitInfo(e.Location);
                if (hitInfo.InRow) // Sadece bir satıra tıklandıysa
                {
                    grdWork.FocusedRowHandle = hitInfo.RowHandle; // Satırı seç
                    contextMenuStrip1.Show(Cursor.Position); // Sağ tık menüsünü göster
                }
            }
        }


        private void grdWork_DoubleClick(object sender, EventArgs e)
        {
            btnUpdate_Click(null, null);
            fillGrid();
            fillRiled();
        }

        private void tglActive_Toggled(object sender, EventArgs e)
        {
            fillGrid();
        }
    }
}