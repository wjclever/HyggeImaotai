using System;
using System.Collections.Generic;
using FreeSql.DataAnnotations;

namespace hygge_imaotai.Database.Model
{
    /// <summary>
    /// imaotai 日志模型
    /// </summary>
    [Table(Name = "imt_shop")]
    public class Shop
    {
        #region Properties
        [Column(IsPrimary = true)]
        public string id { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        public string provinceName { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public string cityName { get; set; }
        /// <summary>
        /// 地区
        /// </summary>
        public string districtName { get; set; }

        /// <summary>
        /// 完整地址
        /// </summary>
        public string fullAddress { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public string lat { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public string lng { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        public string tenantName { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime createTime { get; set; }

        #endregion

        #region Dynamic Properties
        /// <summary>
        /// 参数信息
        /// </summary>
        [Column(IsIgnore = true)]
        private Dictionary<string, object> param { get; set; }

        /// <summary>
        /// 距离
        /// </summary>
        [Column(IsIgnore = true)]
        private double distance { get; set; }

        #endregion

        #region Constructor

        public Shop(string id, string provinceName, string cityName, string districtName, string fullAddress, string lat, string lng, string name, string tenantName)
        {
            this.id = id;
            this.provinceName = provinceName;
            this.cityName = cityName;
            this.districtName = districtName;
            this.fullAddress = fullAddress;
            this.lat = lat;
            this.lng = lng;
            this.name = name;
            this.tenantName = tenantName;
            this.createTime = DateTime.Now;
        }

        #endregion
    }
}
