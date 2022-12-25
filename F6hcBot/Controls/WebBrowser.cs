using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace F6Bot.Controls
{
    public partial class WebBrowser : CCSkinMain
        , INotifyPropertyChanged
    {
        private string _url = "";
        public string url
        {
            get { return _url; }
            set
            {
                if (_url == value)
                    return;
                _url = value;
                NotifyPropertyChanged(() => url);
            }
        }

        public WebBrowser()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged<T>(Expression<Func<T>> property)
        {
            if (PropertyChanged == null)
                return;

            var memberExpression = property.Body as MemberExpression;
            if (memberExpression == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(memberExpression.Member.Name));
        }

        private void View_Load(object sender, EventArgs e)
        {
            EO.WebBrowser.Runtime.AddLicense("Kb114+30EO2s3OmxGeCm3MGz8M5nzunz7fGo7vf2HaF3s7P9FOKe5ff2EL112PD9GvZ3s+X1D5+t8PT26KF+xrLUE/Go5Omzy5+v3PYEFO6ntKbC461pmaTA6bto2PD9GvZ3s/MDD+SrwPL3Gp+d2Pj26KFpqbPC3a5rp7XIzZ+v3PYEFO6ntKbC46FotcAEFOan2PgGHeR36d7SGeWawbMKFOervtrI9eBysO3XErx2s7MEFOan2PgGHeR3s7P9FOKe5ff26XXj7fQQ7azcws0X6Jzc8gQQyJ21tMbbtnCttcbcs3Wm8PoO5Kfq6doP");
            tbxUrl.DataBindings.Add("Text", this,  nameof(this.url));
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            OpenUrl();
        }

        //---------------------------------------公共方法---------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public void OpenUrl()
        {
            webView1.LoadUrlAndWait(url);
        }

        private void View_Shown(object sender, EventArgs e)
        {
            url = "https://w3.22338c.com";
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //执行js
            webView1.EvalScript("username.value = \"v8533\";");
            webView1.EvalScript("pwd.value = \"aa22558822\";");
            webView1.EvalScript("pwd.value = \"aa22558822\";");
        }

        private void btnCookie_Click(object sender, EventArgs e)
        {
            //在EO.WebBrowser中有Engine 对象
            EO.WebEngine.Engine wengine = webView1.Engine;
            //通过Engine的CookieManager方法就可以访问cookie
            //string sc = wengine.CookieManager.GetCookies().ToString();
        }
    }
}
