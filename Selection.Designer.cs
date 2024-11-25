namespace Rental_Car
{
    partial class Selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selection));
            pictureBox1 = new PictureBox();
            Admin_Button = new Button();
            User_Button = new Button();
            button1 = new Button();
            close_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 454);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Admin_Button
            // 
            Admin_Button.BackColor = SystemColors.MenuHighlight;
            Admin_Button.Cursor = Cursors.Hand;
            Admin_Button.FlatAppearance.BorderSize = 0;
            Admin_Button.FlatStyle = FlatStyle.Flat;
            Admin_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Admin_Button.ForeColor = Color.Honeydew;
            Admin_Button.Location = new Point(107, 222);
            Admin_Button.Name = "Admin_Button";
            Admin_Button.Size = new Size(211, 48);
            Admin_Button.TabIndex = 2;
            Admin_Button.Text = "Admin";
            Admin_Button.UseVisualStyleBackColor = false;
            Admin_Button.Click += Admin_Button_Click;
            // 
            // User_Button
            // 
            User_Button.BackColor = SystemColors.MenuHighlight;
            User_Button.Cursor = Cursors.Hand;
            User_Button.FlatAppearance.BorderSize = 0;
            User_Button.FlatStyle = FlatStyle.Flat;
            User_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            User_Button.ForeColor = Color.Honeydew;
            User_Button.Location = new Point(468, 222);
            User_Button.Name = "User_Button";
            User_Button.Size = new Size(205, 48);
            User_Button.TabIndex = 3;
            User_Button.Text = "User";
            User_Button.UseVisualStyleBackColor = false;
            User_Button.Click += User_Button_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(37, 31);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            close_button.Location = new Point(751, 12);
            close_button.Name = "close_button";
            close_button.Size = new Size(37, 39);
            close_button.TabIndex = 60;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // Selection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(close_button);
            Controls.Add(button1);
            Controls.Add(User_Button);
            Controls.Add(Admin_Button);
            Controls.Add(pictureBox1);
            Cursor = Cursors.Hand;
            ForeColor = Color.Transparent;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Selection";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Admin_Button;
        private Button User_Button;
        private Button button1;
        private Button close_button;
    }
}