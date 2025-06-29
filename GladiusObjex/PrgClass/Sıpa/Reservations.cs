using GladiusObjex.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.Sıpa
{
    public class Reservations : gsBase
    {

        private DateTime _Date_;
        public DateTime Date_ { get => _Date_; set { _Date_ = value; SetUpdated("Date_", value); } }


        private DateTime _Time;
        public DateTime Time { get => _Time; set { _Time = value; SetUpdated("Time", value); } }


        private Guid _CustomerRef;
        public Guid CustomerRef { get => _CustomerRef; set { _CustomerRef = value; SetUpdated("CustomerRef", value); } }

        private Guid _TherapistRef;
        public Guid TherapistRef { get => _TherapistRef; set { _TherapistRef = value; SetUpdated("TherapistRef", value); } }

    }
}
