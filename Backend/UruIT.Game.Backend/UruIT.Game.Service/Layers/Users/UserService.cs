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

        public bool Add(User user)
        {
            _usersBll.Add(user);
            return true;
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
