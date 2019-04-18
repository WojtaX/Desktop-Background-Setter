using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperSetter
{
	public class WallpaperController
	{
		public static string PhotoName = "PhotoOfTheDay.png";
		public static string Bing = "https://bing.com/";
		static string url = "https://www.bing.com/HPImageArchive.aspx?format=js&idx=0&n=1&mkt=en-US";
		public static string AppName = "WallpaperSetter.exe";

		public  static void WallpaperControl(){
			PhotoOfTheDay photo = WallpaperJsonParser.JsonDownload<PhotoOfTheDay>(url);
			Downloader.DownloadingWallpaper(Bing+photo.images[0].url,PhotoName);
			WallpaperSetter.SetDesktopWallpaper(DirectoryGetter.GetCurrentDirectory() + @"\" +PhotoName);
		}
	}
}
