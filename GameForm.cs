using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGameProject
{
    public partial class GameForm : Form
    {
        private GameController controller; // Reference to the game controller
        private System.Windows.Forms.Timer timer; // Use Windows Forms Timer for better integration with the UI thread
        private int cellSize = 25; // Size of each cell in pixels

        // The GameForm is responsible for rendering the game state and handling user input.
        public GameForm()
        {
            controller = new GameController(); // Initialize the game controller

            Text = "Snake Game";
            DoubleBuffered = true; 
            StartPosition = FormStartPosition.CenterScreen; // Set a fixed size for the game form
            ClientSize = new Size(580, 600);
            KeyPreview = true; // Enable KeyPreview to allow the form to capture key events before they reach any controls

            // Set form background color to green (outside area) using RGB
            BackColor = Color.FromArgb(193, 225, 193); // RGB for pastel green

            timer = new System.Windows.Forms.Timer(); 
            timer.Interval = controller.LevelManager.CurrentLevel.Speed;
            timer.Tick += Timer_Tick;
            timer.Start();

            KeyDown += GameForm_KeyDown; // Handle key presses for controlling the snake
        }

        // The Timer_Tick method is called on each timer tick to update the game state and refresh the display.
        private void Timer_Tick(object sender, EventArgs e) 
        {
            controller.Update(); // Update the game state (move snake, check collisions, etc.)
            timer.Interval = controller.LevelManager.CurrentLevel.Speed;

            // Check for game over or win conditions after updating the game state
            if (controller.IsGameOver)
            {
                timer.Stop();
                MessageBox.Show("Game Over!");
                // Close the game form after showing the message; the caller (main menu)
                // will continue execution after ShowDialog() returns.
                Close();
                return;
            }

            // Check for win condition and prompt the player to play again
            if (controller.IsWin)
            {
                timer.Stop();
                var result = MessageBox.Show("Congratulations! You win!\n\nWould you like to play again?", "You Win!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    controller.StartGame();
                    timer.Interval = controller.LevelManager.CurrentLevel.Speed;
                    timer.Start();
                    Invalidate();
                }
                else
                {
                    Close();
                }

                return;
            }

            Invalidate(); 
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && controller.Snake.Direction != "DOWN")
            {
                controller.Snake.Direction = "UP";
            }  
            else if (e.KeyCode == Keys.Down && controller.Snake.Direction != "UP")
            {
                controller.Snake.Direction = "DOWN";
            }
            else if (e.KeyCode == Keys.Left && controller.Snake.Direction != "RIGHT")
            {
                controller.Snake.Direction = "LEFT";
            }
            else if (e.KeyCode == Keys.Right && controller.Snake.Direction != "LEFT")
            {
                controller.Snake.Direction = "RIGHT";
            }
               
        }

        protected override void OnPaint(PaintEventArgs e) // Override the OnPaint method to draw the game state on the form
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Calculate board pixel size and center offsets
            int boardPixelWidth = controller.Board.Width * cellSize;
            int boardPixelHeight = controller.Board.Height * cellSize;

            int offsetX = (ClientSize.Width - boardPixelWidth) / 2;
            int offsetY = (ClientSize.Height - boardPixelHeight) / 2;

            // Move the board slightly up so there's more space below for status text
            int verticalShift = 30; // pixels to shift up
            offsetY = Math.Max(10, offsetY - verticalShift);

            // Draw board border
            // Fill board background (inner board area) with light green using RGB
            using (var boardBg = new SolidBrush(Color.FromArgb(236, 255, 220))) // RGB for light green
            {
                g.FillRectangle(boardBg, offsetX, offsetY, boardPixelWidth, boardPixelHeight);
            }

            // Draw board border
            g.DrawRectangle(Pens.Black, offsetX, offsetY, boardPixelWidth, boardPixelHeight);

            // Draw snake
            foreach (Position pos in controller.Snake.Body)
            {
                int x = offsetX + pos.X * cellSize;
                int y = offsetY + pos.Y * cellSize;

                // Use a darker green so the snake remains visible on the green board
                g.FillRectangle(Brushes.DarkGreen, x, y, cellSize, cellSize);
                g.DrawRectangle(Pens.Black, x, y, cellSize, cellSize);
            }

            // Draw current item
            if (controller.CurrentItem != null)
            {
                Brush itemBrush = Brushes.Red;
                if (controller.CurrentItem is BonusFood)
                    itemBrush = Brushes.Gold;

                int ix = offsetX + controller.CurrentItem.Position.X * cellSize;
                int iy = offsetY + controller.CurrentItem.Position.Y * cellSize;
                g.FillEllipse(itemBrush, ix, iy, cellSize, cellSize);
            }

            // Draw obstacles
            foreach (Obstacle obstacle in controller.Obstacles)
            {
                int ox = offsetX + obstacle.Position.X * cellSize;
                int oy = offsetY + obstacle.Position.Y * cellSize;
                g.FillRectangle(Brushes.Gray, ox, oy, cellSize, cellSize);
            }

            // Draw status text below the board
            int textX = offsetX;
            int textY = offsetY + boardPixelHeight + 10;

            using (var font12 = new Font("Arial", 12))
            using (var font10 = new Font("Arial", 10))
            {
                g.DrawString(
                    "Player: " + controller.Player.Name +
                    "   Score: " + controller.ScoreManager.CurrentScore +
                    "   High Score: " + controller.ScoreManager.HighScore +
                    "   Level: " + controller.LevelManager.CurrentLevel.LevelNumber,
                    font12,
                    Brushes.Black,
                    textX,
                    textY
                );

                g.DrawString(
                    "Normal Food = +1   Bonus Food = +3   Obstacles = Rocks",
                    font10,
                    Brushes.Black,
                    textX,
                    textY + 30
                );
            }
        }
    }
}
