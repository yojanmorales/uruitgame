using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UruIT.Game.Model;

namespace UruIT.Game.Service.Layers.Users
{
    public interface IUserService
    {
        IQueryable<User> Get();

        bool Add(User user);
    }
}
