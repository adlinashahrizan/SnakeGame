using System;
using System.Collections.Generic;

namespace SnakeGameProject
{
    public class GameController
    {
        public Player Player { get; set; }
        public Snake Snake { get; set; }
        public GameBoard Board { get; set; }
        public LevelManager LevelManager { get; set; }
        public ScoreManager ScoreManager { get; set; }
        public Item CurrentItem { get; set; }
        public List<Obstacle> Obstacles { get; set; }
        public bool IsGameOver { get; set; }
        public bool IsWin { get; set; }

        private Random random;

        public GameController()
        {
            random = new Random();
            Player = new Player("Player 1");
            Snake = new Snake();
            // Default board size
            Board = new GameBoard(20, 20);
            LevelManager = new LevelManager();
            ScoreManager = new ScoreManager();
            Obstacles = new List<Obstacle>();
            StartGame();
        }

        public void StartGame()
        {
            Snake.Reset();
            ScoreManager.ResetScore();
            LevelManager.LoadLevel(1);
            IsGameOver = false;
            IsWin = false;
            GenerateObstacles();
            SpawnItem();
        }

        public void SpawnItem()
        {
            Position pos = Board.GetRandomEmptyPosition(random, Snake, null, Obstacles);

            if (random.Next(0, 5) == 0)
                CurrentItem = new BonusFood(pos);
            else
                CurrentItem = new NormalFood(pos);
        }

        public void GenerateObstacles()
        {
            Obstacles.Clear();

            for (int i = 0; i < LevelManager.CurrentLevel.ObstacleCount; i++)
            {
                Position pos = Board.GetRandomEmptyPosition(random, Snake, CurrentItem, Obstacles);
                Obstacles.Add(new Obstacle(pos));
            }
        }

        public void Update()
        {
            try
            {
                Position head = Snake.GetHead();
                int nextX = head.X;
                int nextY = head.Y;

                if (Snake.Direction == "UP") nextY--;
                else if (Snake.Direction == "DOWN") nextY++;
                else if (Snake.Direction == "LEFT") nextX--;
                else if (Snake.Direction == "RIGHT") nextX++;

                Position nextHead = new Position(nextX, nextY);
                bool willGrow = CurrentItem != null && nextHead.Equals(CurrentItem.Position);

                Snake.Move(willGrow);

                if (!Board.IsWithinBounds(Snake.GetHead()) || Snake.CheckSelfCollision() || HitObstacle())
                {
                    IsGameOver = true;
                    return;
                }

                if (CurrentItem != null && Snake.GetHead().Equals(CurrentItem.Position))
                {
                    ScoreManager.AddPoints(CurrentItem.GetPoints());
                    SpawnItem();

                    if (LevelManager.IsLevelComplete(ScoreManager.CurrentScore))
                    {
                        if (LevelManager.HasNextLevel())
                        {
                            LevelManager.NextLevel();
                            GenerateObstacles();
                            SpawnItem();
                        }
                        else
                        {
                            IsWin = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                IsGameOver = true;
            }
        }

        public bool HitObstacle()
        {
            foreach (Obstacle obstacle in Obstacles)
            {
                if (Snake.GetHead().Equals(obstacle.Position))
                    return true;
            }

            return false;
        }
    }
}
