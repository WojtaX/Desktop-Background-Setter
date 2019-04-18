using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperSetter
{
	public static class TaskChecker
	{
		public static bool CheckTask(string taskName)
		{
			bool TaskCheck = false;
			using (TaskService taskService = new TaskService())
			{
				Microsoft.Win32.TaskScheduler.Task task = taskService.FindTask(taskName);
				TaskCheck = task != null ? true : false;
			}
			return TaskCheck;
		}
	}
}
