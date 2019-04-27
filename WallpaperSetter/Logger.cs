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
			StringBuilder date = new StringBuilder();
			date.Append(DateTime.Today.Year.ToString());
			date.Append(DateTime.Today.Month.ToString());
			date.Append(DateTime.Today.Day.ToString());
		
			System.IO.Directory.CreateDirectory("LOG");
			using (StreamWriter outputFile = new StreamWriter(Path.Combine(DirectoryGetter.GetCurrentDirectory()+@"\LOG", date+"LOG.txt")))
			{
					outputFile.WriteLine(message);
			}

		}

	}
}
