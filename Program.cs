using System;
using System.Windows.Forms;
using hygge_imaotai.Database;
using hygge_imaotai.Database.Model;

namespace hygge_imaotai
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 数据库创建
            DatabaseRepository.CreateDatabase();
            var tables = new[] { typeof(User), typeof(Commodity), typeof(Log) };
            DB.Sqlite.CodeFirst.SyncStructure(tables);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
