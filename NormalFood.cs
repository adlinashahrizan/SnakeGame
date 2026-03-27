namespace SnakeGameProject
{
    public class NormalFood : Item
    {
        public NormalFood(Position position) : base(position) { }

        public override int GetPoints()
        {
            return 1;
        }
    }
}