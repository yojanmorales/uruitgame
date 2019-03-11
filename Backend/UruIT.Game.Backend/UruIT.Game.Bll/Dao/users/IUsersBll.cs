using System.Collections.Generic;
using System.Linq;
using UruIT.Game.Model;

namespace UruIT.Game.Bll.Dao.users
{
    public interface IUsersBll
    {
        IQueryable<User> Get();

        User Add(User user);

        List<User> Add(List<User> user);

        void Update(User user);
    }
}
