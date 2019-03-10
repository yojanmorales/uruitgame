using System.Linq;
using UruIT.Game.Bll.Dao.games;

namespace UruIT.Game.Service.Layers.Games
{
    public class GamesService : IGamesService
    {
        private readonly IGamesBll _gamesBll;

        public GamesService(IGamesBll gamesBll)
        {
            _gamesBll = gamesBll;
        }
        public IQueryable<Model.Game> Get()
        {
            return _gamesBll.Get();
        }
    }
}
