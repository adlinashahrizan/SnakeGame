namespace SnakeGameProject
{
    public class ScoreManager
    {
        public int CurrentScore { get; private set; }
        public int HighScore { get; private set; }

        public void AddPoints(int points)
        {
            CurrentScore += points;
            if (CurrentScore > HighScore)
                HighScore = CurrentScore;
        }

        public void ResetScore()
        {
            CurrentScore = 0;
        }
    }
}