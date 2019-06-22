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


        //셀 더블클릭 이벤트 시 발생할 함수
        private void UscResultGrid1_CellDoubleClickedHandler(object arg1, UserControls.ResultFormats.SearchResultData arg2)
        {            
            //Form reservation   = new reservationForm(arg2);
            //reservation.Show();
        }

        //검색버튼 클릭 시 발생할 함수
        private void UscSearchBox1_SearchButtonHandler(object arg1, RestaurantDB.DB_jun.SearchConditions arg2)
        {
            uscResultGrid1.Searched(arg2);
            uscResultGrid1.ResumeLayout();
        }
    }
}
