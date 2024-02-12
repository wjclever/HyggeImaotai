using hygge_imaotai.Service;
using hygge_imaotai.Utils;
using Sunny.UI;
using System.Windows.Forms;
using hygge_imaotai.Database;
using hygge_imaotai.Database.Model;

namespace hygge_imaotai.UI.Main.Page
{
    /// <summary>
    /// 预约项目子页面
    /// </summary>
    public partial class UserPageCommodities : UIUserControl
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
        public UserPageCommodities(FrmMain frmMain)
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
            DgvCommodityList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvCommodityList.AutoGenerateColumns = false;
            PageCommodity.PageSize = 10;

            foreach (DataGridViewColumn userDataGridViewColumn in DgvCommodityList.Columns)
            {
                userDataGridViewColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        /// <summary>
        /// 控件的默认值初始化
        /// </summary>
        private void ControlValueInit()
        {
            var commodities = _db.Select<Commodity>()
                .Count(out var userCount).Page(1, 10).ToList();
            commodities.ForEach(async i => await i.UpdateImage());
            DgvCommodityList.DataSource = commodities;
            PageCommodity.TotalCount = (int)userCount;
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
            await ImtService.RefreshCommodity();
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
        private void PageCommodity_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            var commodities = _db.Select<Commodity>().Page(pageIndex, 10).ToList();
            commodities.ForEach(async i => await i.UpdateImage());
            DgvCommodityList.DataSource = commodities;
        }

        #endregion

    }
}
