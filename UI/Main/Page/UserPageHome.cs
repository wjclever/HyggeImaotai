using Sunny.UI;

namespace hygge_imaotai.UI.Main.Page
{
    public partial class UserPageHome : UIUserControl
    {
        #region Fields

        private FrmMain _frmMain;

        #endregion

        #region Constructor

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="frmMain"></param>
        public UserPageHome(FrmMain frmMain)
        {
            InitializeComponent();
            this._frmMain = frmMain;
        }

        #endregion


    }
}
