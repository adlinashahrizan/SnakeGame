using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace SnakeGameProject
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            GameForm game = new GameForm();
            this.Hide();
            
            game.ShowDialog();
            this.Show();
        }

        //
        //rules
        //
        private void button2_Click(object sender, EventArgs e)
        {
            //simple rules window and return to the main menu when closed
            this.Hide();

            Form rulesForm = new Form();
            rulesForm.Text = "Rules";
            rulesForm.ClientSize = new Size(420, 260);
            rulesForm.StartPosition = FormStartPosition.CenterParent;

            Label rulesLabel = new Label();
            rulesLabel.Text =
                "\t-----Snake Game Rules!-----\n\t\t 1. Use arrow keys to move the snake.\n" +
                "\t\t 2. Eat the food to grow longer.\n" +
                "\t\t 3. Avoid hitting the walls or yourself.\n" +
                "\t\t 4. Hitting obstacles will end the game.\n" +
                "\t\t 5. Special yellow fruit gives extra points :3";
            rulesLabel.AutoSize = false;
            rulesLabel.Size = new Size(380, 160);
            rulesLabel.Location = new Point(10, 10);
            rulesLabel.TextAlign = ContentAlignment.TopLeft;

            Button back = new Button();
            back.Text = "Back";
            back.Size = new Size(80, 30);
            back.Location = new Point((rulesForm.ClientSize.Width - back.Width) / 2, rulesLabel.Bottom + 10);
            back.Click += (s, ev) => rulesForm.Close();

            rulesForm.Controls.Add(rulesLabel);
            rulesForm.Controls.Add(back);

            
            rulesForm.BackColor = Color.FromArgb(155, 188, 15);
            rulesLabel.ForeColor = Color.Black;

            rulesForm.ShowDialog(this);
            this.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
