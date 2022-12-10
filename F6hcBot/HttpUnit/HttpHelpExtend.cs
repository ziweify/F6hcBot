using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace F6Bot.HttpUnit
{
    public static class HttpHelpExtend
    {
        public static string GetTimeStamp(this HttpHelper http)
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }


        /// <summary>
        ///     GET方式: 下载网页上的图片文件
        ///     失败返回 null
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="timeoutMM">等待时间, 毫秒</param>
        /// <returns></returns>
        public static Bitmap GetImage(this HttpHelper http, string imageUrl, int timeoutMM = 10000)
        {
            Bitmap bitmap = null;
            try
            {
                HttpWebRequest req;
                HttpWebResponse res = null;
                System.Uri httpUrl = new System.Uri(imageUrl);
                req = (HttpWebRequest)(WebRequest.Create(httpUrl));
                req.Timeout = timeoutMM; //设置超时值10秒
                req.Method = "GET";
                res = (HttpWebResponse)(req.GetResponse());
                Image image = Image.FromStream(res.GetResponseStream());
                bitmap = new Bitmap(image);
            }
            catch (System.Exception ex)
            {
                bitmap = null;
            }
            return bitmap;
        }
    }
}
