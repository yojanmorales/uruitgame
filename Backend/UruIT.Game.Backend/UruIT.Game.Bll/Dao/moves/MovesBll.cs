using System;
using System.Linq;
using UruIT.Game.Bll.Context;
using UruIT.Game.Model;

namespace UruIT.Game.Bll.Dao.moves
{
    public class MovesBll : IMovesBll
    {

        private readonly IRepository<Move> _moveRepository;

        public MovesBll(IRepository<Move> moveRepository)
        {
            _moveRepository = moveRepository;
        }
        public IQueryable<Move> Get()
        {
            return _moveRepository.GetAll();
        }
    }
}
