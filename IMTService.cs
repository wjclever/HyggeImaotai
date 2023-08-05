﻿using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using hygge_imaotai.Domain;
using hygge_imaotai.Entity;
using hygge_imaotai.Repository;
using hygge_imaotai.UserInterface.Component;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NLog;
using System.Threading;

namespace hygge_imaotai
{
    public class IMTService
    {

        #region Fields
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();


        #endregion


        private const string Salt = "2af72f100c356273d46284f6fd1dfc08";
        private static string _mtVersion = "";
        private const string AesKey = "qbhajinldepmucsonaaaccgypwuvcjaa";
        private const string AesIv = "2018534749963515";

        private static string Signature(string content, long timestamp)
        {
            var text = Salt + content + timestamp;
            using var md = MD5.Create();
            var hashBytes = md.ComputeHash(Encoding.UTF8.GetBytes(text));
            var sb = new StringBuilder();
            foreach (var b in hashBytes)
            {
                sb.Append($"{b:X2}");
            }
            return sb.ToString().ToLower();
        }

        /// <summary>
        /// 获得i茅台版本号
        /// </summary>
        /// <returns></returns>
        private static async Task<string> GetMtVersion()
        {
            if (!string.IsNullOrEmpty(_mtVersion)) return _mtVersion;
            var htmlSource = await "https://apps.apple.com/cn/app/i%E8%8C%85%E5%8F%B0/id1600482450"
                .GetStringAsync();
            var pattern = new Regex(@"new__latest__version\"">(.*?)<\/p>", RegexOptions.Singleline);
            var matcher = pattern.Match(htmlSource);
            var replace = "";
            if (!matcher.Success) return replace;
            var mtVersion = matcher.Groups[1].Value;
            replace = mtVersion.Replace("版本 ", "");
            _mtVersion = replace;
            return replace;
        }

        /// <summary>
        /// 向手机号发送验证码
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<bool> SendCode(string phone)
        {
            var client = new HttpClient();
            var timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            var values = new Dictionary<string, string>
        {
            { "mobile", phone },
            { "md5", Signature(phone,timestamp) },
            {"timestamp",timestamp+""}
        };
            var content = new StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "iOS;16.3;Apple;?unrecognized?");
            client.DefaultRequestHeaders.Add("MT-Lat", "28.499562");
            client.DefaultRequestHeaders.Add("MT-K", "1675213490331");
            client.DefaultRequestHeaders.Add("MT-Lng", "102.182324");
            client.DefaultRequestHeaders.Add("Host", "app.moutai519.com.cn");
            client.DefaultRequestHeaders.Add("MT-User-Tag", "0");
            client.DefaultRequestHeaders.Add("MT-Network-Type", "WIFI");
            client.DefaultRequestHeaders.TryAddWithoutValidation("MT-Team-ID", "");
            client.DefaultRequestHeaders.Add("MT-Info", "028e7f96f6369cafe1d105579c5b9377");
            client.DefaultRequestHeaders.Add("MT-Device-ID", "2F2075D0-B66C-4287-A903-DBFF6358342A");
            client.DefaultRequestHeaders.Add("MT-Bundle-ID", "com.moutai.mall");
            client.DefaultRequestHeaders.Add("Accept-Language", "en-CN;q=1, zh-Hans-CN;q=0.9");
            client.DefaultRequestHeaders.Add("MT-Request-ID", "167560018873318465");
            client.DefaultRequestHeaders.Add("MT-APP-Version", await GetMtVersion());
            client.DefaultRequestHeaders.Add("MT-R", "clips_OlU6TmFRag5rCXwbNAQ/Tz1SKlN8THcecBp/HGhHdw==");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Length", "93");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            client.DefaultRequestHeaders.Add("Connection", "keep-alive");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
            var response = await client
                .PostAsync("https://app.moutai519.com.cn/xhr/front/user/register/vcode", content);
            var responseString = await response.Content.ReadAsStringAsync();
            var responseJson = JObject.Parse(responseString);
            var code = (string)responseJson["code"];
            if (code == "2000") return true;
            throw new Exception(responseString);
        }

