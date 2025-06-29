using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;
using ProductionGladius.users;
using ProductionGladius.Stock;
using ProductionGladius.Clinet;
using ProductionGladius.StockRecipt;
using ProductionGladius.StockLines;
using ProductionGladius.WorkOrder;
using ProductionGladius.Login_Screen;
using ProductionGladius.Unit;
using ProductionGladius.Categoys;
using ProductionGladius.SubCategoys;
using ProductionGladius.StockLine;

namespace ProductionGladius
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            this.IsMdiContainer = true;
            InitializeComponent();
        }

        void Viseable()
        {
            accordionControlSeparator1.Visible = true;
            accordionControlSeparator2.Visible = true;
            accordionControlSeparator3.Visible = true;
            accordionControlSeparator4.Visible = true;
            accordionControlSeparator5.Visible = true;
            accordionControlSeparator6.Visible = true;
            accordionControlSeparator7.Visible = true;
            accordionControlSeparator8.Visible = true;
            accordionControlSeparator9.Visible = true;
            accordionControlSeparator10.Visible = true;
            accordionControlSeparator11.Visible = true;


            btnStock.Visible = true;
            btnUser.Visible = true;
            btnClinet.Visible = true;
            btnFiche.Visible = true;
            btnReceipt.Visible = true;
            btnWorkOrder.Visible = true;
            btnUnit.Visible = true;
            btnCategoys.Visible = true;
            btnSubsCategories.Visible = true;
            btnReporing.Visible = true;
            btnStockLine.Visible = true;
            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Form Users = Application.OpenForms["frmUserList"];

            if (Application.OpenForms["frmUserList"] == null)
            {
                frmUserList frmUserList = new frmUserList();
                frmUserList.MdiParent = this;
                frmUserList.Show();

            }
            else
            {
                if (Users != null)
                {

                    Users.Activate();
                }
            }




        }

        private void btnClinet_Click(object sender, EventArgs e)
        {


            Form ClinetList = Application.OpenForms["frmClinetList"];

            if (Application.OpenForms["frmClinetList"] == null)
            {
                frmClinetList Clinet = new frmClinetList();
                Clinet.MdiParent = this;
                Clinet.Show();
            }
            else
            {
                if (ClinetList != null)
                {
                    ClinetList.Activate();
                }
            }

        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            Form Receipt = Application.OpenForms["frmStockReceipt"];

            if (Application.OpenForms["frmStockReceipt"] == null)
            {
                frmStockReceipt frmStockReceipt = new frmStockReceipt();
                frmStockReceipt.MdiParent = this;
                frmStockReceipt.Show();
            }
            else
            {
                if (Receipt != null)
                {
                    Receipt.Activate();
                }
            }
        }

        private void btnFiche_Click(object sender, EventArgs e)
        {
            Form StockFicehe = Application.OpenForms["frmStockFicheList"];
            if (Application.OpenForms["frmStockFicheList"] == null)
            {
                frmStockFicheList frmStockFicheList = new frmStockFicheList();
                frmStockFicheList.MdiParent = this;
                frmStockFicheList.Show();
            }
            else
            {
                if (StockFicehe != null)
                {
                    StockFicehe.Activate();

                }
            }
        }

        private void btnWorkOrder_Click(object sender, EventArgs e)
        {
            Form workorder = Application.OpenForms["frmWorckOrderList"];

            if (Application.OpenForms["frmWorckOrderList"] == null)
            {
                frmWorckOrderList frmWorckOrderList = new frmWorckOrderList();
                frmWorckOrderList.MdiParent = this;
                frmWorckOrderList.Show();

            }
            else
            {
                if (workorder != null)
                {

                    workorder.Activate();
                }
            }
        }



        private void frmMain_Load(object sender, EventArgs e)
        {

            frmLoginScreen log = new frmLoginScreen();
            log.ShowDialog();
            this.Enabled = false;
            if (log.res == DialogResult.OK)
            {
                this.Enabled = true;
                log.Close();
                mainaccardion.Visible = true;
                Viseable();

            }
        }


        private void btnUnit_Click(object sender, EventArgs e)
        {
            frmUnit unit = new frmUnit();
            if (Application.OpenForms["frmUnit"] == null)
            {
                unit.ShowDialog();

            }
        }

        private void btnCategoys_Click(object sender, EventArgs e)
        {
            frmCategory frmCategory = new frmCategory();

            if (Application.OpenForms["frmCategory"] == null)
            {
                frmCategory.ShowDialog();
            }

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Form Stock = Application.OpenForms["frmStocklist"];

            if (Application.OpenForms["frmStockList"] == null)
            {
                frmStockList StockList = new frmStockList();
                StockList.MdiParent = this;
                StockList.Show();
            }
            else
            {
                if (Stock != null)
                {
                    Stock.Activate();
                }
            }
        }

        private void btnStockLine_Click(object sender, EventArgs e)
        {
            Form StockLine = Application.OpenForms["frmStockLines"];
            if (Application.OpenForms["frmStockLines"] == null)
            {
                frmStockLines frmStockLines = new frmStockLines();
                frmStockLines.MdiParent = this;
                frmStockLines.Show();

            }
            else
            {
                if (StockLine != null)
                {
                    StockLine.Activate();
                }
            }

        }

        private void btnSubsCategories_Click(object sender, EventArgs e)
        {

            frmSubs frmSubs = new frmSubs();
            if (Application.OpenForms["frmSubs"] == null)
            {
                frmSubs.ShowDialog();

            }
        }
    }
}
