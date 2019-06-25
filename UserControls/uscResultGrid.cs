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
using UserControls.ResultFormats;

namespace UserControls
{
    public partial class uscResultGrid : UserControl
    {
        public uscResultGrid()
        {
            InitializeComponent();
        }

        public void Searched()
        {
            if(!DesignMode)
            {
                //전체 내용 가져오기
                var DBbase =DB.Store.GetAll();

                //고른 지역 확인 후 추려냄
                if (SearchConditions.Condition.StateId != 0)
                {
                    DBbase = DBbase.Where(x => x.StateId == SearchConditions.Condition.StateId).ToList();
                }

                //음식 타입 확인 후 추려냄
                if (SearchConditions.Condition.FoodTypeIds.Any())
                {
                    DBbase = DBbase.Where(x => SearchConditions.Condition.FoodTypeIds.Contains(x.FoodTypeId)).ToList();
                }

                //고른 구역 확인 후 추려냄
                if (SearchConditions.Condition.CityId != 0)
                {
                    DBbase = DBbase.Where(x => x.CityId == SearchConditions.Condition.CityId).ToList();
                }

                //키워드 입력 확인 후 추려냄
                if (SearchConditions.Condition.KeyWord != null)
                {
                    DBbase = DBbase.Where(x => x.Outline.Contains(SearchConditions.Condition.KeyWord)).ToList();
                }

                var DBbase2 = from x in DBbase
                              select new SearchResultData
                              {
                                  Name = x.Name,
                                  Outline = x.Outline
                              };

                //추려낸 결과 소스로 이동
                gridResult.Columns.Clear();
                
                bdsResult.DataSource = DBbase2;
                gridResult.DataSource = bdsResult;
                gridResult.Refresh();
                label1.Text = $"총 {DBbase.Count()}개의 검색 결과";
            }
        }

        //셀 더블클릭시 해당 셀의 정보를 핸들러에 넘겨줌
        private void GridResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DesignMode)
            {
                SearchResultData searchResultData = gridResult.CurrentRow.DataBoundItem as SearchResultData;
                if (searchResultData == null)
                    return;

                OnCellDoubleClickd(searchResultData.Name);
            }
        }

        //이벤트 정의
        #region CellDoubleClicked
        public event Action<object, string> CellDoubleClickedHandler;
        protected virtual void OnCellDoubleClickd(string e)
        {
            if (CellDoubleClickedHandler != null)
                CellDoubleClickedHandler(this, e);
        }
        private string OnCellDoubleClickd()
        {
            string storeName = "\0";
            OnCellDoubleClickd(storeName);

            return storeName;
        }
        #endregion
    }
}
