namespace Rental_Car
{
    partial class Owner_Log_In
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner_Log_In));
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label3 = new Label();
            Emailbox = new TextBox();
            PassBox = new TextBox();
            homeButton = new Button();
            Back_Button = new Button();
            close_button = new Button();
            Clear_Button = new Button();
            Login_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-31, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(846, 469);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.InactiveCaption;
            label6.Location = new Point(46, 134);
            label6.Name = "label6";
            label6.Size = new Size(56, 22);
            label6.TabIndex = 17;
            label6.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.InactiveCaption;
            label3.Location = new Point(12, 203);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 23;
            label3.Text = "Password";
            // 
            // Emailbox
            // 
            Emailbox.Location = new Point(134, 134);
            Emailbox.Name = "Emailbox";
            Emailbox.Size = new Size(182, 23);
            Emailbox.TabIndex = 24;
            Emailbox.TextAlign = HorizontalAlignment.Center;
            // 
            // PassBox
            // 
            PassBox.Location = new Point(134, 203);
            PassBox.Name = "PassBox";
            PassBox.PasswordChar = '*';
            PassBox.Size = new Size(182, 23);
            PassBox.TabIndex = 25;
            PassBox.Tag = "";
            PassBox.TextAlign = HorizontalAlignment.Center;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.Black;
            homeButton.BackgroundImage = (Image)resources.GetObject("homeButton.BackgroundImage");
            homeButton.BackgroundImageLayout = ImageLayout.Stretch;
            homeButton.Cursor = Cursors.Hand;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.ForeColor = Color.Transparent;
            homeButton.Location = new Point(70, 12);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(32, 31);
            homeButton.TabIndex = 32;
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // Back_Button
            // 
            Back_Button.BackColor = Color.Transparent;
            Back_Button.BackgroundImage = (Image)resources.GetObject("Back_Button.BackgroundImage");
            Back_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Back_Button.Cursor = Cursors.Hand;
            Back_Button.FlatAppearance.BorderSize = 0;
            Back_Button.FlatStyle = FlatStyle.Flat;
            Back_Button.ForeColor = Color.Transparent;
            Back_Button.Location = new Point(3, 8);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(37, 39);
            Back_Button.TabIndex = 33;
            Back_Button.UseVisualStyleBackColor = false;
            Back_Button.Click += Back_Button_Click;
            // 
            // close_button
            // 
            close_button.BackColor = Color.Black;
            close_button.BackgroundImage = (Image)resources.GetObject("close_button.BackgroundImage");
            close_button.BackgroundImageLayout = ImageLayout.Stretch;
            close_button.Cursor = Cursors.Hand;
            close_button.FlatAppearance.BorderSize = 0;
            close_button.FlatStyle = FlatStyle.Flat;
            close_button.ForeColor = Color.Transparent;
            close_button.Location = new Point(751, 8);
            close_button.Name = "close_button";
            close_button.Size = new Size(37, 39);
            close_button.TabIndex = 40;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // Clear_Button
            // 
            Clear_Button.BackColor = SystemColors.InactiveCaption;
            Clear_Button.Cursor = Cursors.Hand;
            Clear_Button.FlatAppearance.BorderSize = 0;
            Clear_Button.FlatStyle = FlatStyle.Flat;
            Clear_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clear_Button.ForeColor = Color.Black;
            Clear_Button.Location = new Point(12, 407);
            Clear_Button.Name = "Clear_Button";
            Clear_Button.Size = new Size(127, 31);
            Clear_Button.TabIndex = 48;
            Clear_Button.Text = "CLR";
            Clear_Button.UseVisualStyleBackColor = false;
            Clear_Button.Click += Clear_Button_Click;
            // 
            // Login_Button
            // 
            Login_Button.BackColor = SystemColors.InactiveCaption;
            Login_Button.Cursor = Cursors.Hand;
            Login_Button.FlatAppearance.BorderSize = 0;
            Login_Button.FlatStyle = FlatStyle.Flat;
            Login_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_Button.ForeColor = Color.Black;
            Login_Button.Location = new Point(189, 407);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(127, 31);
            Login_Button.TabIndex = 47;
            Login_Button.Text = "Log In";
            Login_Button.UseVisualStyleBackColor = false;
            Login_Button.Click += Login_Button_Click;
            // 
            // Owner_Log_In
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(Clear_Button);
            Controls.Add(Login_Button);
            Controls.Add(close_button);
            Controls.Add(Back_Button);
            Controls.Add(homeButton);
            Controls.Add(PassBox);
            Controls.Add(Emailbox);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Owner_Log_In";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label6;
        private Label label3;
        private TextBox Emailbox;
        private TextBox PassBox;
        private Button homeButton;
        private Button Back_Button;
        private Button close_button;
        private Button Clear_Button;
        private Button Login_Button;
    }
}