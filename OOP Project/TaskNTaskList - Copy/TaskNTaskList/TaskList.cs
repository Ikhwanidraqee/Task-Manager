using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNTaskList
{

    public class TaskList
    {
        public int TaskListID { get; set; }
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }

        public TaskList(int taskListID, string name)
        {
            TaskListID = taskListID;
            Name = name;
            Tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public void RemoveTask(int taskId)
        {
            Task taskToRemove = Tasks.Find(t => t.TaskID == taskId);
            if (taskToRemove != null)
            {
                Tasks.Remove(taskToRemove);
            }
        }

        public Task GetTask(int taskId)
        {
            return Tasks.Find(t => t.TaskID == taskId);
        }

        public List<Task> GetTasksByStatus(string status)
        {
            return Tasks.FindAll(t => t.Status == status);
        }
    }

}
