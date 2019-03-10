using System;
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

        public void Add(User user)
        {
            _usersBll.Add(user);
        }

        public IQueryable<User> Get()
        {
            return _usersBll.Get();
        }
    }
}
