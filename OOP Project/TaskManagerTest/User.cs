using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

public class User
{
    public int userID { get; set; }
    public string username { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public List<Task> assignedTasks { get; set; }

    public User(int userID, string username, string email, string password)
    {
        this.userID = userID;
        this.username = username;
        this.email = email;
        this.password = password;
        this.assignedTasks = new List<Task>();
    }

    public void createUser()
    {
        // Logic to create user
    }

    public void updateUser(string newUsername, string newEmail, string newPassword)
    {
        this.username = newUsername;
        this.email = newEmail;
        this.password = newPassword;
    }

    public void deleteUser()
    {
        // Logic to delete user
    }

    public bool authenticateUser(string enteredPassword)
    {
        return this.password == enteredPassword;
    }
}

