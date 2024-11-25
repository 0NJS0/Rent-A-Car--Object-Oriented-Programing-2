namespace Rental_Car
{
    partial class admin_customer_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_customer_details));
            Customer_Detail = new DataGridView();
            Print = new Button();
            Renter_Show = new Button();
            back_button = new Button();
            button2 = new Button();
            close_button = new Button();
            ((System.ComponentModel.ISupportInitialize)Customer_Detail).BeginInit();
            SuspendLayout();
            // 
            // Customer_Detail
            // 
            Customer_Detail.BackgroundColor = Color.White;
            Customer_Detail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Customer_Detail.Location = new Point(1, 65);
            Customer_Detail.Name = "Customer_Detail";
            Customer_Detail.Size = new Size(798, 280);
            Customer_Detail.TabIndex = 0;
            // 
            // Print
            // 
            Print.BackColor = Color.Tomato;
            Print.Cursor = Cursors.Hand;
            Print.FlatAppearance.BorderSize = 0;
            Print.FlatStyle = FlatStyle.Flat;
            Print.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Print.ForeColor = Color.Honeydew;
            Print.Location = new Point(571, 396);
            Print.Name = "Print";
            Print.Size = new Size(190, 31);
            Print.TabIndex = 67;
            Print.Text = "Print";
            Print.UseVisualStyleBackColor = false;
            Print.Click += Print_Click_1;
            // 
            // Renter_Show
            // 
            Renter_Show.BackColor = Color.Tomato;
            Renter_Show.Cursor = Cursors.Hand;
            Renter_Show.FlatAppearance.BorderSize = 0;
            Renter_Show.FlatStyle = FlatStyle.Flat;
            Renter_Show.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Renter_Show.ForeColor = Color.Honeydew;
            Renter_Show.Location = new Point(29, 396);
            Renter_Show.Name = "Renter_Show";
            Renter_Show.Size = new Size(190, 31);
            Renter_Show.TabIndex = 68;
            Renter_Show.Text = "Show Details";
            Renter_Show.UseVisualStyleBackColor = false;
            Renter_Show.Click += Renter_Show_Click_1;
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
            back_button.TabIndex = 69;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(68, 16);
            button2.Name = "button2";
            button2.Size = new Size(32, 31);
            button2.TabIndex = 70;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
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
            close_button.Location = new Point(751, 16);
            close_button.Name = "close_button";
            close_button.Size = new Size(37, 39);
            close_button.TabIndex = 71;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click_1;
            // 
            // admin_customer_details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(close_button);
            Controls.Add(button2);
            Controls.Add(back_button);
            Controls.Add(Renter_Show);
            Controls.Add(Print);
            Controls.Add(Customer_Detail);
            Name = "admin_customer_details";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)Customer_Detail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Customer_Detail;
        private Button Print;
        private Button Renter_Show;
        private Button back_button;
        private Button button2;
        private Button close_button;
    }
}