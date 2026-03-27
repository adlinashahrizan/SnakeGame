using System;
using System.Collections.Generic;

namespace SnakeGameProject
{
    public class GameBoard
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public GameBoard(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool IsWithinBounds(Position position)
        {
            return position.X >= 0 && position.X < Width && position.Y >= 0 && position.Y < Height;
        }

        public Position GetRandomEmptyPosition(Random random, Snake snake, Item item, List<Obstacle> obstacles)
        {
            while (true)
            {
                Position pos = new Position(random.Next(0, Width), random.Next(0, Height));
                bool occupied = false;

                foreach (Position bodyPart in snake.Body)
                {
                    if (bodyPart.Equals(pos))
                    {
                        occupied = true;
                        break;
                    }
                }

                if (item != null && item.Position.Equals(pos))
                    occupied = true;

                foreach (Obstacle obstacle in obstacles)
                {
                    if (obstacle.Position.Equals(pos))
                    {
                        occupied = true;
                        break;
                    }
                }

                if (!occupied)
                    return pos;
            }
        }
    }
}