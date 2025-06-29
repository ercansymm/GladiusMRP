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
    public class StockReceipts : gsBase
    {

        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private Guid _StockRef;
        public Guid StockRef { get => _StockRef; set { _StockRef = value; SetUpdated("StockRef", value); } }


        private string _CardName;
        [Display(Name = "Ad")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private string _ReciptNo;
        [Display(Name = "Fiş No")]
        [DataType("nvarchar")]
        [StringLength(4000)]
        public string ReciptNo { get => _ReciptNo; set { _ReciptNo = value; SetUpdated("ReciptNo", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }


        public virtual BindingList<StockReceiptsDetail> Details { get; set; }
        public StockReceipts getFiche(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            StockReceipts myReceipt = new StockReceipts();

            myReceipt = mng.GetObject<StockReceipts>(Ref);

            myReceipt.Details = mng.GetObjectList<StockReceiptsDetail>("ReciptRef = '" + Ref + "'", "");

            return myReceipt;
        }


        public StockReceipts()
        {
            TableName = "StockReceipt";
            Columns.Add(new ObjColumn("StockRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("ReciptNo", SqlDbType.NVarChar, "", false, false));

            this.StockRef = Guid.Empty;
            this.Description = "";
            this.CardName = "";
            this.IsPassive = false;
            this.ReciptNo = "";

            Details = new BindingList<StockReceiptsDetail>();

        }
    }
}
