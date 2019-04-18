using System.Runtime.InteropServices;

namespace WallpaperSetter
{
public 	class WallpaperSetter
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int SystemParametersInfo(int uAction,
		int uParam, string lpvParam, int fuWinIni);
		private static readonly int SPI_SETDESKWALLPAPER = 0x14;
		private static readonly int SPIF_UPDATEINIFILE = 0x01;
		private static readonly int SPIF_SENDWININICHANGE = 0x02;

	public	static void SetDesktopWallpaper(string filename)
		{
			SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, filename,
				SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
		}
	}
}
