namespace Rental_Car
{
    partial class Renter_history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renter_history));
            Logout_Button = new Button();
            HistoryGrid = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            close_button = new Button();
            ((System.ComponentModel.ISupportInitialize)HistoryGrid).BeginInit();
            SuspendLayout();
            // 
            // Logout_Button
            // 
            Logout_Button.BackColor = Color.Tomato;
            Logout_Button.Cursor = Cursors.Hand;
            Logout_Button.FlatAppearance.BorderSize = 0;
            Logout_Button.FlatStyle = FlatStyle.Flat;
            Logout_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout_Button.ForeColor = Color.Honeydew;
            Logout_Button.Location = new Point(12, 393);
            Logout_Button.Name = "Logout_Button";
            Logout_Button.Size = new Size(190, 45);
            Logout_Button.TabIndex = 59;
            Logout_Button.Text = "Show";
            Logout_Button.UseVisualStyleBackColor = false;
            Logout_Button.Click += Logout_Button_Click;
            // 
            // HistoryGrid
            // 
            HistoryGrid.BackgroundColor = SystemColors.Control;
            HistoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistoryGrid.Location = new Point(0, 96);
            HistoryGrid.Name = "HistoryGrid";
            HistoryGrid.Size = new Size(802, 274);
            HistoryGrid.TabIndex = 60;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Honeydew;
            button1.Location = new Point(598, 393);
            button1.Name = "button1";
            button1.Size = new Size(190, 45);
            button1.TabIndex = 61;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            button2.Location = new Point(78, 30);
            button2.Name = "button2";
            button2.Size = new Size(39, 35);
            button2.TabIndex = 72;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(12, 26);
            button3.Name = "button3";
            button3.Size = new Size(37, 39);
            button3.TabIndex = 73;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            close_button.Location = new Point(751, 26);
            close_button.Name = "close_button";
            close_button.Size = new Size(37, 39);
            close_button.TabIndex = 74;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // Renter_history
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(close_button);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(HistoryGrid);
            Controls.Add(Logout_Button);
            Name = "Renter_history";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer_history";
            ((System.ComponentModel.ISupportInitialize)HistoryGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Logout_Button;
        private DataGridView HistoryGrid;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button close_button;
    }
}