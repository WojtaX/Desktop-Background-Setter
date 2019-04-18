using Microsoft.Win32.TaskScheduler;
using System;

namespace WallpaperSetter
{
	public static class TaskChecker
	{
		public static bool CheckTask(string taskName)
		{
			bool TaskCheck = false;
			try
			{
				using (TaskService taskService = new TaskService())
				{
					Microsoft.Win32.TaskScheduler.Task task = taskService.FindTask(taskName);
					TaskCheck = task != null ? true : false;
				}
			}
			catch(Exception e){
				Logger.LogCreator(e.Message);
			}
			return TaskCheck;
		}
	}
}
