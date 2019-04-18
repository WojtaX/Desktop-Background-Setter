

using System;

namespace WallpaperSetter
{
	public class WallpaperController
	{
		public static string PhotoName = "PhotoOfTheDay.png";
		public static string Bing = "https://bing.com/";
		static string url = "https://www.bing.com/HPImageArchive.aspx?format=js&idx=0&n=1&mkt=en-US";
		public static string AppName = "WallpaperSetter.exe";

		public  static void WallpaperControl(){
			try
			{
				PhotoOfTheDay photo = WallpaperJsonParser.JsonDownload<PhotoOfTheDay>(url);
				Downloader.DownloadingWallpaper(Bing + photo.images[0].url, PhotoName);
				WallpaperSetter.SetDesktopWallpaper(DirectoryGetter.GetCurrentDirectory() + @"\" + PhotoName);
			}
			catch(Exception e){
				Logger.LogCreator(e.Message);
			}
			}
	}
}
