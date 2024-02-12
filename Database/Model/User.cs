using FreeSql.DataAnnotations;

namespace hygge_imaotai.Database.Model
{
    /// <summary>
    /// imaotai 用户模型
    /// </summary>
    [Table(Name = "imt_user")]
    public class User
    {
        #region Properties

        /// <summary>
        /// 手机号
        /// </summary>
        [Column(IsPrimary = true)]
        public long mobile { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public long userId { get; set; }
        /// <summary>
        /// token
        /// </summary>
        public string token { get; set; }
        /// <summary>
        /// cookie
        /// </summary>
        public string cookie { get; set; }
        /// <summary>
        /// 设备id
        /// </summary>
        public string deviceId { get; set; }
        /// <summary>
        /// 商品预约code,用@间隔
        /// </summary>
        public string itemCode { get; set; }
        /// <summary>
        /// 完整地址
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int minute { get; set; }
        /// <summary>
        /// 随机分钟预约,9点取一个时间(0:随机,1:不随机)
        /// </summary>
        public string randomMinute { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public int shopType { get; set; }
        /// <summary>
        /// 门店商品ID
        /// </summary>
        public string ishopId { get; set; }
        /// <summary>
        /// push_plus_token
        /// </summary>
        public string pushPlusToken { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }


        #endregion
    }
}
