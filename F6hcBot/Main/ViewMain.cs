using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace F6Bot.Main
{
    public partial class ViewMain : CCSkinMain
    {
        public ViewMain()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     投递订单, 到BOSS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPostOrderBoss_Click(object sender, EventArgs e)
        {

        }

        private void btnPanLogin_Click(object sender, EventArgs e)
        {
            this.PanLogin();
        }

        private void ViewMain_Load(object sender, EventArgs e)
        {

        }
    }
}
