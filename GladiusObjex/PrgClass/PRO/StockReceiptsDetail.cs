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
    public class StockReceiptsDetail : gsBase
    {

        private Guid _ReciptRef;
        public Guid ReciptRef { get => _ReciptRef; set { _ReciptRef = value; SetUpdated("ReciptRef", value); } }

        private int _LineIO;
        public int LineIO { get => _LineIO; set { _LineIO = value; SetUpdated("LineIO", value); } }    
        
        private int _Amount;
        public int Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }      
        
        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } } 
        
        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private string _CardName;
        [Display(Name = "Ad")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }



        public StockReceiptsDetail()
        {
            TableName = "StockReceiptDetail";
            Columns.Add(new ObjColumn("ReciptRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("LineIO", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Float, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ReciptRef", SqlDbType.UniqueIdentifier, "", false, false));

            this.CardName = "";
            this.StockRef = Guid.Empty;
            this.ReciptRef = Guid.Empty;
            this.UnitRef = Guid.Empty;
            this.LineIO = 0;
            this.Amount = 0;
     
        }
    }
}
