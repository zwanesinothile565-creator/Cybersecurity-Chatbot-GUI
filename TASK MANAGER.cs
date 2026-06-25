using System.Collections.Generic;
using CyberSecurityBotGUI.Models;

namespace CyberSecurityBotGUI.Services
{
    public class TaskManager
    {
        public List<TaskItem> Tasks = new List<TaskItem>();

        public void Add(TaskItem task)
        {
            Tasks.Add(task);
            ActivityLogger.Log("Task Added: " + task.Title);
        }

        public void Complete(int id)
        {
            var task = Tasks.Find(t => t.TaskID == id);
            if (task != null)
            {
                task.IsCompleted = true;
                ActivityLogger.Log("Task Completed: " + task.Title);
            }
        }

        public void Delete(int id)
        {
            Tasks.RemoveAll(t => t.TaskID == id);
            ActivityLogger.Log("Task Deleted: " + id);
        }
    }
}