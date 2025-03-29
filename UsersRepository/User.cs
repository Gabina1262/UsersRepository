using System.ComponentModel;

namespace UsersRepository;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime RegistrationDate { get; set; }


    public User(string name, string email, DateTime registrationDate)
    {
        Name = name;
        Email = email;
        RegistrationDate = registrationDate;
    }
   
}


