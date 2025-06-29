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
    public class StockLiness : gsBase
    {

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }

        private int _LinelIO;
        public int LinelIO { get => _LinelIO; set { _LinelIO = value; SetUpdated("LinelIO", value); } }

        private Guid _FicheRef;
        public Guid FicheRef { get => _FicheRef; set { _FicheRef = value; SetUpdated("FicheRef", value); } } 
        
        private Guid _FicheDetailsRef;
        public Guid FicheDetailsRef { get => _FicheDetailsRef; set { _FicheDetailsRef = value; SetUpdated("FicheDetailsRef", value); } }
      
        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }

        private float _Amount;
        public float Amount { get => _Amount; set { _Amount = value; SetUpdated("Amount", value); } }
        
        private DateTime _Date_;
        public DateTime Date_ { get => _Date_; set { _Date_ = value; SetUpdated("Date_", value); } }



        public StockLiness()
        {
            TableName = "StockLines";
            Columns.Add(new ObjColumn("LinelIO", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("FicheRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("FicheDetailsRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Amount", SqlDbType.Float, "", false, false));
            Columns.Add(new ObjColumn("Date_", SqlDbType.Date, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));



            this.StockRef = Guid.Empty;
            this.FicheRef = Guid.Empty;
            this.FicheDetailsRef = Guid.Empty;
            this.UnitRef = Guid.Empty;
            this.Date_ = DateTime.Now;
            this.LinelIO = 0;
            this.Amount = 0;
         



        }
    }
}
