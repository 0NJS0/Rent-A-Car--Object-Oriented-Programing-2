namespace Rental_Car
{
    partial class Owner_selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner_selection));
            homeButton = new Button();
            close_button = new Button();
            pictureBox1 = new PictureBox();
            LogIn = new Button();
            Registration_Button = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.Transparent;
            homeButton.BackgroundImage = (Image)resources.GetObject("homeButton.BackgroundImage");
            homeButton.BackgroundImageLayout = ImageLayout.Stretch;
            homeButton.Cursor = Cursors.Hand;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.ForeColor = Color.Transparent;
            homeButton.Location = new Point(94, 20);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(32, 31);
            homeButton.TabIndex = 31;
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // close_button
            // 
            close_button.BackColor = Color.Transparent;
            close_button.BackgroundImage = (Image)resources.GetObject("close_button.BackgroundImage");
            close_button.BackgroundImageLayout = ImageLayout.Stretch;
            close_button.Cursor = Cursors.Hand;
            close_button.FlatAppearance.BorderSize = 0;
            close_button.FlatStyle = FlatStyle.Flat;
            close_button.ForeColor = Color.Transparent;
            close_button.Location = new Point(751, 12);
            close_button.Name = "close_button";
            close_button.Size = new Size(37, 39);
            close_button.TabIndex = 60;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Desktop;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(218, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(583, 331);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            LogIn.BackColor = Color.Teal;
            LogIn.Cursor = Cursors.Hand;
            LogIn.FlatAppearance.BorderSize = 0;
            LogIn.FlatStyle = FlatStyle.Flat;
            LogIn.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogIn.ForeColor = Color.Honeydew;
            LogIn.Location = new Point(12, 264);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(200, 45);
            LogIn.TabIndex = 62;
            LogIn.Text = "Log In";
            LogIn.UseVisualStyleBackColor = false;
            LogIn.Click += LogIn_Click_1;
            // 
            // Registration_Button
            // 
            Registration_Button.BackColor = Color.Teal;
            Registration_Button.Cursor = Cursors.Hand;
            Registration_Button.FlatAppearance.BorderSize = 0;
            Registration_Button.FlatStyle = FlatStyle.Flat;
            Registration_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Registration_Button.ForeColor = Color.Honeydew;
            Registration_Button.Location = new Point(12, 113);
            Registration_Button.Name = "Registration_Button";
            Registration_Button.Size = new Size(200, 54);
            Registration_Button.TabIndex = 61;
            Registration_Button.Text = "Register";
            Registration_Button.UseVisualStyleBackColor = false;
            Registration_Button.Click += Registration_Button_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(94, 24);
            button1.Name = "button1";
            button1.Size = new Size(32, 31);
            button1.TabIndex = 31;
            button1.UseVisualStyleBackColor = false;
            button1.Click += homeButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(26, 20);
            button2.Name = "button2";
            button2.Size = new Size(37, 39);
            button2.TabIndex = 32;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button4_Click;
            // 
            // Owner_selection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(LogIn);
            Controls.Add(Registration_Button);
            Controls.Add(close_button);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(homeButton);
            ForeColor = SystemColors.InactiveCaptionText;
            Name = "Owner_selection";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button homeButton;
        private Button close_button;
        private PictureBox pictureBox1;
        private Button LogIn;
        private Button Registration_Button;
        private Button button1;
        private Button button2;
    }
}