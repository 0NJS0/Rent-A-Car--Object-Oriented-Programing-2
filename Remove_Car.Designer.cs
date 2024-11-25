namespace Rental_Car
{
    partial class Remove_Car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove_Car));
            Car_Detail = new DataGridView();
            button2 = new Button();
            back_button = new Button();
            close_button = new Button();
            Renter_Show = new Button();
            Remove = new Button();
            ImageBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Car_Detail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // Car_Detail
            // 
            Car_Detail.BackgroundColor = Color.White;
            Car_Detail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Car_Detail.Location = new Point(1, 85);
            Car_Detail.Name = "Car_Detail";
            Car_Detail.Size = new Size(430, 305);
            Car_Detail.TabIndex = 76;
            Car_Detail.CellClick += Car_Detail_CellClick;
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
            button2.Size = new Size(41, 35);
            button2.TabIndex = 77;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            back_button.TabIndex = 78;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
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
            close_button.TabIndex = 79;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // Renter_Show
            // 
            Renter_Show.BackColor = Color.Tomato;
            Renter_Show.Cursor = Cursors.Hand;
            Renter_Show.FlatAppearance.BorderSize = 0;
            Renter_Show.FlatStyle = FlatStyle.Flat;
            Renter_Show.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Renter_Show.ForeColor = Color.Honeydew;
            Renter_Show.Location = new Point(21, 407);
            Renter_Show.Name = "Renter_Show";
            Renter_Show.Size = new Size(190, 31);
            Renter_Show.TabIndex = 80;
            Renter_Show.Text = "Show Details";
            Renter_Show.UseVisualStyleBackColor = false;
            Renter_Show.Click += Renter_Show_Click;
            // 
            // Remove
            // 
            Remove.BackColor = Color.Tomato;
            Remove.Cursor = Cursors.Hand;
            Remove.FlatAppearance.BorderSize = 0;
            Remove.FlatStyle = FlatStyle.Flat;
            Remove.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Remove.ForeColor = Color.Honeydew;
            Remove.Location = new Point(598, 407);
            Remove.Name = "Remove";
            Remove.Size = new Size(190, 31);
            Remove.TabIndex = 81;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = false;
            Remove.Click += Remove_Click;
            // 
            // ImageBox
            // 
            ImageBox.BorderStyle = BorderStyle.Fixed3D;
            ImageBox.Location = new Point(452, 97);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(336, 204);
            ImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageBox.TabIndex = 82;
            ImageBox.TabStop = false;
            // 
            // Remove_Car
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(ImageBox);
            Controls.Add(Remove);
            Controls.Add(Renter_Show);
            Controls.Add(close_button);
            Controls.Add(back_button);
            Controls.Add(button2);
            Controls.Add(Car_Detail);
            Name = "Remove_Car";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Remove_Car";
            ((System.ComponentModel.ISupportInitialize)Car_Detail).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Car_Detail;
        private Button button2;
        private Button back_button;
        private Button close_button;
        private Button Renter_Show;
        private Button Remove;
        private PictureBox ImageBox;
    }
}