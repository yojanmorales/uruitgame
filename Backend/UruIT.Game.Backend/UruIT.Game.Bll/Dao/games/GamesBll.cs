using System.Linq;
using UruIT.Game.Bll.Context;

namespace UruIT.Game.Bll.Dao.games
{
    public class GamesBll : IGamesBll
    {

        private readonly IRepository<Game.Model.Game> _gameRepository;

        public GamesBll(IRepository<Game.Model.Game> gameRepository)
        {
            _gameRepository = gameRepository;
        }
        public IQueryable<Model.Game> Get()
        {
            return _gameRepository.GetAll();
        }
    }
}
