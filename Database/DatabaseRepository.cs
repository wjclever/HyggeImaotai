using System.Data.SQLite;
using System.IO;

namespace hygge_imaotai.Database
{
    /// <summary>
    /// 共用数据库操作类
    /// </summary>
    public class DatabaseRepository
    {
        /// <summary>
        /// 创建应用程序对应的数据库文件
        /// </summary>
        public static void CreateDatabase()
        {
            if (File.Exists(Env.DatabasePath)) return;
            // 创建文件夹和数据库
            Directory.CreateDirectory("storage/database");
            SQLiteConnection.CreateFile(Env.DatabasePath);
            var userConnection = new SQLiteConnection(Env.DatabaseConnectStr);
            userConnection.Open();
        }

    }
}
