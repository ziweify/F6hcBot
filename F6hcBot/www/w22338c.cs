using FUniti.Http;
using FUniti.SystemExtend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F6Bot.www
{
    public class W22338c
    {
        private string _root = "https://w3.22338c.com";

        private bool _isLogin;
        /// <summary>
        ///     是否登录成功
        /// </summary>
        public bool isLogin { get { return _isLogin; } }

        public W22338c()
        {

        }

        /*
         * 第一次请求
         * Request URL: https://w3.22338c.com/
Request Method: GET
Status Code: 200  (from disk cache)
Remote Address: 172.67.188.227:443
Referrer Policy: strict-origin-when-cross-origin
alt-svc: h3=":443"; ma=86400, h3-29=":443"; ma=86400
cf-cache-status: DYNAMIC
cf-ray: 77d1f74f3875d021-SJC
content-encoding: br
content-type: text/html; charset=UTF-8
date: Wed, 21 Dec 2022 16:24:06 GMT
last-modified: Wed, 19 Oct 2022 07:57:02 GMT
nel: {"success_fraction":0,"report_to":"cf-nel","max_age":604800}
report-to: {"endpoints":[{"url":"https:\/\/a.nel.cloudflare.com\/report\/v3?s=7LGGRyB7YjE%2Bngfy%2FyHHR9bRRoh2kW2EhSqSUfya14XJ%2Bs8Fcwck%2B0RbIRbTrcvWBYdRBXZ9Mdiiun0OlUl2771n9kwwGoclz7LxSzWwr1uS7u1AW3DW9tGMmtcifMjY"}],"group":"cf-nel","max_age":604800}
server: cloudflare
vary: Accept-Encoding
         */

        public bool Login(string userName, string pwd)
        {
            //https://w3.22338c.com
            //https://w3.22338c.com/index.php/Login?t=1671611077
            HttpHelper http = new HttpHelper();
            string timeStamp = http.GetTimeStamp();

            string loginUrl = $"{_root}/index.php/Login?t={timeStamp}";
            FRanDom random = new FRanDom();
            int x = random.Next(7, 40);
            int y = random.Next(10, 28);
            string postdata = $"act=userlogin&username={userName}&pwd={pwd}&token=&x={x}&y={y}&f={timeStamp}";

            HttpItem item = new HttpItem()
            {
                Method = "POST",
                Postdata = postdata,
                Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9",
            };
            //item.Header.Add("sec-ch-ua-platform: \"Windows\"");
            //item.Header.Add("sec-fetch-dest: document");
            var hr = http.GetHtml(item);


            return _isLogin;
        }
    }
}
