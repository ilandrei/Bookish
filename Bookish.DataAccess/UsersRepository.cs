using Bookish.DataAccess.Entities;
using Bookish.DataAccess.Interfaces;

namespace Bookish.DataAccess;
public class UsersRepository:IUserRepository
{
    private List<User> _users;

    public UsersRepository() { 
        _users= new List<User>
        {
            new User
            {
                Id = Guid.NewGuid(),
                Email = "flavia@gmail.com",
                Password = "parola",
                DisplayName = "flavia",
            }
        };
    }

    public List<User> GetAll()
    {
        return _users;
    }

    public void Add(User user)
    {
        _users.Add(user);
    }
    public User GetById(string id)
    {
        return _users.FirstOrDefault(u => u.Id.ToString().ToLower() == id);
    }

}