        /// <summary>
        /// 发送用户登录请求
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<bool> Login(string phone, string code)
        {
            var client = new HttpClient();
            var timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            var values = new Dictionary<string, string>
            {
                { "mobile", phone },
                { "ydToken", "" },
                {"vCode",code},
                {"ydLogId",""},
                {"md5",Signature(phone + code + "" + "",timestamp)},
                {"timestamp",timestamp+""},
                {"MT-APP-Version",await GetMtVersion()}
            };
            var content = new StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "iOS;16.3;Apple;?unrecognized?");
            client.DefaultRequestHeaders.Add("MT-Lat", "28.499562");
            client.DefaultRequestHeaders.Add("MT-K", "1675213490331");
            client.DefaultRequestHeaders.Add("MT-Lng", "102.182324");
            client.DefaultRequestHeaders.Add("Host", "app.moutai519.com.cn");
            client.DefaultRequestHeaders.Add("MT-User-Tag", "0");
            client.DefaultRequestHeaders.Add("MT-Network-Type", "WIFI");
            client.DefaultRequestHeaders.TryAddWithoutValidation("MT-Team-ID", "");
            client.DefaultRequestHeaders.Add("MT-Info", "028e7f96f6369cafe1d105579c5b9377");
            client.DefaultRequestHeaders.Add("MT-Device-ID", "2F2075D0-B66C-4287-A903-DBFF6358342A");
            client.DefaultRequestHeaders.Add("MT-Bundle-ID", "com.moutai.mall");
            client.DefaultRequestHeaders.Add("Accept-Language", "en-CN;q=1, zh-Hans-CN;q=0.9");
            client.DefaultRequestHeaders.Add("MT-Request-ID", "167560018873318465");
            client.DefaultRequestHeaders.Add("MT-APP-Version", await GetMtVersion());
            client.DefaultRequestHeaders.Add("MT-R", "clips_OlU6TmFRag5rCXwbNAQ/Tz1SKlN8THcecBp/HGhHdw==");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Length", "93");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            client.DefaultRequestHeaders.Add("Connection", "keep-alive");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
            var response = await client
                .PostAsync("https://app.moutai519.com.cn/xhr/front/user/register/login", content);
            var responseString = await response.Content.ReadAsStringAsync();
            var responseJson = JObject.Parse(responseString);
            var responseCode = (string)responseJson["code"];
            if (responseCode != "2000") throw new Exception(responseJson.TryGetValue("message", out var value) ? value.Value<string>() : responseString);
            // 存储一下数据
            var foundUserEntity = UserManageViewModel.UserList.FirstOrDefault(user => user.Mobile == phone);
            if (foundUserEntity != null)
            {
                UserRepository.UpdateUser(new UserEntity(phone,responseJson));
            }
            else
            {
                UserRepository.InsertUser(new UserEntity(phone, responseJson));
            }
            return true;
        }

        /// <summary>
        /// 预约方法
        /// </summary>
        /// <param name="userEntity"></param>
        public static async void Reservation(UserEntity userEntity)
        {
            var items = userEntity.ItemCode.Split("@");

            try
            {
                foreach (var item in items)
                {
                    var shopId = await ShopRepository.GetShopId(userEntity.ShopType, item, userEntity.ProvinceName, userEntity.CityName, userEntity.Lat, userEntity.Lng);
                    if (!string.IsNullOrEmpty(shopId))
                    {
                        await Reservation(userEntity, item, shopId);
                    }

                }
            }
            catch (Exception ex)
            {
                LogRepository.InsertLog(new LogEntity()
                {
                    CreateTime = DateTime.Now,
                    MobilePhone = userEntity.Mobile,
                    Content = $"[userId]:{userEntity.UserId}",
                    Response = ex.Message,
                    Status = "异常"
                });
                new MessageBoxCustom("预约请求失败,响应结果详细请查看日志", MessageType.Error, MessageButtons.Ok).ShowDialog();
                return;
            }
            new MessageBoxCustom("手动发起预约成功,响应结果请查看日志", MessageType.Success, MessageButtons.Ok).ShowDialog();
        }


        public static async Task Reservation(UserEntity user, string itemId, string shopId)
        {
            var client = new HttpClient();

            var info = new Dictionary<string, object>
            {
                { "itemId", itemId },
                { "count", 1 }
            };

            var values = new Dictionary<string, object>
            {
                { "itemInfoList", new List<Dictionary<string, object>>() { info } },
                { "sessionId",await GetCurrentSessionId() },
                {"shopId",shopId},
                {"userId",user.UserId + ""}
            };
            values.Add("actParam", EncryptAES_CBC(JsonConvert.SerializeObject(values).Replace("\\\"", "\"")));

            client.DefaultRequestHeaders.Add("MT-Lat", user.Lat);
            client.DefaultRequestHeaders.Add("MT-K", "1675213490331");
            client.DefaultRequestHeaders.Add("MT-Lng", user.Lng);
            client.DefaultRequestHeaders.Add("Host", "app.moutai519.com.cn");
            client.DefaultRequestHeaders.Add("MT-User-Tag", "0");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
            client.DefaultRequestHeaders.Add("MT-Network-Type", "WIFI");
            client.DefaultRequestHeaders.TryAddWithoutValidation("MT-Token", user.Token);
            client.DefaultRequestHeaders.TryAddWithoutValidation("MT-Team-ID", "");
            client.DefaultRequestHeaders.Add("MT-Info", "028e7f96f6369cafe1d105579c5b9377");
            client.DefaultRequestHeaders.Add("MT-Device-ID", "2F2075D0-B66C-4287-A903-DBFF6358342A");
            client.DefaultRequestHeaders.Add("MT-Bundle-ID", "com.moutai.mall");
            client.DefaultRequestHeaders.Add("Accept-Language", "en-CN;q=1, zh-Hans-CN;q=0.9");
            client.DefaultRequestHeaders.Add("MT-Request-ID", "167560018873318465");
            client.DefaultRequestHeaders.Add("MT-APP-Version", await GetMtVersion());
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "iOS;16.3;Apple;?unrecognized?");
            client.DefaultRequestHeaders.Add("MT-R", "clips_OlU6TmFRag5rCXwbNAQ/Tz1SKlN8THcecBp/HGhHdw==");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Length", "93");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            client.DefaultRequestHeaders.Add("Connection", "keep-alive");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
            client.DefaultRequestHeaders.TryAddWithoutValidation("userId", user.UserId + "");

