using System.Linq;
using UruIT.Game.Model;

namespace UruIT.Game.Service.Layers.Moves
{
    public interface IMovesService
    {
        IQueryable<Move> Get();
    }
}
