using hygge_imaotai.Config;

namespace hygge_imaotai
{
    /// <summary>
    /// 全局环境变量
    /// </summary>
    public class Env
    {
        #region Constants 
        /// <summary>
        /// 数据库文件路径
        /// </summary>
        public static string DatabasePath = "storage/database/imaotai.db";

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static string DatabaseConnectStr = "Data Source=" + DatabasePath + "; Version=3";

        /// <summary>
        /// 存储配置文件的路径
        /// </summary>
        public static string ConfigStoragePath = "storage/config";

        

        #endregion
    }
}
