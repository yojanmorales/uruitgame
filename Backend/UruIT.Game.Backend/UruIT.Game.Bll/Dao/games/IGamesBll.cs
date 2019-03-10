using System.Linq;

namespace UruIT.Game.Bll.Dao.games
{
    public interface IGamesBll
    {
        IQueryable<Game.Model.Game> Get();
    }
}
