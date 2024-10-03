using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class TaskManager
{
    public int managerID { get; set; }
    public List<TaskList> taskList { get; set; }
    public List<User> users { get; set; }

    public TaskManager(int managerID)
    {
        this.managerID = managerID;
        this.taskList = new List<TaskList>();
        this.users = new List<User>();
    }

    public void addTaskList(TaskList newTaskList)
    {
        taskList.Add(newTaskList);
    }

    public void removeTaskList(int taskListID)
    {
        taskList.RemoveAll(tl => tl.taskListID == taskListID);
    }

    public void assignTaskToUser(int taskID, int userID)
    {
        User user = users.Find(u => u.userID == userID);
        if (user != null)
        {
            Task task = null;
            foreach (var taskList in taskList)
            {
                task = taskList.getTaskBy(taskID);
                if (task != null)
                {
                    break;
                }
            }

            if (task != null)
            {
                user.assignedTasks.Add(task);
            }
        }
    }
}
