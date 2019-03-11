using System.Collections.Generic;
using System.Linq;
using UruIT.Game.Bll.Context;
using UruIT.Game.Model;

namespace UruIT.Game.Bll.Dao.users
{
    public class UsersBll : IUsersBll
    {
        private readonly IRepository<User> _userRepository;


        public UsersBll(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public User Add(User user)
        {
            return _userRepository.Add(user);
        }

        public List<User> Add(List<User> user)
        {
            return _userRepository.Add(user).ToList();
        }

        public IQueryable<User> Get()
        {
            return _userRepository.GetAll();
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }
    }
}
