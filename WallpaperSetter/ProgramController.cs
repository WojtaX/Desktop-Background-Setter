using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperSetter
{
	class ProgramController
	{
		public static void Start()
		{
			Scheduler.AddingToScheduler();
			WallpaperController.WallpaperControl();
		}
		}

}
