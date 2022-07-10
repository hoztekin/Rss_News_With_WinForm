using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rss_News
{
	public class News
	{
		public string Tittle { get; set; }
		public string Link { get; set; }
		public string Description { get; set; }

		public override string ToString()
		{
			return Tittle;
		}
	}
	
}
