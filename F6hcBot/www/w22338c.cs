using F6Bot.HttpUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F6Bot.www
{
    public class w22338c
    {
        private string _root = "https://w3.22338c.com";

        private bool _isLogin;
        /// <summary>
        ///     是否登录成功
        /// </summary>
        public bool isLogin { get { return _isLogin; } }

        public w22338c()
        {

        }

        public bool Login()
        {
            //https://w3.22338c.com/index.php/Login?t=1671611077
            HttpHelper http = new HttpHelper();
            string timeStamp = http.GetTimeStamp();

            string loginUrl = $"{_root}/index.php/Login?t={timeStamp}";
            
            HttpItem item = new HttpItem()
            {
                Method = "POST",

            };
            var hr = http.GetHtml(item);
            return _isLogin;
        }
    }
}
