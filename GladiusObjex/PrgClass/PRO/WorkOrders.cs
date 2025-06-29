using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.PRO
{
    public class WorkOrders : gsBase
    {
        private Guid _StockReceiptRef;
        public Guid StockReceiptRef { get => _StockReceiptRef; set { _StockReceiptRef = value; SetUpdated("StockReceiptRef", value); } }
        
        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

     
        private int _LotNo;
        public int LotNo { get => _LotNo; set { _LotNo = value; SetUpdated("LotNo", value); } }

        private int _Status;
        public int Status { get => _Status; set { _Status = value; SetUpdated("Status", value); } }
          
        private int _ParsedAmount;
        public int ParsedAmount { get => _ParsedAmount; set { _ParsedAmount = value; SetUpdated("ParsedAmount", value); } }


        private DateTime _StartDate;
        public DateTime StartDate { get => _StartDate; set { _StartDate = value; SetUpdated("StartDate", value); } }

        private DateTime _EndDate;
        public DateTime EndDate { get => _EndDate; set { _EndDate = value; SetUpdated("EndDate", value); } }



        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }
        
        private string _WorkOrderNo;
        [Display(Name = "Lotno")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string WorkOrderNo { get => _WorkOrderNo; set { _WorkOrderNo = value; SetUpdated("WorkOrderNo", value); } }
        public virtual BindingList<WorkOrderDetails> Details { get; set; }
        public virtual BindingList<WorkPrint> Print { get; set; }

        public WorkOrders getWork(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            WorkOrders myOrder = new WorkOrders();

            myOrder = mng.GetObject<WorkOrders>(Ref);

            myOrder.Details = mng.GetObjectList<WorkOrderDetails>("WorkRef = '" + Ref + "'", "");

            myOrder.Print = mng.GetObjectList<WorkPrint>("WorkOrderRef = '" + Ref + "'", "");

            return myOrder;
        }


        public WorkOrders()
        {
            TableName = "WorkOrder";
            Columns.Add(new ObjColumn("StockReceiptRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("WorkOrderNo", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("StartDate", SqlDbType.Date, "", false, false));
            Columns.Add(new ObjColumn("EndDate", SqlDbType.Date, "", false, false));
            Columns.Add(new ObjColumn("Status", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("ParsedAmount", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));


            this.StockReceiptRef = Guid.Empty;
            this.WorkOrderNo = "";
            this.StartDate = DateTime.MinValue;
            this.EndDate = DateTime.MinValue;
            this.Status = 0;
            this.ParsedAmount = 1;
            this.Description = "";
            this.StockRef = Guid.Empty;
            this.UnitRef = Guid.Empty;
            Print = new BindingList<WorkPrint>();
            Details = new BindingList<WorkOrderDetails>();
        }
    }
}
