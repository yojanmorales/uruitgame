using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UruIT.Game.Model;

namespace UruIT.Game.Bll.Context
{
    public interface IGameDbContext
    {
        DbSet<User> User { get; set; }
    }
}