            var content = new StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json");

            var response = await client
                .PostAsync("https://app.moutai519.com.cn/xhr/front/mall/reservation/add", content);
            var responseString = await response.Content.ReadAsStringAsync();
            var responseJson = JObject.Parse(responseString);

            LogRepository.InsertLog(new LogEntity()
            {
                CreateTime = DateTime.Now,
                MobilePhone = user.Mobile,
                Content = $"[userId]:{user.UserId} [shopId]:{itemId}",
                Response = responseString,
                Status = responseJson["code"].Value<int>() == 2000 ? "预约成功" : "预约失败"
            });
        }

        /// <summary>
        /// AES CBC加密函数
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string EncryptAES_CBC(string input)
        {
            var key = Encoding.UTF8.GetBytes(AesKey);
            var iv = Encoding.UTF8.GetBytes(AesIv);

            using var aes = Aes.Create();
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            aes.Key = key;
            aes.IV = iv;

            var encryptor = aes.CreateEncryptor();

            var inputBytes = Encoding.UTF8.GetBytes(input);
            var encryptedBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

            var base64String = Convert.ToBase64String(encryptedBytes);
            return base64String;
        }

        /// <summary>
        /// 获取当前会话的专属ID,并更新商品列表数据
        /// </summary>
        /// <returns></returns>
        public static async Task<string> GetCurrentSessionId()
        {
            var mtSessionId = App.MtSessionId;
            if (!string.IsNullOrEmpty(mtSessionId)) return mtSessionId;

            var midNight = DateTime.Now.Date;
            var epochStart = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.FromHours(8));
            var timeSpan = midNight.AddHours(-8) - epochStart;
            var milliseconds = (long)timeSpan.TotalMilliseconds;

            var responseStr = await ("https://static.moutai519.com.cn/mt-backend/xhr/front/mall/index/session/get/" +
                                    milliseconds)
                .GetStringAsync();
            var jObject = JObject.Parse(responseStr);
            if (jObject.GetValue("code").Value<int>() == 2000)
            {
                var dataJObject = jObject["data"];
                App.MtSessionId = dataJObject["sessionId"].Value<string>();
                var itemList = (JArray)dataJObject["itemList"];
                foreach (var itemElement in itemList)
                {
                    AppointProjectViewModel.ProductList.Add(new ProductEntity(itemElement["itemCode"].Value<string>(),
                        itemElement["title"].Value<string>(),
                        itemElement["content"].Value<string>(),
                        itemElement["picture"].Value<string>(), DateTime.Now));
                }
                App.WriteCache("productList.json", JsonConvert.SerializeObject(AppointProjectViewModel.ProductList));
                App.WriteCache("mtSessionId.txt", App.MtSessionId);
            }

            return mtSessionId;
        }

        /// <summary>
        /// 批量预约
        /// </summary>
        public static void ReservationBatch()
        {
            var users = UserRepository.GetReservationUser();
            foreach (var userEntity in users)
            {
                try
                {
                    Logger.Info($"「开始预约用户」{userEntity.Mobile}");
                    Reservation(userEntity);
                }
                catch (Exception e)
                {
                    Logger.Error($"用户{userEntity.Mobile}预约产生异常,错误原因:{e.Message}");
                    LogRepository.InsertLog(new LogEntity()
                    {
                        CreateTime = DateTime.Now,
                        MobilePhone = userEntity.Mobile,
                        Content = $"[userId]:{userEntity.UserId}",
                        Response = e.Message,
                        Status = "异常"
                    });
                }
            }
        }

        public static async void RefreshAll()
        {
            _mtVersion = string.Empty;
            await GetMtVersion();
            await RefreshShop();
            App.MtSessionId = string.Empty;
            await GetCurrentSessionId();
        }

        public static async Task RefreshShop()
        {
            StoreListViewModel.StoreList.Clear();
            ShopRepository.TruncateTable();

            var responseStr = await "https://static.moutai519.com.cn/mt-backend/xhr/front/mall/resource/get"
                .GetStringAsync();
            var jObject = JObject.Parse(responseStr);
            var shopsUrl = jObject.GetValue("data").Value<JObject>().GetValue("mtshops_pc").Value<JObject>().GetValue("url").Value<string>();
            var shopInnerJson = await shopsUrl.GetStringAsync();

            var shopInnerJObject = JObject.Parse(shopInnerJson);
            Task task = Task.Run(() =>
            {
                foreach (var property in shopInnerJObject.Properties())
                {
                    var shopId = property.Name;
                    var nestedObject = (JObject)property.Value;
                    ShopRepository.InsertShop(new StoreEntity(shopId, nestedObject));
                }
            });
            await task;
        }
    }
}
