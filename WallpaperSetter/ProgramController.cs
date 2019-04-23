using System;

namespace WallpaperSetter
{
	class ProgramController
	{
		public static void Start()
		{
			try
			{
				Scheduler.AddingToScheduler();
				WallpaperController.WallpaperControl();
			}
			catch(Exception e ){
				Logger.LogCreator(e.Message);
			}
			}
		}
}
