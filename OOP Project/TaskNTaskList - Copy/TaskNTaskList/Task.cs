using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNTaskList
{
    public class Task
    {
        public int TaskID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }

        public Task(int taskId, string title, string description, DateTime dueDate, string status, string priority)
        {
            TaskID = taskId;
            Title = title;
            Description = description;
            DueDate = dueDate;
            Status = status;
            Priority = priority;
        }

        public void CreateTask()
        {

        }

        public void UpdateTask()
        {

        }

        public void DeleteTask()
        {

        }

        public void MarkComplete()
        {
            Status = "Completed";
        }
    }

}
