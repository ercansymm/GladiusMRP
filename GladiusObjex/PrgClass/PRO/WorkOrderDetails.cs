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
    public class WorkOrderDetails : gsBase
    {
        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }   
        
        private Guid _WorkRef;
        public Guid WorkRef { get => _WorkRef; set { _WorkRef = value; SetUpdated("WorkRef", value); } }
        
        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }   
        
      

        private int _Amount;
        public int Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }


        private string _Barcode;
        [Display(Name = "Barkod")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Barcode { get => _Barcode; set { _Barcode = value; SetUpdated("Barcode", value); } }

    
        public WorkOrderDetails()
        {
            TableName = "WorkOrderDetails";
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("WorkRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Barcode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Int, "", false, false));

            this.StockRef = Guid.Empty;
            this.UnitRef = Guid.Empty;
            this.WorkRef = Guid.Empty;
            this.Barcode = "";
            this.Amount = 0;
        }
    }
}
