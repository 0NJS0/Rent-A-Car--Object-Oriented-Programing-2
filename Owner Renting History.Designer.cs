namespace Rental_Car
{
    partial class Renter_Renting_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renter_Renting_History));
            Logout_Button = new Button();
            HistoryGrid = new DataGridView();
            button1 = new Button();
            button4 = new Button();
            homeButton = new Button();
            close_button = new Button();
            ((System.ComponentModel.ISupportInitialize)HistoryGrid).BeginInit();
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
            Logout_Button.Location = new Point(12, 393);
            Logout_Button.Name = "Logout_Button";
            Logout_Button.Size = new Size(190, 45);
            Logout_Button.TabIndex = 61;
            Logout_Button.Text = "Show";
            Logout_Button.UseVisualStyleBackColor = false;
            Logout_Button.Click += Logout_Button_Click;
            // 
            // HistoryGrid
            // 
            HistoryGrid.BackgroundColor = SystemColors.Control;
            HistoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistoryGrid.Location = new Point(-1, 88);
            HistoryGrid.Name = "HistoryGrid";
            HistoryGrid.Size = new Size(802, 274);
            HistoryGrid.TabIndex = 64;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Honeydew;
            button1.Location = new Point(588, 393);
            button1.Name = "button1";
            button1.Size = new Size(190, 45);
            button1.TabIndex = 65;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
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
            button4.Location = new Point(12, 21);
            button4.Name = "button4";
            button4.Size = new Size(37, 39);
            button4.TabIndex = 66;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
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
            homeButton.Location = new Point(69, 25);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(32, 31);
            homeButton.TabIndex = 67;
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
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
            close_button.Location = new Point(751, 21);
            close_button.Name = "close_button";
            close_button.Size = new Size(37, 39);
            close_button.TabIndex = 68;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // Renter_Renting_History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(close_button);
            Controls.Add(homeButton);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(HistoryGrid);
            Controls.Add(Logout_Button);
            Name = "Renter_Renting_History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Renter_Renting_History";
            ((System.ComponentModel.ISupportInitialize)HistoryGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Logout_Button;
        private DataGridView HistoryGrid;
        private Button button1;
        private Button button4;
        private Button homeButton;
        private Button close_button;
    }
}