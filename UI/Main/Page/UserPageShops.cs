using Sunny.UI;

namespace hygge_imaotai.UI.Main.Page
{
    /// <summary>
    /// 门店列表子页面
    /// </summary>
    public partial class UserPageShops : UIUserControl
    {
        #region Fields

        private readonly FrmMain _frmMain;

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
        }


        #endregion
    }
}
