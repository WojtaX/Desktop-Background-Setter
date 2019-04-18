using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperSetter
{
	class TasksCreator
	{
		public static void CreatingTask(TaskService taskService)
		{
			TaskDefinition taskDefinition = taskService.NewTask();
			taskDefinition.RegistrationInfo.Description = Scheduler.TaskDescription;
			taskDefinition.Triggers.Add(new DailyTrigger { DaysInterval = 1 });
			taskDefinition.RegistrationInfo.Author = Scheduler.AuthorName;
			taskDefinition.Actions.Add(new ExecAction(DirectoryGetter.GetCurrentDirectory() + @"\" + WallpaperController.AppName, "", null));
			taskService.RootFolder.RegisterTaskDefinition(Scheduler.TaskName, taskDefinition);
		}
	}
}
