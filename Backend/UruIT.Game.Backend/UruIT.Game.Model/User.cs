using System;
using System.Collections.Generic;

namespace UruIT.Game.Model
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
