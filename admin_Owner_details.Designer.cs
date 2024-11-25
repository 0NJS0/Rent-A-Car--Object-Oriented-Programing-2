namespace Rental_Car
{
    partial class admin_Owner_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_Owner_details));
            Renter_details = new DataGridView();
            Renter_Show = new Button();
            Print = new Button();
            back_button = new Button();
            button2 = new Button();
            close_button = new Button();
            ((System.ComponentModel.ISupportInitialize)Renter_details).BeginInit();
            SuspendLayout();
            // 
            // Renter_details
            // 
            Renter_details.BackgroundColor = Color.White;
            Renter_details.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Renter_details.Location = new Point(-1, 63);
            Renter_details.Name = "Renter_details";
            Renter_details.Size = new Size(798, 280);
            Renter_details.TabIndex = 1;
            // 
            // Renter_Show
            // 
            Renter_Show.BackColor = Color.Tomato;
            Renter_Show.Cursor = Cursors.Hand;
            Renter_Show.FlatAppearance.BorderSize = 0;
            Renter_Show.FlatStyle = FlatStyle.Flat;
            Renter_Show.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Renter_Show.ForeColor = Color.Honeydew;
            Renter_Show.Location = new Point(30, 394);
            Renter_Show.Name = "Renter_Show";
            Renter_Show.Size = new Size(190, 31);
            Renter_Show.TabIndex = 64;
            Renter_Show.Text = "Show Details";
            Renter_Show.UseVisualStyleBackColor = false;
            Renter_Show.Click += Renter_Show_Click;
            // 
            // Print
            // 
            Print.BackColor = Color.Tomato;
            Print.Cursor = Cursors.Hand;
            Print.FlatAppearance.BorderSize = 0;
            Print.FlatStyle = FlatStyle.Flat;
            Print.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Print.ForeColor = Color.Honeydew;
            Print.Location = new Point(563, 394);
            Print.Name = "Print";
            Print.Size = new Size(190, 31);
            Print.TabIndex = 66;
            Print.Text = "Print";
            Print.UseVisualStyleBackColor = false;
            Print.Click += Print_Click;
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
            back_button.TabIndex = 68;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
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
            button2.Location = new Point(70, 16);
            button2.Name = "button2";
            button2.Size = new Size(32, 31);
            button2.TabIndex = 69;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            close_button.TabIndex = 70;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // admin_Owner_details
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
            Controls.Add(Print);
            Controls.Add(Renter_Show);
            Controls.Add(Renter_details);
            Name = "admin_Owner_details";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)Renter_details).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Renter_details;
        private Button Renter_Show;
        private Button Print;
        private Button back_button;
        private Button button2;
        private Button close_button;
    }
}