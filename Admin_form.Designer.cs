namespace Rental_Car
{
    partial class Admin_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_form));
            Print = new Button();
            Welcome = new Label();
            welcometext = new Label();
            Remove_Renter = new Button();
            Customer_Details = new Button();
            Renter_Details = new Button();
            Remove_Customer = new Button();
            Logout_Button = new Button();
            back_button = new Button();
            Car_Detail = new Button();
            Remove_Car = new Button();
            SuspendLayout();
            // 
            // Print
            // 
            Print.BackColor = Color.Tomato;
            Print.Cursor = Cursors.Hand;
            Print.FlatAppearance.BorderSize = 0;
            Print.FlatStyle = FlatStyle.Flat;
            Print.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Print.ForeColor = Color.Honeydew;
            Print.Location = new Point(34, 390);
            Print.Name = "Print";
            Print.Size = new Size(190, 31);
            Print.TabIndex = 53;
            Print.Text = "Transactions";
            Print.UseVisualStyleBackColor = false;
            Print.Click += Print_Click;
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.BackColor = Color.Transparent;
            Welcome.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Welcome.ForeColor = Color.Black;
            Welcome.Location = new Point(358, 45);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(0, 22);
            Welcome.TabIndex = 54;
            Welcome.TextAlign = ContentAlignment.TopCenter;
            // 
            // welcometext
            // 
            welcometext.AutoSize = true;
            welcometext.BackColor = Color.Transparent;
            welcometext.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcometext.ForeColor = Color.Black;
            welcometext.Location = new Point(344, 9);
            welcometext.Name = "welcometext";
            welcometext.Size = new Size(84, 22);
            welcometext.TabIndex = 55;
            welcometext.Text = "Welcome";
            // 
            // Remove_Renter
            // 
            Remove_Renter.BackColor = Color.Tomato;
            Remove_Renter.Cursor = Cursors.Hand;
            Remove_Renter.FlatAppearance.BorderSize = 0;
            Remove_Renter.FlatStyle = FlatStyle.Flat;
            Remove_Renter.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Remove_Renter.ForeColor = Color.Honeydew;
            Remove_Renter.Location = new Point(34, 222);
            Remove_Renter.Name = "Remove_Renter";
            Remove_Renter.Size = new Size(190, 31);
            Remove_Renter.TabIndex = 56;
            Remove_Renter.Text = "Remove Renter";
            Remove_Renter.UseVisualStyleBackColor = false;
            Remove_Renter.Click += Remove_Renter_Click;
            // 
            // Customer_Details
            // 
            Customer_Details.BackColor = Color.Tomato;
            Customer_Details.Cursor = Cursors.Hand;
            Customer_Details.FlatAppearance.BorderSize = 0;
            Customer_Details.FlatStyle = FlatStyle.Flat;
            Customer_Details.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Customer_Details.ForeColor = Color.Honeydew;
            Customer_Details.Location = new Point(34, 164);
            Customer_Details.Name = "Customer_Details";
            Customer_Details.Size = new Size(190, 31);
            Customer_Details.TabIndex = 57;
            Customer_Details.Text = "Renter Details";
            Customer_Details.UseVisualStyleBackColor = false;
            Customer_Details.Click += Customer_Details_Click;
            // 
            // Renter_Details
            // 
            Renter_Details.BackColor = Color.Tomato;
            Renter_Details.Cursor = Cursors.Hand;
            Renter_Details.FlatAppearance.BorderSize = 0;
            Renter_Details.FlatStyle = FlatStyle.Flat;
            Renter_Details.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Renter_Details.ForeColor = Color.Honeydew;
            Renter_Details.Location = new Point(34, 103);
            Renter_Details.Name = "Renter_Details";
            Renter_Details.Size = new Size(190, 31);
            Renter_Details.TabIndex = 58;
            Renter_Details.Text = "Owner Details";
            Renter_Details.UseVisualStyleBackColor = false;
            Renter_Details.Click += Renter_Details_Click;
            // 
            // Remove_Customer
            // 
            Remove_Customer.BackColor = Color.Tomato;
            Remove_Customer.Cursor = Cursors.Hand;
            Remove_Customer.FlatAppearance.BorderSize = 0;
            Remove_Customer.FlatStyle = FlatStyle.Flat;
            Remove_Customer.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Remove_Customer.ForeColor = Color.Honeydew;
            Remove_Customer.Location = new Point(34, 276);
            Remove_Customer.Name = "Remove_Customer";
            Remove_Customer.Size = new Size(190, 31);
            Remove_Customer.TabIndex = 59;
            Remove_Customer.Text = "Remove Owner";
            Remove_Customer.UseVisualStyleBackColor = false;
            Remove_Customer.Click += Remove_Customer_Click;
            // 
            // Logout_Button
            // 
            Logout_Button.BackColor = Color.Tomato;
            Logout_Button.Cursor = Cursors.Hand;
            Logout_Button.FlatAppearance.BorderSize = 0;
            Logout_Button.FlatStyle = FlatStyle.Flat;
            Logout_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout_Button.ForeColor = Color.Honeydew;
            Logout_Button.Location = new Point(661, 407);
            Logout_Button.Name = "Logout_Button";
            Logout_Button.Size = new Size(127, 31);
            Logout_Button.TabIndex = 60;
            Logout_Button.Text = "LogOut";
            Logout_Button.UseVisualStyleBackColor = false;
            Logout_Button.Click += Logout_Button_Click;
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
            back_button.Location = new Point(751, 12);
            back_button.Name = "back_button";
            back_button.Size = new Size(37, 39);
            back_button.TabIndex = 61;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // Car_Detail
            // 
            Car_Detail.BackColor = Color.Tomato;
            Car_Detail.Cursor = Cursors.Hand;
            Car_Detail.FlatAppearance.BorderSize = 0;
            Car_Detail.FlatStyle = FlatStyle.Flat;
            Car_Detail.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Car_Detail.ForeColor = Color.Honeydew;
            Car_Detail.Location = new Point(34, 45);
            Car_Detail.Name = "Car_Detail";
            Car_Detail.Size = new Size(190, 31);
            Car_Detail.TabIndex = 62;
            Car_Detail.Text = "Car Details";
            Car_Detail.UseVisualStyleBackColor = false;
            Car_Detail.Click += Car_Detail_Click;
            // 
            // Remove_Car
            // 
            Remove_Car.BackColor = Color.Tomato;
            Remove_Car.Cursor = Cursors.Hand;
            Remove_Car.FlatAppearance.BorderSize = 0;
            Remove_Car.FlatStyle = FlatStyle.Flat;
            Remove_Car.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Remove_Car.ForeColor = Color.Honeydew;
            Remove_Car.Location = new Point(34, 328);
            Remove_Car.Name = "Remove_Car";
            Remove_Car.Size = new Size(190, 31);
            Remove_Car.TabIndex = 63;
            Remove_Car.Text = "Remove Car";
            Remove_Car.UseVisualStyleBackColor = false;
            Remove_Car.Click += Remove_Car_Click;
            // 
            // Admin_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(Remove_Car);
            Controls.Add(Car_Detail);
            Controls.Add(back_button);
            Controls.Add(Logout_Button);
            Controls.Add(Remove_Customer);
            Controls.Add(Renter_Details);
            Controls.Add(Customer_Details);
            Controls.Add(Remove_Renter);
            Controls.Add(welcometext);
            Controls.Add(Welcome);
            Controls.Add(Print);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_form";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Print;
        private Label Welcome;
        private Label welcometext;
        private Button Remove_Renter;
        private Button Customer_Details;
        private Button Renter_Details;
        private Button Remove_Customer;
        private Button Logout_Button;
        private Button back_button;
        private Button Car_Detail;
        private Button Remove_Car;
    }
}