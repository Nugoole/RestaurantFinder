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
    public partial class uscResultGrid : UserControl
    {
        public uscResultGrid()
        {
            InitializeComponent();
        }

        private void UscResultGrid_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                bdsResult.DataSource = DB<Store>.GetAll().Select(x => new ResultFormats.SearchResultData
                {
                    Name = x.Name,
                    Outline = x.Outline
                }).ToList();
            }
        }

        private void GridResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
