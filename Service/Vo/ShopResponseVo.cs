using System.Collections.Generic;

namespace hygge_imaotai.Service.Vo
{
    /// <summary>
    /// 门店列表的响应每一个门店的实体信息
    /// </summary>
    public class ShopResponseVo
    {
        public string address { get; set; }
        public int city { get; set; }
        public string cityName { get; set; }
        public int district { get; set; }
        public string districtName { get; set; }
        public string fullAddress { get; set; }
        public double lat { get; set; }
        public bool layaway { get; set; }
        public double lng { get; set; }
        public string name { get; set; }
        public string openEndTime { get; set; }
        public string openStartTime { get; set; }
        public int province { get; set; }
        public string provinceName { get; set; }
        public string shopId { get; set; }
        public List<string> tags { get; set; }
        public string tenantName { get; set; }
    }
}
