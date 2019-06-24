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

        private void BtnMadeReservation_Click(object sender, EventArgs e)
        {
            //string store = txbStoreName.Text = "한미락";
            //string name = txbReservationName.Text = "이태희";
            //string phone = txbPhoneNumber.Text = "010-7777-7777";
            //string date = ReservationOn.Value.ToLongDateString();
            //string people = txbNumberOfPeople.Text = "6";

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
        }
    }
}
