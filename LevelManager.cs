using System.Collections.Generic;

namespace SnakeGameProject
{
    public class LevelManager
    {
        public List<Level> Levels { get; set; }
        public Level CurrentLevel { get; set; }

        public LevelManager()
        {
            Levels = new List<Level>
            {
                new Level(1, "Level 1", 200, 10, 2),
                new Level(2, "Level 2", 120, 30, 4),
                new Level(3, "Level 3", 80, 50, 6)
            };

            CurrentLevel = Levels[0];
        }

        public void LoadLevel(int levelNumber)
        {
            CurrentLevel = Levels.Find(l => l.LevelNumber == levelNumber);
        }

        public bool IsLevelComplete(int score)
        {
            return score >= CurrentLevel.TargetScore;
        }

        public bool HasNextLevel()
        {
            return CurrentLevel.LevelNumber < Levels.Count;
        }

        public void NextLevel()
        {
            if (HasNextLevel())
                LoadLevel(CurrentLevel.LevelNumber + 1);
        }
    }
}