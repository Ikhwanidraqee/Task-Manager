using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class Task
{
    public int taskID { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public DateTime dueDate { get; set; }
    public string status { get; set; }
    public string priority { get; set; }

    public Task(int taskID, string title, string description, DateTime dueDate, string status, string priority)
    {
        this.taskID = taskID;
        this.title = title;
        this.description = description;
        this.dueDate = dueDate;
        this.status = status;
        this.priority = priority;
    }

    public void createTask()
    {
        // Logic to create task
    }

    public void updateTask(string newTitle, string newDescription, DateTime newDueDate, string newStatus, string newPriority)
    {
        this.title = newTitle;
        this.description = newDescription;
        this.dueDate = newDueDate;
        this.status = newStatus;
        this.priority = newPriority;
    }

    public void deleteTask()
    {
        // Logic to delete task
    }

    public void markComplete()
    {
        this.status = "Completed";
    }
}

