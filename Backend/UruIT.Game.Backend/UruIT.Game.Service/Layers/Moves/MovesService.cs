using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UruIT.Game.Bll.Dao.moves;
using UruIT.Game.Model;

namespace UruIT.Game.Service.Layers.Moves
{
    public class MovesService : IMovesService
    {
        private readonly IMovesBll _movesBll;

        public MovesService(IMovesBll movesBll)
        {
            _movesBll = movesBll;
        }
        public IQueryable<Move> Get()
        {
            return _movesBll.Get();
        }
    }
}
