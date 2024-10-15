using System;
using System.Collections.Generic;

namespace TaskManagerLibrary
{
    // Enum for Task Priority Levels
    public enum PriorityLevel
    {
        Low,
        Medium,
        High
    }

    // Task Model Class
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public PriorityLevel Priority { get; set; }
        public bool IsCompleted { get; set; }

        public Task(int id, string title, string description, DateTime dueDate, PriorityLevel priority)
        {
            TaskId = id;
            Title = title;
            Description = description;
            DueDate = dueDate;
            Priority = priority;
            IsCompleted = false;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }

        public override string ToString()
        {
            return $"ID: {TaskId}, Title: {Title}, Due Date: {DueDate.ToShortDateString()}, Priority: {Priority}, Completed: {IsCompleted}";
        }
    }

    // Task Repository Class for CRUD Operations
    public class TaskRepository
    {
        private readonly List<Task> tasks = new List<Task>();
        private int nextId = 1;

        // Create a new task
        public Task CreateTask(string title, string description, DateTime dueDate, PriorityLevel priority)
        {
            Task newTask = new Task(nextId++, title, description, dueDate, priority);
            tasks.Add(newTask);
            return newTask;
        }

        // Get all tasks
        public List<Task> GetAllTasks()
        {
            return new List<Task>(tasks);
        }

        // Get a specific task by ID
        public Task GetTaskById(int id)
        {
            return tasks.Find(task => task.TaskId == id);
        }

        // Search task by title
        public List<Task> SearchTasksByTitle(string title)
        {
            return tasks.FindAll(task => task.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        // Update a task
        public bool UpdateTask(int id, string title, string description, DateTime dueDate, PriorityLevel priority, bool isCompleted)
        {
            Task taskToUpdate = GetTaskById(id);
            if (taskToUpdate == null) return false;

            taskToUpdate.Title = title;
            taskToUpdate.Description = description;
            taskToUpdate.DueDate = dueDate;
            taskToUpdate.Priority = priority;
            taskToUpdate.IsCompleted = isCompleted;

            return true;
        }

        // Delete a task
        public bool DeleteTask(int id)
        {
            Task taskToDelete = GetTaskById(id);
            if (taskToDelete == null) return false;

            tasks.Remove(taskToDelete);
            return true;
        }
    }

    // Task Manager Class to Manage and Perform Actions on Tasks
    public class TaskManager
    {
        private readonly TaskRepository taskRepository = new TaskRepository();

        // Method to Add Task
        public void AddTask(string title, string description, DateTime dueDate, PriorityLevel priority)
        {
            taskRepository.CreateTask(title, description, dueDate, priority);
            Console.WriteLine("Task added successfully.");
        }

        // Method to Display All Tasks
        public void DisplayAllTasks()
        {
            var tasks = taskRepository.GetAllTasks();
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            foreach (var task in tasks)
            {
                Console.WriteLine(task.ToString());
            }
        }

        // Method to Search Tasks by Title
        public void SearchTasks(string title)
        {
            var tasks = taskRepository.SearchTasksByTitle(title);
            if (tasks.Count == 0)
            {
                Console.WriteLine($"No tasks found with title containing '{title}'.");
                return;
            }

            foreach (var task in tasks)
            {
                Console.WriteLine(task.ToString());
            }
        }

        // Method to Complete a Task
        public void CompleteTask(int taskId)
        {
            var task = taskRepository.GetTaskById(taskId);
            if (task != null)
            {
                task.MarkAsCompleted();
                Console.WriteLine("Task marked as completed.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        // Method to Edit a Task
        public void EditTask(int taskId, string newTitle, string newDescription, DateTime newDueDate, PriorityLevel newPriority)
        {
            if (taskRepository.UpdateTask(taskId, newTitle, newDescription, newDueDate, newPriority, false))
            {
                Console.WriteLine("Task updated successfully.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        // Method to Delete a Task with Confirmation
        public void DeleteTask(int taskId)
        {
            var task = taskRepository.GetTaskById(taskId);
            if (task == null)
            {
                Console.WriteLine("Task not found.");
                return;
            }

            Console.Write($"Are you sure you want to delete task '{task.Title}'? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
            {
                if (taskRepository.DeleteTask(taskId))
                {
                    Console.WriteLine("Task deleted successfully.");
                }
            }
            else
            {
                Console.WriteLine("Task deletion canceled.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();

            // Example of adding tasks
            taskManager.AddTask("Complete Assignment", "Finish the C# project", DateTime.Now.AddDays(3), PriorityLevel.High);
            taskManager.AddTask("Buy Groceries", "Get vegetables, fruits, and snacks", DateTime.Now.AddDays(1), PriorityLevel.Medium);

            // Display all tasks
            taskManager.DisplayAllTasks();

            // Edit a task
            taskManager.EditTask(1, "Complete Assignment Updated", "Update the C# project details", DateTime.Now.AddDays(4), PriorityLevel.High);

            // Mark task as completed
            taskManager.CompleteTask(1);

            // Search for a task by title
            taskManager.SearchTasks("Buy");

            // Delete a task with confirmation
            taskManager.DeleteTask(2);

            // Display all tasks after modifications
            taskManager.DisplayAllTasks();
        }
    }
}
