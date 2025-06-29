using GladiusObjex.BaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.Sıpa
{
    public class Massages : gsBase
    {
        private string _CardName;
        [Display(Name = "Ad")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }


        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private decimal _Price;
        public decimal Price { get => _Price; set { _Price = value; SetUpdated("Price", value); } }

        private DateTime _Time;
        public DateTime Time { get => _Time; set { _Time = value; SetUpdated("Time", value); } }


    }
}
