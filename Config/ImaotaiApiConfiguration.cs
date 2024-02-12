namespace hygge_imaotai.Config
{
    public class ImaotaiApiConfiguration
    {
        #region Properties
        /// <summary>
        /// 获取SessionId的URL
        /// </summary>
        public string getSessionId { get; set; }

        /// <summary>
        /// 获取门店列表URL的预先请求
        /// </summary>
        public string preRequestShopList { get; set; }
        #endregion
    }
}
