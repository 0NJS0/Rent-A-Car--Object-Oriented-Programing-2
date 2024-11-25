namespace Rental_Car
{
    partial class Renter_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renter_Form));
            welcometext = new Label();
            Welcome = new Label();
            Logout_Button = new Button();
            close_button = new Button();
            Browse_Car = new Button();
            Customer_History = new Button();
            SuspendLayout();
            // 
            // welcometext
            // 
            welcometext.AutoSize = true;
            welcometext.BackColor = Color.Transparent;
            welcometext.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcometext.ForeColor = Color.Black;
            welcometext.Location = new Point(336, 36);
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
            Welcome.Location = new Point(308, 81);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(0, 22);
            Welcome.TabIndex = 56;
            Welcome.TextAlign = ContentAlignment.TopCenter;
            // 
            // Logout_Button
            // 
            Logout_Button.BackColor = Color.Tomato;
            Logout_Button.Cursor = Cursors.Hand;
            Logout_Button.FlatAppearance.BorderSize = 0;
            Logout_Button.FlatStyle = FlatStyle.Flat;
            Logout_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout_Button.ForeColor = Color.Honeydew;
            Logout_Button.Location = new Point(651, 397);
            Logout_Button.Name = "Logout_Button";
            Logout_Button.Size = new Size(127, 31);
            Logout_Button.TabIndex = 58;
            Logout_Button.Text = "LogOut";
            Logout_Button.UseVisualStyleBackColor = false;
            Logout_Button.Click += Logout_Button_Click;
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
            close_button.TabIndex = 59;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // Browse_Car
            // 
            Browse_Car.BackColor = Color.Tomato;
            Browse_Car.Cursor = Cursors.Hand;
            Browse_Car.FlatAppearance.BorderSize = 0;
            Browse_Car.FlatStyle = FlatStyle.Flat;
            Browse_Car.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Browse_Car.ForeColor = Color.Honeydew;
            Browse_Car.Location = new Point(57, 108);
            Browse_Car.Name = "Browse_Car";
            Browse_Car.Size = new Size(265, 233);
            Browse_Car.TabIndex = 60;
            Browse_Car.Text = "Browse Cars";
            Browse_Car.UseVisualStyleBackColor = false;
            Browse_Car.Click += Browse_Car_Click;
            // 
            // Customer_History
            // 
            Customer_History.BackColor = Color.Tomato;
            Customer_History.Cursor = Cursors.Hand;
            Customer_History.FlatAppearance.BorderSize = 0;
            Customer_History.FlatStyle = FlatStyle.Flat;
            Customer_History.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Customer_History.ForeColor = Color.Honeydew;
            Customer_History.Location = new Point(449, 108);
            Customer_History.Name = "Customer_History";
            Customer_History.Size = new Size(265, 233);
            Customer_History.TabIndex = 61;
            Customer_History.Text = "History";
            Customer_History.UseVisualStyleBackColor = false;
            Customer_History.Click += Customer_History_Click;
            // 
            // Renter_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(Customer_History);
            Controls.Add(Browse_Car);
            Controls.Add(close_button);
            Controls.Add(Logout_Button);
            Controls.Add(welcometext);
            Controls.Add(Welcome);
            Name = "Renter_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Customer_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcometext;
        private Label Welcome;
        private Button Logout_Button;
        private Button close_button;
        private Button Browse_Car;
        private Button Customer_History;
    }
}