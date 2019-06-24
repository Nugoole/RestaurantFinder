using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFinder
{
    class ReservitonData
    {
        public ReservitonData()
        {
            StoreName = null;
            ResetvationName = null;
            PhoneNumber = null;
            NumberOfPeople = null;
        }

        public string StoreName { get; set; }
        public string ResetvationName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime ReservationOn { get; set; }
        public string NumberOfPeople { get; set; }
    }
}
