namespace hygge_imaotai.Config
{
    /// <summary>
    /// 系统的通用配置项
    /// </summary>
    public class CommonConfiguration
    {
        #region Fields

        /// <summary>
        /// 单例模式
        /// </summary>
        private static readonly CommonConfiguration Instance = new CommonConfiguration();

        #endregion

        #region Properties
        /// <summary>
        /// 会话Id
        /// </summary>
        public string sessionId { get; set; }

        #endregion


        #region Functions

        /// <summary>
        /// 获取实例
        /// </summary>
        /// <returns></returns>
        public static CommonConfiguration GetInstance()
        {
            return Instance;
        }

        #endregion
    }
}
