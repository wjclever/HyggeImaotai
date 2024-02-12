using FreeSql.DataAnnotations;

namespace hygge_imaotai.Database.Model
{
    /// <summary>
    /// imaotai 日志模型
    /// </summary>
    [Table(Name = "imt_log")]
    public class Log
    {
        #region Properties
        [Column(IsPrimary = true, IsIdentity = true)]
        public long id { get; set; }
        /// <summary>
        /// 日志记录内容
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 操作人员手机号
        /// </summary>
        public long mobile { get; set; }
        /// <summary>
        /// 操作状态(0-正常,1-异常)
        /// </summary>
        public int status { get; set; }


        #endregion
    }
}
