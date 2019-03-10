using System.Linq;
using UruIT.Game.Model;

namespace UruIT.Game.Bll.Dao.moves
{
    public interface IMovesBll
    {
        IQueryable<Move> Get();
    }
}
