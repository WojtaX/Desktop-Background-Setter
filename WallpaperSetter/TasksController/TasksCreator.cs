using Microsoft.Win32.TaskScheduler;
using System;

namespace WallpaperSetter
{
	class TasksCreator
	{
		public static void CreatingTask(TaskService taskService)
		{
			try
			{
				TaskDefinition taskDefinition = taskService.NewTask();
				taskDefinition.RegistrationInfo.Description = Scheduler.TaskDescription;
				taskDefinition.Triggers.Add(new DailyTrigger { DaysInterval = 1 });
				taskDefinition.RegistrationInfo.Author = Scheduler.AuthorName;
				taskDefinition.Actions.Add(new ExecAction(DirectoryGetter.GetCurrentDirectory() + @"\" + WallpaperController.AppName, "", null));
				taskService.RootFolder.RegisterTaskDefinition(Scheduler.TaskName, taskDefinition);
			}
			catch(Exception e){
				Logger.LogCreator(e.Message);
			}
			}
	}
}
