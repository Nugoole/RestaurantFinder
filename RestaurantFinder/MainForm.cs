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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //검색버튼 클릭 시 발생할 함수
        private void UscSearchBox1_SearchButtonHandler(object obj)
        {
            uscResultGrid1.Searched();
            uscResultGrid1.Refresh();
        }

        //지도 버튼 클릭 시 발생할 함수
        private void UcsChooseLocation1_OnClickEventHandler(object obj)
        {
            uscSearchBox1.InitCityCbb();
            uscResultGrid1.PivotTable();
            uscSearchBox1.Refresh();
        }

        //셀 더블클릭 이벤트 시 발생할 함수
        private void UscResultGrid1_CellDoubleClickedHandler_1(object arg1, string arg2)
        {
            ReservationForm reservation = new ReservationForm(arg2);
            reservation.ShowDialog();
        }

    }
}
