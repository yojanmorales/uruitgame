using System.Linq;

namespace UruIT.Game.Service.Layers.Games
{
    public interface IGamesService
    {
        IQueryable<Game.Model.Game> Get();
    }
}
