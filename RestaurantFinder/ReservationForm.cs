using RestaurantDB;
using RestaurantDB.DB_jun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantFinder
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        public ReservationForm(string storeName)
        {
            InitializeComponent();
            txbStoreName.Text = storeName;
        }

        private void BtnMadeReservation_Click(object sender, EventArgs e)
        {
            //ReservitonData reservitonData = new ReservitonData();

            //reservitonData.StoreName = txbStoreName.Text;
            //reservitonData.ResetvationName = txbReservationName.Text;
            //reservitonData.PhoneNumber = txbPhoneNumber.Text;
            //reservitonData.ReservationOn = ReservationOn.Value;
            //reservitonData.NumberOfPeople = txbNumberOfPeople.Text;

            Reservation reservation = new Reservation();

            reservation.StoreId = DB<Store>.GetAll().Where(x => x.Name == txbStoreName.Text).Select(x=>x.StoreId).ToList()[0];
            reservation.Name = txbReservationName.Text;
            reservation.PhoneNumber = txbPhoneNumber.Text;
            reservation.ReservationOn = ReservationOn.Value+ new TimeSpan(3, 0, 0) ;
            
            reservation.NumberOfPeople = int.Parse(txbNumberOfPeople.Text);

            if(DB<Reservation>.Insert(reservation))
                MessageBox.Show("입력성공");
            else
                MessageBox.Show("입력실패");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
