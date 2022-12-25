using F6Bot.www;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F6Bot.Main
{
    public static class Controller
    {
        private static ViewMain _view = new ViewMain();
        public static ViewMain getView{ get { return _view; }}

        private static Model _model = new Model();
        public static Model getModel { get { return _model; } }

        //盘口类
        public static W22338c w23333c = new W22338c();


        public static bool PanLogin(this ViewMain view)
        {
            //var wlogin = w23333c.Login("v853", "aa22558822");

            Controls.WebBrowser browser = new Controls.WebBrowser();
            browser.Show();

            return true;
        }
    }
}
