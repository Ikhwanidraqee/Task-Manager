using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UserList
{
    public int userListID { get; set; }
    public List<User> users { get; set; }

    public UserList(int userListID)
    {
        this.userListID = userListID;
        this.users = new List<User>();
    }

    public void addUser(User user)
    {
        users.Add(user);
    }

    public void removeUser(int userID)
    {
        users.RemoveAll(u => u.userID == userID);
    }

    public User getUserBy(int userID)
    {
        return users.Find(u => u.userID == userID);
    }
}

