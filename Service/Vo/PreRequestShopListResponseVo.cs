namespace hygge_imaotai.Service.Vo
{
    /// <summary>
    /// 获取门店列表的URL的预请求
    /// </summary>
    public class PreRequestShopListResponseVo
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class AddressConfig
        {
            public string md5 { get; set; }
            public int size { get; set; }
            public string url { get; set; }
            public int version { get; set; }
        }

        public class AddressConfigPc
        {
            public string md5 { get; set; }
            public int size { get; set; }
            public string url { get; set; }
            public int version { get; set; }
        }

        public class AreaConfig
        {
            public string md5 { get; set; }
            public int size { get; set; }
            public string url { get; set; }
            public int version { get; set; }
        }

        public class Data
        {
            public Mtpopupview mtpopupview { get; set; }
            public MtpolyphonicAddress mtpolyphonicAddress { get; set; }
            public Pagebackground pagebackground { get; set; }
            public Mtshops mtshops { get; set; }
            public AddressConfigPc addressConfig_pc { get; set; }
            public AddressConfig addressConfig { get; set; }
            public AreaConfig areaConfig { get; set; }
            public MtshopsPc mtshops_pc { get; set; }
            public Mtappconfig mtappconfig { get; set; }
            public Mttracking mttracking { get; set; }
        }

        public class Mtappconfig
        {
            public string md5 { get; set; }
            public int size { get; set; }
            public string url { get; set; }
            public int version { get; set; }
        }

        public class MtpolyphonicAddress
        {
            public string md5 { get; set; }
            public int size { get; set; }
            public string url { get; set; }
            public int version { get; set; }
        }

        public class Mtpopupview
        {
            public string md5 { get; set; }
            public int size { get; set; }
            public string url { get; set; }
            public int version { get; set; }
        }

        public class Mtshops
        {
            public string md5 { get; set; }
            public int size { get; set; }
            public string url { get; set; }
            public int version { get; set; }
        }

        public class MtshopsPc
        {
            public string md5 { get; set; }
            public int size { get; set; }
            public string url { get; set; }
            public int version { get; set; }
        }

        public class Mttracking
        {
            public string md5 { get; set; }
            public int size { get; set; }
            public string url { get; set; }
            public int version { get; set; }
        }

        public class Pagebackground
        {
            public string md5 { get; set; }
            public int size { get; set; }
            public string url { get; set; }
            public int version { get; set; }
        }

        public int code { get; set; }
        public Data data { get; set; }


    }
}
