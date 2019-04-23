using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperSetter
{
	class Logger
	{
 public static void LogCreator(string message){
			string Year = DateTime.Today.Year.ToString();
			string Month = DateTime.Today.Month.ToString();
			string Day = DateTime.Today.Day.ToString();
			string date = Year + Month + Day;
			System.IO.Directory.CreateDirectory("LOG");
			using (StreamWriter outputFile = new StreamWriter(Path.Combine(DirectoryGetter.GetCurrentDirectory()+@"\LOG", date+"LOG.txt")))
			{
					outputFile.WriteLine(message);
			}

		}

	}
}
