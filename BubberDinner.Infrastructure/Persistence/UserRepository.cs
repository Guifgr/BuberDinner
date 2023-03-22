using BubberDinner.Application.Common.Interfaces.Persistence;
using BubberDinner.Domain;

namespace BubberDinner.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private readonly List<User> _users = new();
    public void Add(User user)
    {
        _users.Add(user);
    }

    public User? GetUserByEmail(string email)
    {
        return _users.SingleOrDefault(x => x.Email == email);
    }
}
