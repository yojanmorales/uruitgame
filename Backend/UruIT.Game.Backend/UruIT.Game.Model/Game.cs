namespace UruIT.Game.Model
{
    public class Game
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Round { get; set; }

        public virtual User User { get; set; }
    }
}
