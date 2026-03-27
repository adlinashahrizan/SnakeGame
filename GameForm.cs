using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGameProject
{
    public partial class GameForm : Form
    {
        private GameController controller;
        private System.Windows.Forms.Timer timer;
        private int cellSize = 25;

        public GameForm()
        {
            controller = new GameController();

            Text = "Snake Game";
            DoubleBuffered = true;
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(520, 600);
            KeyPreview = true;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = controller.LevelManager.CurrentLevel.Speed;
            timer.Tick += Timer_Tick;
            timer.Start();

            KeyDown += GameForm_KeyDown;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            controller.Update();
            timer.Interval = controller.LevelManager.CurrentLevel.Speed;

            if (controller.IsGameOver)
            {
                timer.Stop();
                MessageBox.Show("Game Over!");
                Close();
                return;
            }

            if (controller.IsWin)
            {
                timer.Stop();
                MessageBox.Show("Congratulations! You win!");
                Close();
                return;
            }

            Invalidate();
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && controller.Snake.Direction != "DOWN")
                controller.Snake.Direction = "UP";
            else if (e.KeyCode == Keys.Down && controller.Snake.Direction != "UP")
                controller.Snake.Direction = "DOWN";
            else if (e.KeyCode == Keys.Left && controller.Snake.Direction != "RIGHT")
                controller.Snake.Direction = "LEFT";
            else if (e.KeyCode == Keys.Right && controller.Snake.Direction != "LEFT")
                controller.Snake.Direction = "RIGHT";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            foreach (Position pos in controller.Snake.Body)
            {
                g.FillRectangle(Brushes.Green, pos.X * cellSize, pos.Y * cellSize, cellSize, cellSize);
                g.DrawRectangle(Pens.Black, pos.X * cellSize, pos.Y * cellSize, cellSize, cellSize);
            }

            if (controller.CurrentItem != null)
            {
                Brush itemBrush = Brushes.Red;

                if (controller.CurrentItem is BonusFood)
                    itemBrush = Brushes.Gold;

                g.FillEllipse(itemBrush,
                    controller.CurrentItem.Position.X * cellSize,
                    controller.CurrentItem.Position.Y * cellSize,
                    cellSize,
                    cellSize);
            }

            foreach (Obstacle obstacle in controller.Obstacles)
            {
                g.FillRectangle(Brushes.Gray,
                    obstacle.Position.X * cellSize,
                    obstacle.Position.Y * cellSize,
                    cellSize,
                    cellSize);
            }

            g.DrawString(
                "Player: " + controller.Player.Name +
                "   Score: " + controller.ScoreManager.CurrentScore +
                "   High Score: " + controller.ScoreManager.HighScore +
                "   Level: " + controller.LevelManager.CurrentLevel.LevelNumber,
                new Font("Arial", 12),
                Brushes.Black,
                10,
                520
            );

            g.DrawString(
                "Normal Food = +1   Bonus Food = +3   Obstacles = Challenge",
                new Font("Arial", 10),
                Brushes.Black,
                10,
                550
            );
        }
    }
}