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

        public void Searched(SearchConditions conditions)
        {
            if(!DesignMode)
            {
                //전체 내용 가져오기
                var DBbase = DB<Store>.GetAll();

                //고른 지역 확인 후 추려냄
                if (conditions.StateId != 0)
                {
                    DBbase = DBbase.Where(x => x.StateId == conditions.StateId).ToList();
                }

                //음식 타입 확인 후 추려냄
                if (conditions.FoodTypeIds.Any())
                {
                    DBbase = DBbase.Where(x => conditions.FoodTypeIds.Contains(x.FoodTypeId)).ToList();
                }

                //고른 구역 확인 후 추려냄
                if (conditions.CityId != 0)
                {
                    DBbase = DBbase.Where(x => x.CityId == conditions.CityId).ToList();
                }

                //키워드 입력 확인 후 추려냄
                if (conditions.KeyWord != null)
                {
                    DBbase = DBbase.Where(x => x.Outline.Contains(conditions.KeyWord)).ToList();
                }

                //추려낸 결과 소스로 이동
                bdsResult.DataSource = DBbase;
                label1.Text = $"총 {DBbase.Count()}개의 검색 결과";
            }
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

                label1.Text = $"총 {DB<Store>.GetAll().Count()}개의 검색 결과";
            }
        }

        //셀 더블클릭시 해당 셀의 정보를 핸들러에 넘겨줌
        private void GridResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SearchResultData searchResultData = gridResult.CurrentRow.DataBoundItem as SearchResultData;

            if (searchResultData == null)
                return;

            OnCellDoubleClickd(searchResultData);
        }

        //이벤트 정의
        #region CellDoubleClicked
        public event Action<object, SearchResultData> CellDoubleClickedHandler;
        protected virtual void OnCellDoubleClickd(SearchResultData e)
        {
            if (CellDoubleClickedHandler != null)
                CellDoubleClickedHandler(this, e);
        }
        private SearchResultData OnCellDoubleClickd()
        {
            SearchResultData args = new SearchResultData();
            OnCellDoubleClickd(args);

            return args;
        }
        #endregion
    }
}
