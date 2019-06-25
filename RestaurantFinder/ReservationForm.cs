using RestaurantDB;
using RestaurantDB.DB_jun;
using System;
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
            Reservation reservation = new Reservation();

            reservation.StoreId = DB.Store.FindStoreId(txbStoreName.Text);
            reservation.Name = txbReservationName.Text;
            reservation.PhoneNumber = txbPhoneNumber.Text;
            reservation.ReservationOn = ReservationOn.Value;
            
            reservation.NumberOfPeople = int.Parse(txbNumberOfPeople.Text);

            if (DB.Reservation.Insert(reservation))
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
