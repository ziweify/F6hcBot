namespace F6Bot.Main
{
    partial class ViewMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMain = new CCWin.SkinControl.SkinTabControl();
            this.tpData = new CCWin.SkinControl.SkinTabPage();
            this.tpSetting = new CCWin.SkinControl.SkinTabPage();
            this.btnPostOrderBoss = new CCWin.SkinControl.SkinButton();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.dgvLogs = new CCWin.SkinControl.SkinDataGridView();
            this.pnlPan = new CCWin.SkinControl.SkinCaptionPanel();
            this.btnPanLogin = new CCWin.SkinControl.SkinButton();
            this.tabMain.SuspendLayout();
            this.tpSetting.SuspendLayout();
            this.skinGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.pnlPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tabMain.BackColor = System.Drawing.Color.Goldenrod;
            this.tabMain.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tabMain.Controls.Add(this.tpData);
            this.tabMain.Controls.Add(this.tpSetting);
            this.tabMain.HeadBack = null;
            this.tabMain.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tabMain.ItemSize = new System.Drawing.Size(70, 26);
            this.tabMain.Location = new System.Drawing.Point(7, 31);
            this.tabMain.Name = "tabMain";
            this.tabMain.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tabMain.PageArrowDown")));
            this.tabMain.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tabMain.PageArrowHover")));
            this.tabMain.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tabMain.PageCloseHover")));
            this.tabMain.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tabMain.PageCloseNormal")));
            this.tabMain.PageDown = ((System.Drawing.Image)(resources.GetObject("tabMain.PageDown")));
            this.tabMain.PageDownTxtColor = System.Drawing.Color.Chartreuse;
            this.tabMain.PageHover = ((System.Drawing.Image)(resources.GetObject("tabMain.PageHover")));
            this.tabMain.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tabMain.PageNorml = null;
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(487, 421);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 0;
            // 
            // tpData
            // 
            this.tpData.BackColor = System.Drawing.Color.White;
            this.tpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpData.Location = new System.Drawing.Point(0, 26);
            this.tpData.Name = "tpData";
            this.tpData.Size = new System.Drawing.Size(487, 395);
            this.tpData.TabIndex = 0;
            this.tpData.TabItemImage = null;
            this.tpData.Text = "数据";
            // 
            // tpSetting
            // 
            this.tpSetting.BackColor = System.Drawing.Color.White;
            this.tpSetting.Controls.Add(this.btnPostOrderBoss);
            this.tpSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpSetting.Location = new System.Drawing.Point(0, 26);
            this.tpSetting.Name = "tpSetting";
            this.tpSetting.Size = new System.Drawing.Size(487, 395);
            this.tpSetting.TabIndex = 1;
            this.tpSetting.TabItemImage = null;
            this.tpSetting.Text = "设置";
            // 
            // btnPostOrderBoss
            // 
            this.btnPostOrderBoss.BackColor = System.Drawing.Color.Transparent;
            this.btnPostOrderBoss.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnPostOrderBoss.DownBack = null;
            this.btnPostOrderBoss.Location = new System.Drawing.Point(3, 3);
            this.btnPostOrderBoss.MouseBack = null;
            this.btnPostOrderBoss.Name = "btnPostOrderBoss";
            this.btnPostOrderBoss.NormlBack = null;
            this.btnPostOrderBoss.Size = new System.Drawing.Size(113, 23);
            this.btnPostOrderBoss.TabIndex = 0;
            this.btnPostOrderBoss.Text = "PostOrder[boss]";
            this.btnPostOrderBoss.UseVisualStyleBackColor = false;
            this.btnPostOrderBoss.Click += new System.EventHandler(this.btnPostOrderBoss_Click);
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.DimGray;
            this.skinGroupBox1.Controls.Add(this.dgvLogs);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox1.Location = new System.Drawing.Point(7, 458);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(487, 293);
            this.skinGroupBox1.TabIndex = 1;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "日志";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // dgvLogs
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLogs.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLogs.ColumnFont = null;
            this.dgvLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogs.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogs.EnableHeadersVisualStyles = false;
            this.dgvLogs.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvLogs.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvLogs.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvLogs.Location = new System.Drawing.Point(3, 17);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLogs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvLogs.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLogs.RowTemplate.Height = 23;
            this.dgvLogs.Size = new System.Drawing.Size(481, 273);
            this.dgvLogs.TabIndex = 0;
            this.dgvLogs.TitleBack = null;
            this.dgvLogs.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvLogs.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // pnlPan
            // 
            this.pnlPan.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.pnlPan.Controls.Add(this.btnPanLogin);
            this.pnlPan.Location = new System.Drawing.Point(7, 60);
            this.pnlPan.Name = "pnlPan";
            this.pnlPan.Size = new System.Drawing.Size(484, 98);
            this.pnlPan.TabIndex = 0;
            this.pnlPan.Text = "盘口";
            // 
            // btnPanLogin
            // 
            this.btnPanLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnPanLogin.BaseColor = System.Drawing.Color.Silver;
            this.btnPanLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnPanLogin.DownBack = null;
            this.btnPanLogin.DownBaseColor = System.Drawing.Color.Gray;
            this.btnPanLogin.Location = new System.Drawing.Point(5, 27);
            this.btnPanLogin.MouseBack = null;
            this.btnPanLogin.Name = "btnPanLogin";
            this.btnPanLogin.NormlBack = null;
            this.btnPanLogin.Size = new System.Drawing.Size(56, 23);
            this.btnPanLogin.TabIndex = 0;
            this.btnPanLogin.Text = "登录";
            this.btnPanLogin.UseVisualStyleBackColor = false;
            this.btnPanLogin.Click += new System.EventHandler(this.btnPanLogin_Click);
            // 
            // ViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(501, 758);
            this.Controls.Add(this.pnlPan);
            this.Controls.Add(this.skinGroupBox1);
            this.Controls.Add(this.tabMain);
            this.Name = "ViewMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainView";
            this.tabMain.ResumeLayout(false);
            this.tpSetting.ResumeLayout(false);
            this.skinGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.pnlPan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl tabMain;
        private CCWin.SkinControl.SkinTabPage tpData;
        private CCWin.SkinControl.SkinTabPage tpSetting;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinDataGridView dgvLogs;
        private CCWin.SkinControl.SkinButton btnPostOrderBoss;
        private CCWin.SkinControl.SkinCaptionPanel pnlPan;
        private CCWin.SkinControl.SkinButton btnPanLogin;
    }
}

