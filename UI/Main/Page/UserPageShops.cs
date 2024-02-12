using FreeSql.Internal.Model;
using hygge_imaotai.Database;
using hygge_imaotai.Database.Model;
using hygge_imaotai.Service;
using Sunny.UI;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace hygge_imaotai.UI.Main.Page
{
    /// <summary>
    /// 门店列表子页面
    /// </summary>
    public partial class UserPageShops : UIUserControl
    {
        #region Fields
        /// <summary>
        /// 全局父窗口
        /// </summary>
        private readonly FrmMain _frmMain;
        /// <summary>
        /// 数据库操作对象
        /// </summary>
        private readonly IFreeSql _db = DB.Sqlite;
        #endregion

        #region Constructor And Init

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="frmMain"></param>
        public UserPageShops(FrmMain frmMain)
        {
            InitializeComponent();
            this._frmMain = frmMain;
            ControlDefaultSetting();
            ControlValueInit();
        }

        /// <summary>
        /// 控件的默认设置初始化
        /// </summary>
        private void ControlDefaultSetting()
        {
            DgvShopList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvShopList.AutoGenerateColumns = false;
            PageShop.PageSize = 20;

            foreach (DataGridViewColumn userDataGridViewColumn in DgvShopList.Columns)
            {
                userDataGridViewColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        /// <summary>
        /// 控件的默认值初始化
        /// </summary>
        private void ControlValueInit()
        {
            var shopList = _db.Select<Shop>()
                .Count(out var userCount).Page(1, 20).ToList();
            DgvShopList.DataSource = shopList;
            PageShop.TotalCount = (int)userCount;
        }


        #endregion

        #region Control Event
        /// <summary>
        /// 刷新商品列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnRefresh_Click(object sender, System.EventArgs e)
        {
            this._frmMain.ShowProcessForm();
            await ImtService.RefreshShop();
            ControlValueInit();
            this._frmMain.HideProcessForm();
        }

        /// <summary>
        /// 分页控件页面切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="pagingSource"></param>
        /// <param name="pageIndex"></param>
        /// <param name="count"></param>
        private void PageShop_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            var shopList = _db.Select<Shop>().WhereDynamicFilter(ConstructExpress())
                .Page(pageIndex, 20).ToList();
            DgvShopList.DataSource = shopList;
        }

        /// <summary>
        /// 条件查询数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnQuery_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(TbConditionValue.Text.Trim()))
            {
                this._frmMain.ShowWarningTip("请先输入查询条件");
                return;
            }
            var shopList =
                _db.Select<Shop>().WhereDynamicFilter(ConstructExpress())
                    .Count(out var total).Page(1, 20).ToList();
            DgvShopList.DataSource = shopList;
            PageShop.TotalCount = (int)total;

        }

        /// <summary>
        /// 构造查询表达式
        /// </summary>
        /// <returns></returns>
        public DynamicFilterInfo ConstructExpress()
        {
            if (CmbConditionKey.SelectedIndex == -1) CmbConditionKey.SelectedIndex = 0;
            DynamicFilterInfo dyfilter;
            var propertiesList = new[] { "id", "provinceName", "cityName", "districtName", "tenantName" };
            if (CmbConditionKey.SelectedIndex == 0)
            {
                dyfilter = Json.Deserialize<DynamicFilterInfo>(@"
                {""Logic"": ""Or"",
                ""Filters"":
                [
                    {""Field"": ""id"", ""Operator"": ""Contains"", ""Value"": """ + TbConditionValue.Text + @""" },
                    {""Field"": ""provinceName"", ""Operator"": ""Contains"", ""Value"": """ + TbConditionValue.Text + @""" },
                    {""Field"": ""cityName"", ""Operator"": ""Contains"", ""Value"": """ + TbConditionValue.Text + @""" },
                    {""Field"": ""districtName"", ""Operator"": ""Contains"", ""Value"": """ + TbConditionValue.Text + @""" },
                    {""Field"": ""tenantName"", ""Operator"": ""Contains"", ""Value"": """ + TbConditionValue.Text + @""" }
                ]}");
            }
            else
            {
                dyfilter = Json.Deserialize<DynamicFilterInfo>(@"{
                ""Logic"" : ""And"",
                ""Filters"" : [
                    {""Field"": """ + propertiesList[CmbConditionKey.SelectedIndex - 1] + @""", ""Operator"": ""Contains"", ""Value"": """ + TbConditionValue.Text + @""" }
                ]}");
            }

            return dyfilter;
        }
        #endregion


    }
}
