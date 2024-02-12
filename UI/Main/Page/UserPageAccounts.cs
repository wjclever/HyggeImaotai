using Sunny.UI;

namespace hygge_imaotai.UI.Main.Page
{
    /// <summary>
    /// 用户管理子页面
    /// </summary>
    public partial class UserPageAccounts : UIUserControl
    {
        #region Fields

        private readonly FrmMain _frmMain;

        #endregion

        #region Constructor And Init

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="frmMain"></param>
        public UserPageAccounts(FrmMain frmMain)
        {
            InitializeComponent();
            this._frmMain = frmMain;
        }
        

        #endregion
    }
}
