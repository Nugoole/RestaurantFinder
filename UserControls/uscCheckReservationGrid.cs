using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantDB.DB_jun;
using RestaurantDB;

namespace UserControls
{
    public partial class uscCheckReservationGrid : UserControl
    {
        public uscCheckReservationGrid()
        {
            InitializeComponent();
        }

        public void SearchedReservation(string phoneNumber)
        {
            if(!DesignMode)
            {
                var reservationDB = DB.Reservation.GetReservationList(phoneNumber).Select(x => new
                {
                    Name = x.Name,
                    StoreName = x.StoreName,
                    Date = x.ReservationOn,
                    People = x.NumberOfPeople
                }).ToList();
                dataGridView1.DataSource = reservationDB;
                
            }
        }
    }
}
