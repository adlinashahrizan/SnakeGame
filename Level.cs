using System.Collections.Generic;

namespace SnakeGameProject
{
    public class Level
    {
        public int LevelNumber { get; set; }
        public string LevelName { get; set; }
        public int Speed { get; set; }
        public int TargetScore { get; set; }
        public int ObstacleCount { get; set; }

        public Level(int levelNumber, string levelName, int speed, int targetScore, int obstacleCount)
        {
            LevelNumber = levelNumber;
            LevelName = levelName;
            Speed = speed;
            TargetScore = targetScore;
            ObstacleCount = obstacleCount;
        }
    }
}