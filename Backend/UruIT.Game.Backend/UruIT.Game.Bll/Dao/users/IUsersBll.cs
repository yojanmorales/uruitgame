using System.Linq;
using UruIT.Game.Model;

namespace UruIT.Game.Bll.Dao.users
{
    public interface IUsersBll
    {
        IQueryable<User> Get();

        void Add(User user);

        void Update(User user);
    }
}
