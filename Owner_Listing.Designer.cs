namespace Rental_Car
{
    partial class Renter_Listing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renter_Listing));
            Logout_Button = new Button();
            Listing = new DataGridView();
            Image = new PictureBox();
            close_button = new Button();
            homeButton = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)Listing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Image).BeginInit();
            SuspendLayout();
            // 
            // Logout_Button
            // 
            Logout_Button.BackColor = Color.DarkRed;
            Logout_Button.Cursor = Cursors.Hand;
            Logout_Button.FlatAppearance.BorderSize = 0;
            Logout_Button.FlatStyle = FlatStyle.Flat;
            Logout_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout_Button.ForeColor = Color.Honeydew;
            Logout_Button.Location = new Point(319, 393);
            Logout_Button.Name = "Logout_Button";
            Logout_Button.Size = new Size(190, 45);
            Logout_Button.TabIndex = 60;
            Logout_Button.Text = "Show";
            Logout_Button.UseVisualStyleBackColor = false;
            Logout_Button.Click += Logout_Button_Click;
            // 
            // Listing
            // 
            Listing.BackgroundColor = SystemColors.Control;
            Listing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Listing.Location = new Point(0, 68);
            Listing.Name = "Listing";
            Listing.Size = new Size(446, 282);
            Listing.TabIndex = 63;
            Listing.Click += Listing_Click;
            // 
            // Image
            // 
            Image.Location = new Point(472, 85);
            Image.Name = "Image";
            Image.Size = new Size(316, 246);
            Image.SizeMode = PictureBoxSizeMode.StretchImage;
            Image.TabIndex = 64;
            Image.TabStop = false;
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
            close_button.TabIndex = 69;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
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
            homeButton.Location = new Point(68, 12);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(32, 31);
            homeButton.TabIndex = 70;
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
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
            button4.Location = new Point(11, 8);
            button4.Name = "button4";
            button4.Size = new Size(37, 39);
            button4.TabIndex = 71;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Renter_Listing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(homeButton);
            Controls.Add(close_button);
            Controls.Add(Image);
            Controls.Add(Listing);
            Controls.Add(Logout_Button);
            Name = "Renter_Listing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Renter_Listing";
            ((System.ComponentModel.ISupportInitialize)Listing).EndInit();
            ((System.ComponentModel.ISupportInitialize)Image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Logout_Button;
        private DataGridView Listing;
        private PictureBox Image;
        private Button close_button;
        private Button homeButton;
        private Button button4;
    }
}