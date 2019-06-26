using RestaurantDB;
using RestaurantDB.DB_jun;
using System;
using System.Windows.Forms;

namespace RestaurantFinder
{
    public partial class ReservationForm : Form
    {
        public int ReservationId { get; private set; } = 0;
        public ReservationForm()
        {
            InitializeComponent();
        }

        public ReservationForm(string storeName)
        {
            InitializeComponent();
            txbStoreName.Text = storeName;
        }

        public void UpdateMode(Reservation reservation)
        {
            txbStoreName.Text = reservation.StoreName;
            txbReservationName.Text = reservation.Name;
            txbPhoneNumber.Text = reservation.PhoneNumber;
            txbNumberOfPeople.Text = reservation.NumberOfPeople.ToString();
            ReservationOn.Value = reservation.ReservationOn;
            ReservationId = reservation.ReservationId;
            btnMadeReservation.Text = "변경";
        }

        private void BtnMadeReservation_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();

            reservation.ReservationId = ReservationId;
            reservation.StoreId = DB.Store.FindStoreId(txbStoreName.Text);
            reservation.Name = txbReservationName.Text;
            reservation.PhoneNumber = txbPhoneNumber.Text;
            reservation.ReservationOn = ReservationOn.Value;
            reservation.NumberOfPeople = int.Parse(txbNumberOfPeople.Text);

            if(string.IsNullOrEmpty(reservation.PhoneNumber) == true)
            {
                MessageBox.Show("전화번호를 입력해주세요!", "경고", MessageBoxButtons.OK);
                return;
            }
            if (DB.Reservation.Update(reservation))
            {
                if (MessageBox.Show("업데이트 성공") == DialogResult.OK)
                    Dispose();
            }
            else if (DB.Reservation.Insert(reservation))
            {
                if (MessageBox.Show("입력성공") == DialogResult.OK)
                    Dispose();
            }
            else
                MessageBox.Show("실패");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
