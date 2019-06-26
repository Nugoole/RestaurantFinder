using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class uscReservationCheckBox : UserControl
    {
        public uscReservationCheckBox()
        {
            InitializeComponent();
        }

        private void BtnCheckReservation_Click(object sender, EventArgs e)
        {
            OnCheckReservation(txbPhoneNumber.Text);
        }


        public event Action<object, string> CheckReservation;
        protected virtual void OnCheckReservation(string e)
        {
            if (CheckReservation != null)
                CheckReservation(this, e);
        }
        private string OnArgsName()
        {
            string args = "";
            OnCheckReservation(args);

            return args;
        }

        private void TxbPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCheckReservation.PerformClick();
        }
    }
}
