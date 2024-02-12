using System.IO;

namespace hygge_imaotai.Database
{
    /// <summary>
    /// 共用数据库操作类
    /// </summary>
    public class DatabaseRepository
    {
        public static void CreateDatabase()
        {
            if (File.Exists(Env.DatabasePath)) return;
            // 创建文件夹和数据库
            Directory.CreateDirectory("storage/database");
            SQLiteConnection.CreateFile(App.DatabasePath);
            var userConnection = new SQLiteConnection(App.DatabaseConnectStr);
            userConnection.Open();
        }

    }
}
