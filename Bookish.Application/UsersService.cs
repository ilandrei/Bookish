using Bookish.Application.Interfaces;
using Bookish.DataAccess.Entities;
using Bookish.DataAccess.Interfaces;

namespace Bookish.Application;
public class UsersService:IUsersService
{
    private readonly IUserRepository _usersRepository;

    public UsersService(IUserRepository userRepository)
    {
        _usersRepository = userRepository;
    }

    public List<User> GetAll()
    {
        return _usersRepository.GetAll();
    }

    public User GetById(string id)
    {
        return _usersRepository.GetById(id);
    }
}
