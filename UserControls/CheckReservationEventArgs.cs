using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls
{
    public class CheckReservationEventArgs : EventArgs
    {
        public string PhoneNumber { get; set; }

        public CheckReservationEventArgs()
        {
        }

        public CheckReservationEventArgs(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }
    }
}
