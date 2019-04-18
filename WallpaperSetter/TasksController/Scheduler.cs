using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.TaskScheduler;
namespace WallpaperSetter
{
	class Scheduler
	{
		public static string TaskName = "WojtaX_ChangingWallpaper";
		public static string AuthorName = "Wojciech Laskowski";
		public static string TaskDescription = "ChangingWallpaper";
		public static void AddingToScheduler()
		{
			using (TaskService taskService = new TaskService())
			{
				if (!TaskChecker.CheckTask(TaskName))
				{
					TasksCreator.CreatingTask(taskService);
				}
			}
			}
		}
	}

