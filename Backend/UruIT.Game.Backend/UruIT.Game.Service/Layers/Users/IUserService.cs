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

        User Add(User user);

        bool Update(User user);

        List<User> Add(List<User> user);

    }
}
