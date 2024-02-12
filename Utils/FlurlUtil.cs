using NLog;
using Polly;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using Flurl.Http;
using Polly.Retry;

namespace hygge_imaotai.Utils
{
    /// <summary>
    /// 网络请求框架的工具类
    /// </summary>
    public class FlurlUtil
    {
        #region Fields
        /// <summary>
        /// 日志工具类
        /// </summary>
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        #endregion

        /// <summary>
        /// 网络请求类的初始化
        /// </summary>
        public static void FlurlInit()
        {
            // 网络配置
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3
                                                   | SecurityProtocolType.Tls
                                                   | SecurityProtocolType.Tls11
                                                   | SecurityProtocolType.Tls12;
            // Policy策略配置
            var globalPolicy = GetGlobalPolicy();

            FlurlHttp.Clients.WithDefaults(builder => builder.AddMiddleware(() => new PollyHandler(globalPolicy)));
        }

        /// <summary>
        /// 获取全局的Policy策略
        /// </summary>
        /// <returns></returns>
        private static AsyncRetryPolicy<HttpResponseMessage> GetGlobalPolicy()
        {
            var globalPolicy = Policy
                .Handle<HttpRequestException>()
                .OrResult<HttpResponseMessage>(r => !r.IsSuccessStatusCode)
                .WaitAndRetryAsync(new[]
                {
                    TimeSpan.FromSeconds(3),
                    TimeSpan.FromSeconds(3),
                    TimeSpan.FromSeconds(3)
                }, (res, timeSpan) =>
                {
                    var stringBuffer = new StringBuilder();
                    stringBuffer.Append($"===========START============={Environment.NewLine}");
                    if (res.Result != null)
                    {
                        stringBuffer.Append($"请求URL:{res.Result.RequestMessage.RequestUri}{Environment.NewLine}");
                        stringBuffer.Append($"请求方法:{res.Result.RequestMessage.Method}{Environment.NewLine}");
                    }

                    if (res.Exception == null) return;
                    stringBuffer.Append($"错误原因:{res.Exception.Message}{Environment.NewLine}");
                    stringBuffer.Append($"堆栈信息:{res.Exception.StackTrace}{Environment.NewLine}");
                    stringBuffer.Append($"产生错误,已自动进行重试{Environment.NewLine}");
                    stringBuffer.Append($"===========END============={Environment.NewLine}");
                    Logger.Error(res.Exception, stringBuffer.ToString());
                });
            return globalPolicy;
        }
    }
}
