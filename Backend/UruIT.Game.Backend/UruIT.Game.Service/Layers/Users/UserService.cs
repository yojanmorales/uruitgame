using System.Collections.Generic;
using System.Linq;
using UruIT.Game.Bll.Dao.users;
using UruIT.Game.Model;

namespace UruIT.Game.Service.Layers.Users
{
    public class UserService : IUserService
    {
        private readonly IUsersBll _usersBll;

        public UserService(IUsersBll usersBll)
        {
            _usersBll = usersBll;
        }

        public User Add(User user)
        {
           return _usersBll.Add(user);
        }

        public List<User> Add(List<User> user)
        {
            return _usersBll.Add(user);
        }

        public IQueryable<User> Get()
        {
            return _usersBll.Get();
        }

        public bool Update(User user)
        {
            _usersBll.Update(user);
            return true;
        }
    }
}
