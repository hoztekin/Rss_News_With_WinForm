using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Rss_News
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnGet_Click(object sender, EventArgs e)
		{
			List<News> list = XmlConvert();
			Lst_Title.DataSource = list;
		}
		private List<News> XmlConvert()
		{
			List<News> NewsData = new List<News>();
			XDocument XmlResource = XDocument.Load(txtRssUrl.Text);
			List<XElement> Rows = XmlResource.Descendants("item").ToList();
			foreach (XElement item in Rows)
			{
				News Temp = new News();
				Temp.Tittle = item.Element("title").Value;
				Temp.Link = item.Element("link").Value;
				Temp.Description = item.Element("description").Value;
				NewsData.Add(Temp);
			}
			return NewsData;
		}

		private void Lst_Title_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListBox SelectedItem = (ListBox) sender;
			News SelectedNews = (News)SelectedItem.SelectedItem;
			webBrowser1.DocumentText = SelectedNews.Description;
		}
	}
}
