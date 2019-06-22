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
    public partial class uscSearchBox : UserControl
    {
        public uscSearchBox()
        {
            InitializeComponent();
        }

        private void UscSearchBox_Load(object sender, EventArgs e)
        {
            if(!DesignMode)
                bdsCity.DataSource = DB<City>.GetAll();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchConditions conditions = new SearchConditions();
            foreach (var item in Controls[0].Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                    if ((item as CheckBox).Checked)
                        conditions.FoodTypeIds.Add(int.Parse((item as CheckBox).Tag.ToString()));
            }

            conditions.CityId = (int)cbbCity.SelectedValue;
            if(txbKeyword.Text != "")
                conditions.KeyWord = txbKeyword.Text;

            OnSearchButtonClicked(conditions);
        }

        #region SearchButtonClicked
        public event Action<object, SearchConditions> SearchButtonHandler;
        protected virtual void OnSearchButtonClicked(SearchConditions e)
        {
            if (SearchButtonHandler != null)
                SearchButtonHandler(this, e);
        }
        private SearchConditions OnSearchButtonClicked()
        {
            SearchConditions args = new SearchConditions();
            OnSearchButtonClicked(args);

            return args;
        }
        #endregion
    }
}
