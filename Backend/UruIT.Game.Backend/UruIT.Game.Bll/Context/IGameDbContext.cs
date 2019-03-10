using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UruIT.Game.Model;

namespace UruIT.Game.Bll.Context
{
    public interface IGameDbContext
    {
        DbSet<User> Users { get; set; }

        DbSet<Move> Moves { get; set; }
        DbSet<Game.Model.Game> Games { get; set; }
    }
}
