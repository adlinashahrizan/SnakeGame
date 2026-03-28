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
                new Level(1, "Level 1", 250, 5, 2),
                new Level(2, "Level 2", 150, 10, 4),
                new Level(3, "Level 3", 100, 15, 6)
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