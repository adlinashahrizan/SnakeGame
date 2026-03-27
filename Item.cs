namespace SnakeGameProject
{
    public abstract class Item : ICollectable
    {
        public Position Position { get; set; }
        public bool IsActive { get; set; }

        protected Item(Position position)
        {
            Position = position;
            IsActive = true;
        }

        public abstract int GetPoints();
    }
}