namespace Rental_Car
{
    partial class Renter_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renter_Login));
            pictureBox1 = new PictureBox();
            back_button = new Button();
            homeButton = new Button();
            label6 = new Label();
            label3 = new Label();
            Emailbox = new TextBox();
            PassBox = new TextBox();
            Login_Button = new Button();
            Clear_Button = new Button();
            close_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(368, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 408);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // back_button
            // 
            back_button.BackColor = SystemColors.Control;
            back_button.BackgroundImage = (Image)resources.GetObject("back_button.BackgroundImage");
            back_button.BackgroundImageLayout = ImageLayout.Stretch;
            back_button.Cursor = Cursors.Hand;
            back_button.FlatAppearance.BorderSize = 0;
            back_button.FlatStyle = FlatStyle.Flat;
            back_button.ForeColor = Color.Transparent;
            back_button.Location = new Point(12, 12);
            back_button.Name = "back_button";
            back_button.Size = new Size(37, 39);
            back_button.TabIndex = 39;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // homeButton
            // 
            homeButton.BackColor = SystemColors.Control;
            homeButton.BackgroundImage = (Image)resources.GetObject("homeButton.BackgroundImage");
            homeButton.BackgroundImageLayout = ImageLayout.Stretch;
            homeButton.Cursor = Cursors.Hand;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.ForeColor = Color.Transparent;
            homeButton.Location = new Point(70, 16);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(32, 31);
            homeButton.TabIndex = 40;
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightBlue;
            label6.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 133);
            label6.Name = "label6";
            label6.Size = new Size(56, 22);
            label6.TabIndex = 41;
            label6.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightBlue;
            label3.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 195);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 42;
            label3.Text = "Password";
            // 
            // Emailbox
            // 
            Emailbox.Location = new Point(133, 132);
            Emailbox.Name = "Emailbox";
            Emailbox.Size = new Size(182, 23);
            Emailbox.TabIndex = 43;
            Emailbox.TextAlign = HorizontalAlignment.Center;
            // 
            // PassBox
            // 
            PassBox.Location = new Point(133, 198);
            PassBox.Name = "PassBox";
            PassBox.PasswordChar = '*';
            PassBox.Size = new Size(182, 23);
            PassBox.TabIndex = 44;
            PassBox.Tag = "";
            PassBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Login_Button
            // 
            Login_Button.BackColor = SystemColors.GradientInactiveCaption;
            Login_Button.Cursor = Cursors.Hand;
            Login_Button.FlatAppearance.BorderSize = 0;
            Login_Button.FlatStyle = FlatStyle.Flat;
            Login_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_Button.ForeColor = Color.Black;
            Login_Button.Location = new Point(188, 407);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(127, 31);
            Login_Button.TabIndex = 45;
            Login_Button.Text = "Log In";
            Login_Button.UseVisualStyleBackColor = false;
            Login_Button.Click += Login_Button_Click;
            // 
            // Clear_Button
            // 
            Clear_Button.BackColor = SystemColors.GradientInactiveCaption;
            Clear_Button.Cursor = Cursors.Hand;
            Clear_Button.FlatAppearance.BorderSize = 0;
            Clear_Button.FlatStyle = FlatStyle.Flat;
            Clear_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clear_Button.ForeColor = Color.Black;
            Clear_Button.Location = new Point(21, 407);
            Clear_Button.Name = "Clear_Button";
            Clear_Button.Size = new Size(127, 31);
            Clear_Button.TabIndex = 46;
            Clear_Button.Text = "CLR";
            Clear_Button.UseVisualStyleBackColor = false;
            Clear_Button.Click += Clear_Button_Click;
            // 
            // close_button
            // 
            close_button.BackColor = Color.White;
            close_button.BackgroundImage = (Image)resources.GetObject("close_button.BackgroundImage");
            close_button.BackgroundImageLayout = ImageLayout.Stretch;
            close_button.Cursor = Cursors.Hand;
            close_button.FlatAppearance.BorderSize = 0;
            close_button.FlatStyle = FlatStyle.Flat;
            close_button.ForeColor = Color.Transparent;
            close_button.Location = new Point(751, 16);
            close_button.Name = "close_button";
            close_button.Size = new Size(37, 39);
            close_button.TabIndex = 60;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // Renter_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(close_button);
            Controls.Add(Clear_Button);
            Controls.Add(Login_Button);
            Controls.Add(PassBox);
            Controls.Add(Emailbox);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(homeButton);
            Controls.Add(back_button);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Renter_Login";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button back_button;
        private Button homeButton;
        private Label label6;
        private Label label3;
        private TextBox Emailbox;
        private TextBox PassBox;
        private Button Login_Button;
        private Button Clear_Button;
        private Button close_button;
    }
}