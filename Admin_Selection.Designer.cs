namespace Rental_Car
{
    partial class Admin_Selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Selection));
            pictureBox1 = new PictureBox();
            close_button = new Button();
            button1 = new Button();
            Admin_LogIn_Button = new Button();
            Admin_Register_Button = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-27, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(835, 523);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // close_button
            // 
            close_button.BackColor = Color.Maroon;
            close_button.BackgroundImage = (Image)resources.GetObject("close_button.BackgroundImage");
            close_button.BackgroundImageLayout = ImageLayout.Stretch;
            close_button.Cursor = Cursors.Hand;
            close_button.FlatAppearance.BorderSize = 0;
            close_button.FlatStyle = FlatStyle.Flat;
            close_button.ForeColor = Color.Transparent;
            close_button.Location = new Point(723, 14);
            close_button.Name = "close_button";
            close_button.Size = new Size(37, 39);
            close_button.TabIndex = 47;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(37, 39);
            button1.TabIndex = 45;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Admin_LogIn_Button
            // 
            Admin_LogIn_Button.BackColor = Color.Maroon;
            Admin_LogIn_Button.Cursor = Cursors.Hand;
            Admin_LogIn_Button.FlatAppearance.BorderSize = 0;
            Admin_LogIn_Button.FlatStyle = FlatStyle.Flat;
            Admin_LogIn_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Admin_LogIn_Button.ForeColor = Color.Honeydew;
            Admin_LogIn_Button.Location = new Point(12, 329);
            Admin_LogIn_Button.Name = "Admin_LogIn_Button";
            Admin_LogIn_Button.Size = new Size(293, 53);
            Admin_LogIn_Button.TabIndex = 44;
            Admin_LogIn_Button.Text = "Log In";
            Admin_LogIn_Button.UseVisualStyleBackColor = false;
            Admin_LogIn_Button.Click += Admin_LogIn_Button_Click_1;
            // 
            // Admin_Register_Button
            // 
            Admin_Register_Button.BackColor = Color.Maroon;
            Admin_Register_Button.Cursor = Cursors.Hand;
            Admin_Register_Button.FlatAppearance.BorderSize = 0;
            Admin_Register_Button.FlatStyle = FlatStyle.Flat;
            Admin_Register_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Admin_Register_Button.ForeColor = Color.Honeydew;
            Admin_Register_Button.Location = new Point(12, 154);
            Admin_Register_Button.Name = "Admin_Register_Button";
            Admin_Register_Button.Size = new Size(293, 53);
            Admin_Register_Button.TabIndex = 43;
            Admin_Register_Button.Text = "Register";
            Admin_Register_Button.UseVisualStyleBackColor = false;
            Admin_Register_Button.Click += Admin_Register_Button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(69, 14);
            button2.Name = "button2";
            button2.Size = new Size(39, 37);
            button2.TabIndex = 46;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Admin_Selection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(close_button);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Admin_LogIn_Button);
            Controls.Add(Admin_Register_Button);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_Selection";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button close_button;
        private Button button1;
        private Button Admin_LogIn_Button;
        private Button Admin_Register_Button;
        private Button button2;
    }
}