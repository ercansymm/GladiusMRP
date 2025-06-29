using GladiusObjex.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.Sıpa
{
    public class WorkOrders : gsBase
    {

        private Guid _TherapistRef;
        public Guid TherapistRef { get => _TherapistRef; set { _TherapistRef = value; SetUpdated("TherapistRef", value); } }


        private Guid _CustomerRef;
        public Guid CustomerRef { get => _CustomerRef; set { _CustomerRef = value; SetUpdated("CustomerRef", value); } }

        private DateTime _Time;
        public DateTime Time { get => _Time; set { _Time = value; SetUpdated("Time", value); } }

        private int _Status;
        public int Status { get => _Status; set { _Status = value; SetUpdated("Status", value); } }

        


    }
}
