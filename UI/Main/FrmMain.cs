using System.Collections.Generic;
using System.Windows.Forms;
using hygge_imaotai.UI.Main.Page;
using Sunny.UI;

namespace hygge_imaotai
{
    /// <summary>
    /// 主程序窗口
    /// </summary>
    public partial class FrmMain : UIForm
    {
        #region Fields

        /// <summary>
        /// 子页面
        /// </summary>
        private readonly List<UIUserControl> _pages = new List<UIUserControl>();

        #endregion


        #region Constructor And Init
        /// <summary>
        /// 构造方法
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            // 初始化子页面
            // Home页面
            _pages.Add(new UserPageHome(this));
            _pages.Add(new UserPageAccounts(this));
            _pages.Add(new UserPageCommodities(this));
            _pages.ForEach(i => i.Dock = DockStyle.Fill);
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            // 设置默认显示索引0
            UpContent.Controls.Add(_pages[0]);

        }

        #endregion


        #region Control Event

        /// <summary>
        /// 左侧菜单切换选项卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TcmMenus_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpContent.Controls.Clear();
            UpContent.Controls.Add(_pages[TcmMenus.SelectedIndex]);
        }

        #endregion


    }
}
