using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperSetter.PhotoJSON
{

	public	 class Image
		{
			public string startdate { get; set; }
			public string fullstartdate { get; set; }
			public string enddate { get; set; }
			public string url { get; set; }
			public string urlbase { get; set; }
			public string copyright { get; set; }
			public string copyrightlink { get; set; }
			public string title { get; set; }
			public string quiz { get; set; }
			public bool wp { get; set; }
			public string hsh { get; set; }
			public int drk { get; set; }
			public int top { get; set; }
			public int bot { get; set; }
			public List<object> hs { get; set; }
		}
	
}
