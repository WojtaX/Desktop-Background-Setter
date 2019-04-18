using System.Net;
using System.Drawing;
using System.Drawing.Imaging;
using System;

namespace WallpaperSetter
{
	public class Downloader
	{
	public static void  DownloadingWallpaper(string url, string FileName){
			try
			{
				using (WebClient webClient = new WebClient())
				{
					Bitmap bitmap = new Bitmap(webClient.OpenRead(url));
					if (bitmap != null)
						bitmap.Save(FileName, ImageFormat.Png);
				}
			}
			catch(Exception e){
				Logger.LogCreator(e.Message);
			}
		}
	}
}
