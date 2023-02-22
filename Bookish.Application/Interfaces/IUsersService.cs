using Bookish.DataAccess.Entities;

namespace Bookish.Application.Interfaces;
public interface IUsersService
{
    List<User> GetAll();
    User GetById(string id);
}
