using GladiusObjex.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.Sıpa
{
    public class Case : gsBase
    {

        private decimal _Money;
        public decimal Money { get => _Money; set { _Money = value; SetUpdated("Money", value); } }

        private DateTime _Date;
        public DateTime Date { get => _Date; set { _Date = value; SetUpdated("Date", value); } }

        private Guid _UserRef;
        public Guid UserRef { get => _UserRef; set { _UserRef = value; SetUpdated("UserRef", value); } }



    }
}
