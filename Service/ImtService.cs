using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Flurl.Http;
using hygge_imaotai.Config;
using hygge_imaotai.Database;
using hygge_imaotai.Database.Model;
using hygge_imaotai.Service.Vo;
using hygge_imaotai.Utils;
using NLog;
using Sunny.UI;

namespace hygge_imaotai.Service
{
    /// <summary>
    /// imaotai 业务处理类
    /// </summary>
    public class ImtService
    {
        #region Fields
        /// <summary>
        /// 日志工具类
        /// </summary>
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// 数据库操作对象
        /// </summary>
        private static readonly IFreeSql Db = DB.Sqlite;

        #endregion

        /// <summary>
        /// 刷新商品列表
        /// </summary>
        /// <returns></returns>
        public static async Task RefreshCommodity()
        {
            // 清空sessionId
            ConfigurationUtil.commonConfigurationInstance.sessionId = string.Empty;
            ConfigurationUtil.SaveConfig<CommonConfiguration>();
            // 刷新商品列表
            await GetCurrentSessionId();
        }

        /// <summary>
        /// 刷新门店列表
        /// </summary>
        /// <returns></returns>
        public static async Task RefreshShop()
        {
            // 获取门店列表的url 预请求
            var response = await ConfigurationUtil.imaotaiApiConfiguration.preRequestShopList
                .GetJsonAsync<PreRequestShopListResponseVo>();
            var shopListUrl = response.data.mtshops_pc.url;
            // 清空数据库
            await Db.Delete<Shop>().Where("1=1").ExecuteAffrowsAsync();
            // 存储shopList
            var shopList = new List<Shop>();
            var shopListResponse = await shopListUrl.GetStringAsync();
            using (var document = JsonDocument.Parse(shopListResponse))
            {
                var root = document.RootElement;
                foreach (var property in root.EnumerateObject())
                {
                    var shopId = property.Name;
                    var shop = Json.Deserialize<ShopResponseVo>(property.Value.GetRawText());
                    shopList.Add(new Shop(shopId, shop.provinceName, shop.cityName, shop.districtName, shop.fullAddress
                    , shop.lat + "", shop.lng + "", shop.name, shop.tenantName));
                }
            }

            var addRowCount = Db.Insert<Shop>(shopList).ExecuteAffrowsAsync();
        }

        /// <summary>
        /// 获取最新的Session会话Id
        /// </summary>
        /// <returns></returns>
        public static async Task<string> GetCurrentSessionId()
        {
            var sessionId = ConfigurationUtil.commonConfigurationInstance.sessionId;
            var dayTime = GetDayTime();
            if (!string.IsNullOrEmpty(sessionId)) return sessionId;

            // 开始网络请求来获取SessionId
            var response = await (ConfigurationUtil.imaotaiApiConfiguration.getSessionId + dayTime)
                .GetJsonAsync<GetSessionIdResponseVo>();
            if (response.code != 2000)
            {
                Logger.Error($"更新SessionId出现异常,数据如下:" + response);
                throw new CustomException("更新SessionId出现异常");
            };
            // 将SessionId写入文件
            ConfigurationUtil.commonConfigurationInstance.sessionId = response.data.sessionId + "";
            // 删除商品全表数据
            await Db.Delete<Commodity>().Where("1=1").ExecuteAffrowsAsync();
            // 增加数据
            var list = response.data.itemList
                .Select(item => new Commodity(item.itemCode, item.title, item.content, item.picture))
                .ToList();
            var addRowCount = await Db.Insert<Commodity>(list).ExecuteAffrowsAsync();
            return response.data.sessionId + "";
        }

        /// <summary>
        /// 获取时间戳参数,
        /// eg:1707667200000 == 2024-02-12 00:00:00
        /// </summary>
        /// <returns></returns>
        private static long GetDayTime()
        {
            var midNight = DateTime.Now.Date;
            var epochStart = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.FromHours(8));
            var timeSpan = midNight.AddHours(-8) - epochStart;
            var milliseconds = (long)timeSpan.TotalMilliseconds;
            return milliseconds;
        }
    }
}
