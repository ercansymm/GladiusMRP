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
    public class StockFiches : gsBase
    {
        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }


        private int _FicheNo;
        public int FicheNo { get => _FicheNo; set { _FicheNo = value; SetUpdated("FicheNo", value); } }


        private DateTime _FicheDate;
        public DateTime FicheDate { get => _FicheDate; set { _FicheDate = value; SetUpdated("FicheDate", value); } }

        private int _Doctypee;
        public int Doctype { get => _Doctypee; set { _Doctypee = value; SetUpdated("Doctype", value); } }


        public virtual BindingList<StockFichedetailss> Details { get; set; }
        public StockFiches getfiche(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            StockFiches myFiche = new StockFiches();

            myFiche = mng.GetObject<StockFiches>(Ref);

            myFiche.Details = mng.GetObjectList<StockFichedetailss>("StockFishRef = '" + Ref + "'", "");

            return myFiche;
        }

        public StockFiches()
        {
            TableName = "StockFiche";
            Columns.Add(new ObjColumn("FicheNo", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("FicheDate", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("Doctype", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));


            this.FicheDate = DateTime.Now;
            this.Doctype = 0;
            this.FicheNo = 0;
            this.Description = "";

            Details = new BindingList<StockFichedetailss>();

        }
    }
}
