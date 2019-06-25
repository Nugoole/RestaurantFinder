using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls
{
    class CheckReservationConditon
    {
        private static CheckReservationConditon _condition = null;

        private CheckReservationConditon()
        {
            PhoneNumber = null;
        }

        public string PhoneNumber { get; set; }
    }
}
