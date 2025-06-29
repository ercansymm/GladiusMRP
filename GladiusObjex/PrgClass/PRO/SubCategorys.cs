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
    public class SubCategorys : gsBase
    {
        private string _CardName;
        [Display(Name = "Kategori Adı")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }



        private Guid _CategoryRef;
        public Guid CategoryRef { get => _CategoryRef; set { _CategoryRef = value; SetUpdated("CategoryRef", value); } }

        public SubCategorys GetSubs (Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            SubCategorys mysubs = new SubCategorys();

            mysubs = mng.GetObject<SubCategorys>(Ref);

            return mysubs;
        }
        public SubCategorys()
        {
            TableName = "SubCategorys";
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("CategoryRef", SqlDbType.UniqueIdentifier, "", false, false));

            this.CardName = "";
            this.CategoryRef = Guid.Empty;



        }


    }
}
