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
    public class Categorys : gsBase
    {
        private string _CardName;
        [Display(Name = "Kategori Adı")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }



        private Guid _SubRef;
        public Guid SubRef { get => _SubRef; set { _SubRef = value; SetUpdated("SubRef", value); } }

        public Categorys GetCategorys(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            Categorys myCategory = new Categorys();

            myCategory = mng.GetObject<Categorys>(Ref);

            return myCategory;
        }
        public Categorys()
        {
            TableName = "Categorys";
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("SubRef", SqlDbType.UniqueIdentifier, "", false, false));

            this.CardName = "";
            this.SubRef = Guid.Empty;



        }
    }


}
