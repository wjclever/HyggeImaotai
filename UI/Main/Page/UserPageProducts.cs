using Sunny.UI;

namespace hygge_imaotai.UI.Main.Page
{
    /// <summary>
    /// 预约项目子页面
    /// </summary>
    public partial class UserPageProducts : UIUserControl
    {
        #region Fields

        private readonly FrmMain _frmMain;

        #endregion

        #region Constructor And Init

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="frmMain"></param>
        public UserPageProducts(FrmMain frmMain)
        {
            InitializeComponent();
            this._frmMain = frmMain;
        }


        #endregion


    }
}
