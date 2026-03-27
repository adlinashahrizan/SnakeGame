using System.Collections.Generic;

namespace SnakeGameProject
{
    public class Snake
    {
        public List<Position> Body { get; set; }
        public string Direction { get; set; }

        public Snake()
        {
            Body = new List<Position>
            {
                new Position(5, 5),
                new Position(4, 5),
                new Position(3, 5)
            };

            Direction = "RIGHT";
        }

        public Position GetHead()
        {
            return Body[0];
        }

        public void Move(bool grow = false)
        {
            Position head = GetHead();
            Position newHead;

            if (Direction == "UP")
                newHead = new Position(head.X, head.Y - 1);
            else if (Direction == "DOWN")
                newHead = new Position(head.X, head.Y + 1);
            else if (Direction == "LEFT")
                newHead = new Position(head.X - 1, head.Y);
            else
                newHead = new Position(head.X + 1, head.Y);

            Body.Insert(0, newHead);

            if (!grow)
                Body.RemoveAt(Body.Count - 1);
        }

        public bool CheckSelfCollision()
        {
            Position head = GetHead();

            for (int i = 1; i < Body.Count; i++)
            {
                if (head.Equals(Body[i]))
                    return true;
            }

            return false;
        }

        public void Reset()
        {
            Body.Clear();
            Body.Add(new Position(5, 5));
            Body.Add(new Position(4, 5));
            Body.Add(new Position(3, 5));
            Direction = "RIGHT";
        }
    }

}
