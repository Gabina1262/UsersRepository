using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersRepository;

class Repository : IRepository
{
    List<User> users = new List<User>();

    public User AddUser(User user)
    {
        users.Add(user);
        return user;
    }

    public void DeleteUser(Guid id)
    {
        var deletedUser = users.First(x => x.Id == id);
        if (id != Guid.Empty)
        {
           users.Remove(deletedUser);
        }
    }

    public User? GetUserById (Guid id)
    {
        return users.FirstOrDefault(x => x.Id == id);
    }
         

    public  List<User> GetUsers()
    {
       return users.ToList();

    }

    public bool UpdateUser(User user)
    {
        var existingUser = users.FirstOrDefault(u => u.Id == user.Id);

        if (existingUser != null)
        {
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;    
            return true;
        }
        return false;   

    }
}

    