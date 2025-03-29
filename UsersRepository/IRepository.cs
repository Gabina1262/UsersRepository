using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersRepository;

public interface IRepository
{
    public User GetUserById(Guid id);
    public List<User> GetUsers();    
    public User AddUser(User user);
    public bool UpdateUser(User user);
    public void DeleteUser(Guid id); 
}
