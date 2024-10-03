using System;
using System.Diagnostics;

namespace TaskManagerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager(1);

            User user1 = new User(101, "qistina_madina", "qistina@example.com", "password222");
            User user2 = new User(102, "aiman_qayyum", "aiman@example.com", "password555");

            manager.users.Add(user1);
            manager.users.Add(user2);

            TaskList projectTasks = new TaskList(1, "Project A");

            manager.addTaskList(projectTasks);

            Task task1 = new Task(201, "Complete Report", "Write and submit the final report", DateTime.Now.AddDays(3), "Pending", "High");

            projectTasks.addTask(task1);

            manager.assignTaskToUser(201, 101);

            task1.markComplete();

            Console.WriteLine($"{user1.username} has been assigned the task: {task1.title}, Status: {task1.status}");
        }
    }
}

