namespace Rental_Car
{
    partial class Owner_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner_Form));
            welcometext = new Label();
            Welcome = new Label();
            close_button = new Button();
            Logout_Button = new Button();
            Add_Car = new Button();
            button1 = new Button();
            Renting_History = new Button();
            SuspendLayout();
            // 
            // welcometext
            // 
            welcometext.AutoSize = true;
            welcometext.BackColor = Color.Transparent;
            welcometext.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcometext.ForeColor = Color.Black;
            welcometext.Location = new Point(356, 30);
            welcometext.Name = "welcometext";
            welcometext.Size = new Size(84, 22);
            welcometext.TabIndex = 57;
            welcometext.Text = "Welcome";
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.BackColor = Color.Transparent;
            Welcome.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Welcome.ForeColor = Color.Black;
            Welcome.Location = new Point(268, 77);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(0, 22);
            Welcome.TabIndex = 56;
            Welcome.TextAlign = ContentAlignment.TopCenter;
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
            close_button.Location = new Point(751, 13);
            close_button.Name = "close_button";
            close_button.Size = new Size(37, 39);
            close_button.TabIndex = 60;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // Logout_Button
            // 
            Logout_Button.BackColor = Color.DarkRed;
            Logout_Button.Cursor = Cursors.Hand;
            Logout_Button.FlatAppearance.BorderSize = 0;
            Logout_Button.FlatStyle = FlatStyle.Flat;
            Logout_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout_Button.ForeColor = Color.Honeydew;
            Logout_Button.Location = new Point(661, 407);
            Logout_Button.Name = "Logout_Button";
            Logout_Button.Size = new Size(127, 31);
            Logout_Button.TabIndex = 61;
            Logout_Button.Text = "LogOut";
            Logout_Button.UseVisualStyleBackColor = false;
            Logout_Button.Click += Logout_Button_Click;
            // 
            // Add_Car
            // 
            Add_Car.BackColor = Color.DarkRed;
            Add_Car.Cursor = Cursors.Hand;
            Add_Car.FlatAppearance.BorderSize = 0;
            Add_Car.FlatStyle = FlatStyle.Flat;
            Add_Car.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_Car.ForeColor = Color.Honeydew;
            Add_Car.Location = new Point(36, 139);
            Add_Car.Name = "Add_Car";
            Add_Car.Size = new Size(193, 194);
            Add_Car.TabIndex = 62;
            Add_Car.Text = "Add Car";
            Add_Car.UseVisualStyleBackColor = false;
            Add_Car.Click += Add_Car_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Honeydew;
            button1.Location = new Point(310, 139);
            button1.Name = "button1";
            button1.Size = new Size(193, 194);
            button1.TabIndex = 63;
            button1.Text = "Listed Cars";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Renting_History
            // 
            Renting_History.BackColor = Color.DarkRed;
            Renting_History.Cursor = Cursors.Hand;
            Renting_History.FlatAppearance.BorderSize = 0;
            Renting_History.FlatStyle = FlatStyle.Flat;
            Renting_History.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Renting_History.ForeColor = Color.Honeydew;
            Renting_History.Location = new Point(583, 139);
            Renting_History.Name = "Renting_History";
            Renting_History.Size = new Size(193, 194);
            Renting_History.TabIndex = 64;
            Renting_History.Text = "Renting History";
            Renting_History.UseVisualStyleBackColor = false;
            Renting_History.Click += Renting_History_Click;
            // 
            // Owner_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(Renting_History);
            Controls.Add(button1);
            Controls.Add(Add_Car);
            Controls.Add(Logout_Button);
            Controls.Add(close_button);
            Controls.Add(welcometext);
            Controls.Add(Welcome);
            Name = "Owner_Form";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcometext;
        private Label Welcome;
        private Button close_button;
        private Button Logout_Button;
        private Button Add_Car;
        private Button button1;
        private Button Renting_History;
    }
}