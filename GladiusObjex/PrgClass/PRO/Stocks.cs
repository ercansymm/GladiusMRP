using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using GladiusObjex.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.PRO
{
    public class Stocks : gsBase
    {
        private string _CardName;
        [Display(Name = "Ürün Adı")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private string _Barcode;
        [Display(Name = "Barkod")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Barcode { get => _Barcode; set { _Barcode = value; SetUpdated("Barcode", value); } }


        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private string _StockCode;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string StockCode { get => _StockCode; set { _StockCode = value; SetUpdated("StockCode", value); } }


        private Guid _UnitRef;
        public Guid UnitRef { get => _UnitRef; set { _UnitRef = value; SetUpdated("UnitRef", value); } }


        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }


        private byte[] _Image;
        public byte[] Image { get => _Image; set { _Image = value; SetUpdated("Image", value); } }

        private int _CardType;
        public int CardType { get => _CardType; set { _CardType = value; SetUpdated("CardType", value); } }


        private Guid _CategoryRef;
        public Guid CategoryRef { get => _CategoryRef; set { _CategoryRef = value; SetUpdated("CategoryRef", value); } }

        private Guid _SubCategoryRef;
        public Guid SubCategoryRef { get => _SubCategoryRef; set { _SubCategoryRef = value; SetUpdated("SubCategoryRef", value); } }



        public Stocks GetStocks(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            Stocks myStocks = new Stocks();

            myStocks = mng.GetObject<Stocks>(Ref);

            return myStocks;
        }
        public Stocks()
        {
            TableName = "Stock";
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Barcode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("UnitRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Image", SqlDbType.Image, "", false, false));
            Columns.Add(new ObjColumn("StockCode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("CardType", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("CategoryRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("SubCategoryRef", SqlDbType.UniqueIdentifier, "", false, false));



            this.CardName = "";
            this.CardType = 0;
            this.Barcode = "";
            this.UnitRef = Guid.Empty;
            this.Description = "";
            this.IsPassive = true;
            this.Image = null;
            this.StockCode = "";
            this.CategoryRef = Guid.Empty;
            this.SubCategoryRef = Guid.Empty;



        }

    }
}

