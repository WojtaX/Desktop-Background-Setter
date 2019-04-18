using Microsoft.Win32.TaskScheduler;
using System;

namespace WallpaperSetter
{
	class Scheduler
	{
		public static string TaskName = "WojtaX_ChangingWallpaper";
		public static string AuthorName = "Wojciech Laskowski";
		public static string TaskDescription = "ChangingWallpaper";
		public static void AddingToScheduler()
		{
			try
			{
				using (TaskService taskService = new TaskService())
				{
					if (!TaskChecker.CheckTask(TaskName))
					{
						TasksCreator.CreatingTask(taskService);
					}
				}
			}
			catch(Exception e){
				Logger.LogCreator(e.Message);
			}
			}
		}
	}

