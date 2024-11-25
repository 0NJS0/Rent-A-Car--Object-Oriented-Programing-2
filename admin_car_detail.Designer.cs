namespace Rental_Car
{
    partial class admin_car_detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_car_detail));
            Car_Show = new Button();
            Car_Details = new DataGridView();
            Print = new Button();
            close_button = new Button();
            back_button = new Button();
            button2 = new Button();
            ImageBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Car_Details).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // Car_Show
            // 
            Car_Show.BackColor = Color.Tomato;
            Car_Show.Cursor = Cursors.Hand;
            Car_Show.FlatAppearance.BorderSize = 0;
            Car_Show.FlatStyle = FlatStyle.Flat;
            Car_Show.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Car_Show.ForeColor = Color.Honeydew;
            Car_Show.Location = new Point(12, 407);
            Car_Show.Name = "Car_Show";
            Car_Show.Size = new Size(190, 31);
            Car_Show.TabIndex = 63;
            Car_Show.Text = "Show Details";
            Car_Show.UseVisualStyleBackColor = false;
            Car_Show.Click += Car_Show_Click;
            // 
            // Car_Details
            // 
            Car_Details.BackgroundColor = Color.White;
            Car_Details.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Car_Details.Location = new Point(-4, 96);
            Car_Details.Name = "Car_Details";
            Car_Details.Size = new Size(426, 268);
            Car_Details.TabIndex = 64;
            Car_Details.Click += Car_Details_Click;
            // 
            // Print
            // 
            Print.BackColor = Color.Tomato;
            Print.Cursor = Cursors.Hand;
            Print.FlatAppearance.BorderSize = 0;
            Print.FlatStyle = FlatStyle.Flat;
            Print.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Print.ForeColor = Color.Honeydew;
            Print.Location = new Point(598, 407);
            Print.Name = "Print";
            Print.Size = new Size(190, 31);
            Print.TabIndex = 65;
            Print.Text = "Print";
            Print.UseVisualStyleBackColor = false;
            Print.Click += Print_Click;
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
            close_button.TabIndex = 66;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += back_button_Click;
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
            back_button.TabIndex = 67;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += button1_Click;
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
            button2.Click += button2_Click;
            // 
            // ImageBox
            // 
            ImageBox.BorderStyle = BorderStyle.Fixed3D;
            ImageBox.Location = new Point(452, 126);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(336, 204);
            ImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageBox.TabIndex = 83;
            ImageBox.TabStop = false;
            // 
            // admin_car_detail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(ImageBox);
            Controls.Add(button2);
            Controls.Add(back_button);
            Controls.Add(close_button);
            Controls.Add(Print);
            Controls.Add(Car_Details);
            Controls.Add(Car_Show);
            Name = "admin_car_detail";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)Car_Details).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Car_Show;
        private DataGridView Car_Details;
        private Button Print;
        private Button close_button;
        private Button back_button;
        private Button button2;
        private PictureBox ImageBox;
    }
}