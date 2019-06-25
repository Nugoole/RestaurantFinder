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

            //TODO
            //reservation.StoreId = EntityData<Store>.GetAll().Where(x => x.Name == txbStoreName.Text).Select(x=>x.StoreId).ToList()[0];
            reservation.Name = txbReservationName.Text;
            reservation.PhoneNumber = txbPhoneNumber.Text;
            reservation.ReservationOn = ReservationOn.Value+ new TimeSpan(3, 0, 0);
            
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
