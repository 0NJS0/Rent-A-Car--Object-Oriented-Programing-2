namespace Rental_Car
{
    partial class User_Selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Selection));
            Renter_Button = new Button();
            User_Button = new Button();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            close_button = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Renter_Button
            // 
            Renter_Button.BackColor = Color.LightSeaGreen;
            Renter_Button.Cursor = Cursors.Hand;
            Renter_Button.FlatAppearance.BorderSize = 0;
            Renter_Button.FlatStyle = FlatStyle.Flat;
            Renter_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Renter_Button.ForeColor = Color.Honeydew;
            Renter_Button.Location = new Point(47, 134);
            Renter_Button.Name = "Renter_Button";
            Renter_Button.Size = new Size(203, 54);
            Renter_Button.TabIndex = 3;
            Renter_Button.Text = "Owner";
            Renter_Button.UseVisualStyleBackColor = false;
            Renter_Button.Click += Renter_Button_Click;
            // 
            // User_Button
            // 
            User_Button.BackColor = Color.LightSeaGreen;
            User_Button.Cursor = Cursors.Hand;
            User_Button.FlatAppearance.BorderSize = 0;
            User_Button.FlatStyle = FlatStyle.Flat;
            User_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            User_Button.ForeColor = Color.Honeydew;
            User_Button.Location = new Point(47, 253);
            User_Button.Name = "User_Button";
            User_Button.Size = new Size(203, 57);
            User_Button.TabIndex = 4;
            User_Button.Text = "Renter";
            User_Button.UseVisualStyleBackColor = false;
            User_Button.Click += User_Button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(321, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(478, 289);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(12, 10);
            button4.Name = "button4";
            button4.Size = new Size(37, 39);
            button4.TabIndex = 31;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
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
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(78, 12);
            button1.Name = "button1";
            button1.Size = new Size(43, 39);
            button1.TabIndex = 61;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // User_Selection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(close_button);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(User_Button);
            Controls.Add(Renter_Button);
            DoubleBuffered = true;
            Name = "User_Selection";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Renter_Button;
        private Button User_Button;
        private PictureBox pictureBox1;
        private Button button4;
        private Button close_button;
        private Button button1;
    }
}