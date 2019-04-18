using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

using System.Xml.Linq;

namespace WallpaperSetter
{
	public class WallpaperJsonParser
	{
		public static T JsonDownload<T>(string url) where T : new()
		{
			using (var webClient = new WebClient())
			{
				var json_data = string.Empty;
							
				try
				{
					json_data = webClient.DownloadString(url);
					var jsonData = JObject.Parse(json_data);

				}
				catch (Exception ) {
			
				}
				
				return JsonConvert.DeserializeObject<T>(json_data);
			}
		
		}
	}
}
