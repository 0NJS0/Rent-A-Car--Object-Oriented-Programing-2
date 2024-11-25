namespace Rental_Car
{
    partial class Renter_selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renter_selection));
            Registration_Button = new Button();
            LogIn = new Button();
            back_button = new Button();
            homeButton = new Button();
            pictureBox1 = new PictureBox();
            close_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Registration_Button
            // 
            Registration_Button.BackColor = Color.LightSkyBlue;
            Registration_Button.Cursor = Cursors.Hand;
            Registration_Button.FlatAppearance.BorderSize = 0;
            Registration_Button.FlatStyle = FlatStyle.Flat;
            Registration_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Registration_Button.ForeColor = Color.Honeydew;
            Registration_Button.Location = new Point(12, 148);
            Registration_Button.Name = "Registration_Button";
            Registration_Button.Size = new Size(161, 58);
            Registration_Button.TabIndex = 5;
            Registration_Button.Text = "Register";
            Registration_Button.UseVisualStyleBackColor = false;
            Registration_Button.Click += Registration_Button_Click;
            // 
            // LogIn
            // 
            LogIn.BackColor = Color.LightSkyBlue;
            LogIn.Cursor = Cursors.Hand;
            LogIn.FlatAppearance.BorderSize = 0;
            LogIn.FlatStyle = FlatStyle.Flat;
            LogIn.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogIn.ForeColor = Color.Honeydew;
            LogIn.Location = new Point(12, 246);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(162, 53);
            LogIn.TabIndex = 6;
            LogIn.Text = "Log In";
            LogIn.UseVisualStyleBackColor = false;
            LogIn.Click += LogIn_Click;
            // 
            // back_button
            // 
            back_button.BackColor = Color.Transparent;
            back_button.BackgroundImage = (Image)resources.GetObject("back_button.BackgroundImage");
            back_button.BackgroundImageLayout = ImageLayout.Stretch;
            back_button.Cursor = Cursors.Hand;
            back_button.FlatAppearance.BorderSize = 0;
            back_button.FlatStyle = FlatStyle.Flat;
            back_button.ForeColor = Color.Transparent;
            back_button.Location = new Point(12, 12);
            back_button.Name = "back_button";
            back_button.Size = new Size(37, 39);
            back_button.TabIndex = 34;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
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
            homeButton.Location = new Point(74, 16);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(42, 35);
            homeButton.TabIndex = 35;
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(212, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(596, 463);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // close_button
            // 
            close_button.BackColor = Color.SkyBlue;
            close_button.BackgroundImage = (Image)resources.GetObject("close_button.BackgroundImage");
            close_button.BackgroundImageLayout = ImageLayout.Stretch;
            close_button.Cursor = Cursors.Hand;
            close_button.FlatAppearance.BorderSize = 0;
            close_button.FlatStyle = FlatStyle.Flat;
            close_button.ForeColor = Color.Transparent;
            close_button.Location = new Point(751, 8);
            close_button.Name = "close_button";
            close_button.Size = new Size(37, 39);
            close_button.TabIndex = 60;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // Renter_selection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(close_button);
            Controls.Add(pictureBox1);
            Controls.Add(homeButton);
            Controls.Add(back_button);
            Controls.Add(LogIn);
            Controls.Add(Registration_Button);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Renter_selection";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Registration_Button;
        private Button LogIn;
        private Button back_button;
        private Button homeButton;
        private PictureBox pictureBox1;
        private Button close_button;
    }
}