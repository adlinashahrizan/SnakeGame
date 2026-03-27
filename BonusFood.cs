namespace SnakeGameProject
{
    public class BonusFood : Item
    {
        public BonusFood(Position position) : base(position) { }

        public override int GetPoints()
        {
            return 3;
        }
    }
}