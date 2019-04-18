using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperSetter
{
	public static class DirectoryGetter
	{
	public static string GetCurrentDirectory(){
			return System.IO.Directory.GetCurrentDirectory();
		}

	}
}
