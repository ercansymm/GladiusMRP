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
    public class UnitCard : gsBase
    {

        private string _CardName;
        [Display(Name = "Ad")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        public GladiusEnum.enmFormMod ScreenEnum = new GladiusEnum.enmFormMod();


        public UnitCard()
        {
            TableName = "UnitCard";


            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));


            this.CardName = "";
    

        }
    }
}
