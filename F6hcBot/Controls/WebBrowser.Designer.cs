namespace F6Bot.Controls
{
    partial class WebBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webControlMain = new EO.WinForm.WebControl();
            this.webView1 = new EO.WebBrowser.WebView();
            this.tbxUrl = new CCWin.SkinControl.SkinTextBox();
            this.btnGo = new CCWin.SkinControl.SkinButton();
            this.btnTest = new CCWin.SkinControl.SkinButton();
            this.btnCookie = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // webControlMain
            // 
            this.webControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webControlMain.BackColor = System.Drawing.Color.White;
            this.webControlMain.Location = new System.Drawing.Point(7, 58);
            this.webControlMain.Name = "webControlMain";
            this.webControlMain.Size = new System.Drawing.Size(880, 532);
            this.webControlMain.TabIndex = 0;
            this.webControlMain.WebView = this.webView1;
            // 
            // webView1
            // 
            this.webView1.ObjectForScripting = null;
            // 
            // tbxUrl
            // 
            this.tbxUrl.BackColor = System.Drawing.Color.Transparent;
            this.tbxUrl.DownBack = null;
            this.tbxUrl.Icon = null;
            this.tbxUrl.IconIsButton = false;
            this.tbxUrl.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbxUrl.IsPasswordChat = '\0';
            this.tbxUrl.IsSystemPasswordChar = false;
            this.tbxUrl.Lines = new string[0];
            this.tbxUrl.Location = new System.Drawing.Point(7, 27);
            this.tbxUrl.Margin = new System.Windows.Forms.Padding(0);
            this.tbxUrl.MaxLength = 32767;
            this.tbxUrl.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbxUrl.MouseBack = null;
            this.tbxUrl.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbxUrl.Multiline = false;
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.NormlBack = null;
            this.tbxUrl.Padding = new System.Windows.Forms.Padding(5);
            this.tbxUrl.ReadOnly = false;
            this.tbxUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxUrl.Size = new System.Drawing.Size(768, 28);
            // 
            // 
            // 
            this.tbxUrl.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUrl.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxUrl.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbxUrl.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbxUrl.SkinTxt.Name = "BaseText";
            this.tbxUrl.SkinTxt.Size = new System.Drawing.Size(758, 18);
            this.tbxUrl.SkinTxt.TabIndex = 0;
            this.tbxUrl.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbxUrl.SkinTxt.WaterText = "";
            this.tbxUrl.TabIndex = 1;
            this.tbxUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxUrl.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbxUrl.WaterText = "";
            this.tbxUrl.WordWrap = true;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnGo.DownBack = null;
            this.btnGo.Location = new System.Drawing.Point(778, 29);
            this.btnGo.MouseBack = null;
            this.btnGo.Name = "btnGo";
            this.btnGo.NormlBack = null;
            this.btnGo.Size = new System.Drawing.Size(34, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Transparent;
            this.btnTest.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnTest.DownBack = null;
            this.btnTest.Location = new System.Drawing.Point(814, 29);
            this.btnTest.MouseBack = null;
            this.btnTest.Name = "btnTest";
            this.btnTest.NormlBack = null;
            this.btnTest.Size = new System.Drawing.Size(34, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "T";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnCookie
            // 
            this.btnCookie.BackColor = System.Drawing.Color.Transparent;
            this.btnCookie.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCookie.DownBack = null;
            this.btnCookie.Location = new System.Drawing.Point(849, 29);
            this.btnCookie.MouseBack = null;
            this.btnCookie.Name = "btnCookie";
            this.btnCookie.NormlBack = null;
            this.btnCookie.Size = new System.Drawing.Size(34, 23);
            this.btnCookie.TabIndex = 2;
            this.btnCookie.Text = "C";
            this.btnCookie.UseVisualStyleBackColor = false;
            this.btnCookie.Click += new System.EventHandler(this.btnCookie_Click);
            // 
            // WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(894, 597);
            this.Controls.Add(this.btnCookie);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.tbxUrl);
            this.Controls.Add(this.webControlMain);
            this.Name = "WebBrowser";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            this.Shown += new System.EventHandler(this.View_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private EO.WinForm.WebControl webControlMain;
        private EO.WebBrowser.WebView webView1;
        private CCWin.SkinControl.SkinTextBox tbxUrl;
        private CCWin.SkinControl.SkinButton btnGo;
        private CCWin.SkinControl.SkinButton btnTest;
        private CCWin.SkinControl.SkinButton btnCookie;
    }
}