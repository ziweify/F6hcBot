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


        public static bool PanLogin()
        {
            return true;
        }
    }
}
