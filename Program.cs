using GladiusObjex.PrgClass.PRO;
using ProductionGladius.Login_Screen;
using ProductionGladius.Stock;
using ProductionGladius.StockFiche;
using ProductionGladius.StockLine;
using ProductionGladius.StockLines;
using ProductionGladius.StockRecipt;
using ProductionGladius.Unit;
using ProductionGladius.users;
using ProductionGladius.WorkOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionGladius
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
