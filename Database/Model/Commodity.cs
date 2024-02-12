using System;
using FreeSql.DataAnnotations;

namespace hygge_imaotai.Database.Model
{
    /// <summary>
    /// imaotai 预约商品模型
    /// </summary>
    [Table(Name = "imt_commodity")]
    public class Commodity
    {
        #region Properties

        /// <summary>
        /// 商品code
        /// </summary>
        [Column(IsPrimary = true)]
        public string itemCode { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string picture { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime createTime { get; set; }

        #endregion

        #region Constructor

        public Commodity(string itemCode, string title, string content, string picture)
        {
            this.itemCode = itemCode;
            this.title = title;
            this.content = content;
            this.picture = picture;
            this.createTime = DateTime.Now;
        }

        #endregion

    }
}
