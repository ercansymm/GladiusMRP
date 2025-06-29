using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.PRO
{
    public class WorkPrint : gsBase
    {

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }


        private Guid _WorkOrderRef;
        public Guid WorkOrderRef { get => _WorkOrderRef; set { _WorkOrderRef = value; SetUpdated("WorkOrderRef", value); } }
        
        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }


        private int _Amount;
        public int Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }


        private int _Status;
        public int Status { get => _Status; set { _Status = value; SetUpdated("Status", value); } }

        private string _WorkOrderNo;
        [Display(Name = "Lotno")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string WorkOrderNo { get => _WorkOrderNo; set { _WorkOrderNo = value; SetUpdated("WorkOrderNo", value); } }

        private string _Barcode;
        [Display(Name = "Barkod")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Barcode { get => _Barcode; set { _Barcode = value; SetUpdated("Barcode", value); } }

        public WorkPrint()
        {
            TableName = "WorkPrint";
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("WorkOrderRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Barcode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("WorkOrderNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("Status", SqlDbType.Int, "", false, false));

            this.StockRef = Guid.Empty;
            this.UnitRef = Guid.Empty;
            this.WorkOrderRef = Guid.Empty;
            this.Barcode = "";
            this.WorkOrderNo = "";
            this.Amount = 0;
            this.Status = 0;
        }

    }
}
