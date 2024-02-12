using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using hygge_imaotai.Config;

namespace hygge_imaotai.Utils
{
    /// <summary>
    /// 配置工具类
    /// </summary>
    public class ConfigurationUtil
    {
        #region Properties

        /// <summary>
        /// 通用配置类
        /// </summary>
        public static CommonConfiguration commonConfigurationInstance { get; set; }

        /// <summary>
        /// Api配置文件路径
        /// </summary>
        public static ImaotaiApiConfiguration imaotaiApiConfiguration { get; set; }

        #endregion


        /// <summary>
        /// 初始化配置文件
        /// </summary>
        public static void Initialize()
        {
            // 判断config文件夹是否存在,不存在则将进行创建
            if (!Directory.Exists(Env.ConfigStoragePath)) Directory.CreateDirectory(Env.ConfigStoragePath);

            // 1. 判断配置目录下是否存在common.json文件 - 公共配置
            ReadConfiguration<CommonConfiguration>("common.json");

            // 读入系统apis
            var apis = File.ReadAllText("apis.json");
            imaotaiApiConfiguration = JsonSerializer.Deserialize<ImaotaiApiConfiguration>(apis);
        }

        /// <summary>
        /// 根据文件名读取配置文件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        private static void ReadConfiguration<T>(string filename)
        {
            T config = default;
            var json = "";

            if (!File.Exists($"{Env.ConfigStoragePath}/{filename}"))
            {
                using (var userFs = File.Create($"storage/config/{filename}"))
                {
                    switch (filename)
                    {
                        case "common.json":
                            json = JsonSerializer.Serialize(CommonConfiguration.GetInstance());
                            break;
                    }

                    // 写到文件
                    var info = new UTF8Encoding(true).GetBytes(json);
                    userFs.Write(info, 0, info.Length);
                    switch (filename)
                    {
                        case "common.json":
                            commonConfigurationInstance = CommonConfiguration.GetInstance();
                            break;
                    }
                }
            }
            else
            {
                json = File.ReadAllText($"{Env.ConfigStoragePath}/{filename}");
                try
                {
                    config = JsonSerializer.Deserialize<T>(json);
                }
                catch (Exception)
                {
                    config = default;
                }
                finally
                {
                    switch (filename)
                    {
                        case "common.json":
                            commonConfigurationInstance = (config != null) ?
                                config as CommonConfiguration :
                                CommonConfiguration.GetInstance();
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// 保存配置文件
        /// </summary>
        public static void SaveConfig<T>()
        {
            var json = "";
            if (typeof(T) == typeof(CommonConfiguration))
            {
                json = JsonSerializer.Serialize(commonConfigurationInstance);
                File.WriteAllText("storage/config/common.json", json);
            }

        }
    }
}
