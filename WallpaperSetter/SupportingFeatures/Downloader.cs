using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace WallpaperSetter
{
	public class Downloader
	{
	
	public static void  DownloadingWallpaper(string url, string FileName){
			using (WebClient webClient = new WebClient())
			{
				Bitmap bitmap = new Bitmap(webClient.OpenRead(url));
				if (bitmap != null)
				bitmap.Save(FileName, ImageFormat.Png);
			}
		}
	}
}
