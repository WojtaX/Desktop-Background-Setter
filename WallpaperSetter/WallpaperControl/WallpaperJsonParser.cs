using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;


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
				catch(Exception e){ 

				Logger.LogCreator(e.Message.ToString());
				
				}

				return JsonConvert.DeserializeObject<T>(json_data);
			}
		
		}
	}
}
