using System.Collections.Generic;

namespace hygge_imaotai.Service.Vo
{
    /// <summary>
    /// Imt getSessionId ResponseVo
    /// </summary>
    public class GetSessionIdResponseVo
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Banner
        {
            public string pictureUrlV2 { get; set; }
            public string jumpUrl { get; set; }
        }

        public class BlockchainPolicy
        {
            public string title { get; set; }
            public string logo { get; set; }
            public List<Content> content { get; set; }
        }

        public class BlockchainPolicySpecial
        {
            public string title { get; set; }
            public string logo { get; set; }
            public List<Content> content { get; set; }
        }

        public class Content
        {
            public string subtitle { get; set; }
            public List<string> desc { get; set; }
        }

        public class Data
        {
            public List<SessionStatus> sessionStatus { get; set; }
            public int sessionId { get; set; }
            public List<ItemList> itemList { get; set; }
            public IndexShowInfo indexShowInfo { get; set; }
        }

        public class IndexShowInfo
        {
            public List<string> backgroundPicList { get; set; }
            public List<string> backgroundLargerPicList { get; set; }
            public string title { get; set; }
            public ReservationPolicy reservationPolicy { get; set; }
            public BlockchainPolicy blockchainPolicy { get; set; }
            public BlockchainPolicySpecial blockchainPolicySpecial { get; set; }
            public string itemBackgroundPic { get; set; }
            public List<Banner> banner { get; set; }
            public string waitReservePicUrl { get; set; }
            public string waitReserveDesc { get; set; }
        }

        public class ItemList
        {
            public string itemCode { get; set; }
            public string picture { get; set; }
            public string pictureV2 { get; set; }
            public string title { get; set; }
            public string content { get; set; }
            public string jumpUrl { get; set; }
            public int checkTag { get; set; }
        }

        public class ReservationPolicy
        {
            public string title { get; set; }
            public string logo { get; set; }
            public List<Content> content { get; set; }
        }

        public int code { get; set; }
        public Data data { get; set; }

        public class SessionStatus
        {
            public object startTime { get; set; }
            public object endTime { get; set; }
            public int status { get; set; }
            public string buttonText { get; set; }
            public string timeDescPicUrl { get; set; }
            public string tips { get; set; }
            public string changeText { get; set; }
        }


    }
}
