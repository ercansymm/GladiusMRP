using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.PRO
{
    public class StockFichedetailss : gsBase
    {
        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private Guid _StockFishRef;
        public Guid StockFishRef { get => _StockFishRef; set { _StockFishRef = value; SetUpdated("StockFishRef", value); } }

        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private float _Amount;
        public float Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }

        private int _LineIO;
        public int LineIO { get => _LineIO; set { _LineIO = value; SetUpdated("LineIO", value); } }


        public StockFichedetailss()
        {
            TableName = "StockFichedetails";
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockFishRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Float, "", false, false));
            Columns.Add(new ObjColumn("LineIO", SqlDbType.Int, "", false, false));

            this.StockRef = Guid.Empty;
            this.StockFishRef = Guid.Empty;
            this.UnitRef = Guid.Empty;
            this.Amount = 0;
            this.LineIO = 0;


        }
    }
}
