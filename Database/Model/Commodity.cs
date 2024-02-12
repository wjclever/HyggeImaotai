using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using Flurl.Http;
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

        #region Dynamic Properties

        /// <summary>
        /// 动态生成商品图标
        /// </summary>
        [Column(IsIgnore = true)]
        public Image image { get; set; }

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

        #region Functions
        /// <summary>
        /// 根据属性picture为属性image赋值图片
        /// </summary>
        /// <returns></returns>
        public async Task UpdateImage()
        {
            var response = await picture.GetStreamAsync();
            image = Image.FromStream(response);

            var bitmap = new Bitmap(70, 60,PixelFormat.Format32bppArgb);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, 70, 60);
            }
            image = bitmap;
        }
        #endregion

    }
}
