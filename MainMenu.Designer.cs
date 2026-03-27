namespace Snake_Game_Jan26
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("OCR A Extended", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(416, 306);
            button1.Name = "button1";
            button1.Size = new Size(124, 72);
            button1.TabIndex = 0;
            button1.Text = "PLAY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(607, 317);
            button2.Name = "button2";
            button2.Size = new Size(147, 53);
            button2.TabIndex = 1;
            button2.Text = "RULES";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(62, 317);
            button3.Name = "button3";
            button3.Size = new Size(137, 53);
            button3.TabIndex = 2;
            button3.Text = "EXIT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-460, -29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1262, 705);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(238, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 181);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.f632a812eb1afc3;
            pictureBox3.Location = new Point(238, 285);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(319, 117);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Gemini_Generated_Image_vr6yyovr6yyovr6y;
            pictureBox4.Location = new Point(-69, -135);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(461, 607);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Name = "MainMenu";
            Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
