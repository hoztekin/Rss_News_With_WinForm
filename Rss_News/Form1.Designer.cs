namespace Rss_News
{
	partial class Form1
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
			this.RssUrlGrp = new System.Windows.Forms.GroupBox();
			this.btnGet = new System.Windows.Forms.Button();
			this.txtRssUrl = new System.Windows.Forms.TextBox();
			this.News_Title_Grp = new System.Windows.Forms.GroupBox();
			this.NewsDetailGrp = new System.Windows.Forms.GroupBox();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.Lst_Title = new System.Windows.Forms.ListBox();
			this.RssUrlGrp.SuspendLayout();
			this.News_Title_Grp.SuspendLayout();
			this.NewsDetailGrp.SuspendLayout();
			this.SuspendLayout();
			// 
			// RssUrlGrp
			// 
			this.RssUrlGrp.Controls.Add(this.txtRssUrl);
			this.RssUrlGrp.Controls.Add(this.btnGet);
			this.RssUrlGrp.Location = new System.Drawing.Point(12, 12);
			this.RssUrlGrp.Name = "RssUrlGrp";
			this.RssUrlGrp.Size = new System.Drawing.Size(1013, 53);
			this.RssUrlGrp.TabIndex = 0;
			this.RssUrlGrp.TabStop = false;
			this.RssUrlGrp.Text = "RssUrl";
			// 
			// btnGet
			// 
			this.btnGet.Location = new System.Drawing.Point(871, 10);
			this.btnGet.Name = "btnGet";
			this.btnGet.Size = new System.Drawing.Size(136, 35);
			this.btnGet.TabIndex = 0;
			this.btnGet.Text = "Get";
			this.btnGet.UseVisualStyleBackColor = true;
			this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
			// 
			// txtRssUrl
			// 
			this.txtRssUrl.Location = new System.Drawing.Point(6, 19);
			this.txtRssUrl.Multiline = true;
			this.txtRssUrl.Name = "txtRssUrl";
			this.txtRssUrl.Size = new System.Drawing.Size(858, 26);
			this.txtRssUrl.TabIndex = 1;
			this.txtRssUrl.Text = "https://www.cnnturk.com/feed/rss/all/news";
			// 
			// News_Title_Grp
			// 
			this.News_Title_Grp.Controls.Add(this.Lst_Title);
			this.News_Title_Grp.Location = new System.Drawing.Point(18, 72);
			this.News_Title_Grp.Name = "News_Title_Grp";
			this.News_Title_Grp.Size = new System.Drawing.Size(406, 628);
			this.News_Title_Grp.TabIndex = 1;
			this.News_Title_Grp.TabStop = false;
			this.News_Title_Grp.Text = "News_Title";
			// 
			// NewsDetailGrp
			// 
			this.NewsDetailGrp.Controls.Add(this.webBrowser1);
			this.NewsDetailGrp.Location = new System.Drawing.Point(445, 72);
			this.NewsDetailGrp.Name = "NewsDetailGrp";
			this.NewsDetailGrp.Size = new System.Drawing.Size(580, 628);
			this.NewsDetailGrp.TabIndex = 2;
			this.NewsDetailGrp.TabStop = false;
			this.NewsDetailGrp.Text = "News_Detail";
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(3, 18);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(574, 607);
			this.webBrowser1.TabIndex = 0;
			// 
			// Lst_Title
			// 
			this.Lst_Title.FormattingEnabled = true;
			this.Lst_Title.ItemHeight = 16;
			this.Lst_Title.Location = new System.Drawing.Point(7, 18);
			this.Lst_Title.Name = "Lst_Title";
			this.Lst_Title.Size = new System.Drawing.Size(393, 612);
			this.Lst_Title.TabIndex = 0;
			this.Lst_Title.SelectedIndexChanged += new System.EventHandler(this.Lst_Title_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1037, 712);
			this.Controls.Add(this.NewsDetailGrp);
			this.Controls.Add(this.News_Title_Grp);
			this.Controls.Add(this.RssUrlGrp);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "News";
			this.RssUrlGrp.ResumeLayout(false);
			this.RssUrlGrp.PerformLayout();
			this.News_Title_Grp.ResumeLayout(false);
			this.NewsDetailGrp.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox RssUrlGrp;
		private System.Windows.Forms.TextBox txtRssUrl;
		private System.Windows.Forms.Button btnGet;
		private System.Windows.Forms.GroupBox News_Title_Grp;
		private System.Windows.Forms.ListBox Lst_Title;
		private System.Windows.Forms.GroupBox NewsDetailGrp;
		private System.Windows.Forms.WebBrowser webBrowser1;
	}
}

