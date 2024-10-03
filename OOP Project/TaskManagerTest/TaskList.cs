using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TaskList
{
    public int taskListID { get; set; }
    public string name { get; set; }
    public List<Task> taskList { get; set; }

    public TaskList(int taskListID, string name)
    {
        this.taskListID = taskListID;
        this.name = name;
        this.taskList = new List<Task>();
    }

    public void addTask(Task task)
    {
        taskList.Add(task);
    }

    public void removeTask(int taskID)
    {
        taskList.RemoveAll(t => t.taskID == taskID);
    }

    public Task getTaskBy(int taskID)
    {
        return taskList.Find(t => t.taskID == taskID);
    }
}

