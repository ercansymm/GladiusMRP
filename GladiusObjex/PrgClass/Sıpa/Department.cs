using GladiusObjex.BaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.Sıpa
{
    public class Department : gsBase
    {

        private string _CardName;
        [Display(Name = "Ad")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }


    }
}
