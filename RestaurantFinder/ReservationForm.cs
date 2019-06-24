using RestaurantDB;
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
            ReservitonData reservitonData = new ReservitonData();

            reservitonData.StoreName = txbStoreName.Text;
            reservitonData.ResetvationName = txbReservationName.Text;
            reservitonData.PhoneNumber = txbPhoneNumber.Text;
            reservitonData.ReservationOn = ReservationOn.Value;
            reservitonData.NumberOfPeople = txbNumberOfPeople.Text;


        }

            //MessageBox.Show($"{store}\n{name}\n{phone}\n{date}\n{people} 명");

            Reservation reservation = new Reservation();

            
            reservation.Store.Name = txbStoreName.Text;
            reservation.Name = txbReservationName.Text;
            reservation.PhoneNumber = txbPhoneNumber.Text;
            reservation.ReservationOn = ReservationOn.Value;
            reservation.NumberOfPeople = int.Parse(txbNumberOfPeople.Text);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
