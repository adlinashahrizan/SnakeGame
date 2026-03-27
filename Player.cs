namespace SnakeGameProject
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Player(string name)
        {
            Name = name;
            Health = 3;
        }
    }
}