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
            InitCityCbb();
        }

        public void InitCityCbb()
        {
            if (!DesignMode || SearchConditions.Condition.StateId != 0)
                bdsCity.DataSource = DB<City>.GetAll().Where(x=>x.StateId == SearchConditions.Condition.StateId).ToList();            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchConditions.Condition.FoodTypeIds.Clear();
            foreach (var item in Controls[0].Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                    if ((item as CheckBox).Checked)
                        SearchConditions.Condition.FoodTypeIds.Add(int.Parse((item as CheckBox).Tag.ToString()));
            }

            SearchConditions.Condition.CityId = (int)cbbCity.SelectedValue;
            if(txbKeyword.Text != "")
                SearchConditions.Condition.KeyWord = txbKeyword.Text;

            OnSearchButtonClicked(SearchConditions.Condition);
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
            OnSearchButtonClicked(SearchConditions.Condition);

            return SearchConditions.Condition;
        }
        #endregion
    }
}
