using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGameProject
{
    public class MainMenu : Form
    {
        private Button btnStart;
        private Button btnStats;
        private Button btnExit;
        private Label lblTitle;

        public MainMenu()
        {
            Text = "Snake Game Menu";
            Size = new Size(400, 300);
            StartPosition = FormStartPosition.CenterScreen;

            lblTitle = new Label();
            lblTitle.Text = "Snake Game";
            lblTitle.Font = new Font("Arial", 20, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(120, 30);

            btnStart = new Button();
            btnStart.Text = "Start Game";
            btnStart.Size = new Size(120, 40);
            btnStart.Location = new Point(130, 90);
            btnStart.Click += BtnStart_Click;

            btnStats = new Button();
            btnStats.Text = "View Info";
            btnStats.Size = new Size(120, 40);
            btnStats.Location = new Point(130, 140);
            btnStats.Click += BtnStats_Click;

            btnExit = new Button();
            btnExit.Text = "Exit";
            btnExit.Size = new Size(120, 40);
            btnExit.Location = new Point(130, 190);
            btnExit.Click += BtnExit_Click;

            Controls.Add(lblTitle);
            Controls.Add(btnStart);
            Controls.Add(btnStats);
            Controls.Add(btnExit);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.FormClosed += (s, args) => this.Show();
            gameForm.Show();
            this.Hide();
        }

        private void BtnStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Controls: Arrow keys (Up/Down/Left/Right)\n" +
                "Objective: Eat food to grow and earn points until achieve the target score. " +
                "Level 1 = 5\n" +
                "Level 2 = 10\n" +
                "Level 3 = 15\n" +
                "Challenges: Obstacles and increasing speed\n" +
                "Items: Normal Food(red) (+1), Bonus Food(yellow) (+3)\n" 
                "Levels: 3",
                "Game Info"
            );
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}