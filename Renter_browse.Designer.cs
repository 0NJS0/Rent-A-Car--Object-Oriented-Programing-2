namespace Rental_Car
{
    partial class Renter_browse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renter_browse));
            Car_Details = new DataGridView();
            Car_Show = new Button();
            Rent_Car = new Button();
            button2 = new Button();
            back_button = new Button();
            close_button = new Button();
            ImageBox = new PictureBox();
            BrandBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            ModelBox = new TextBox();
            label4 = new Label();
            ColorBox = new TextBox();
            label5 = new Label();
            SitBox = new TextBox();
            label6 = new Label();
            Days = new TextBox();
            label7 = new Label();
            StartDate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Car_Details).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // Car_Details
            // 
            Car_Details.BackgroundColor = Color.White;
            Car_Details.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Car_Details.Location = new Point(3, 126);
            Car_Details.Name = "Car_Details";
            Car_Details.Size = new Size(442, 268);
            Car_Details.TabIndex = 65;
            Car_Details.CellClick += Car_Details_CellClick;
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
            Car_Show.TabIndex = 66;
            Car_Show.Text = "Show Cars";
            Car_Show.UseVisualStyleBackColor = false;
            Car_Show.Click += Car_Show_Click;
            // 
            // Rent_Car
            // 
            Rent_Car.BackColor = Color.Tomato;
            Rent_Car.Cursor = Cursors.Hand;
            Rent_Car.FlatAppearance.BorderSize = 0;
            Rent_Car.FlatStyle = FlatStyle.Flat;
            Rent_Car.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rent_Car.ForeColor = Color.Honeydew;
            Rent_Car.Location = new Point(598, 407);
            Rent_Car.Name = "Rent_Car";
            Rent_Car.Size = new Size(190, 31);
            Rent_Car.TabIndex = 67;
            Rent_Car.Text = "Rent Car";
            Rent_Car.UseVisualStyleBackColor = false;
            Rent_Car.Click += Rent_Car_Click;
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
            button2.Location = new Point(55, 10);
            button2.Name = "button2";
            button2.Size = new Size(39, 35);
            button2.TabIndex = 71;
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
            back_button.Location = new Point(3, 6);
            back_button.Name = "back_button";
            back_button.Size = new Size(37, 39);
            back_button.TabIndex = 72;
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
            close_button.Location = new Point(751, 12);
            close_button.Name = "close_button";
            close_button.Size = new Size(37, 39);
            close_button.TabIndex = 73;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // ImageBox
            // 
            ImageBox.BorderStyle = BorderStyle.Fixed3D;
            ImageBox.Location = new Point(470, 190);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(336, 204);
            ImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageBox.TabIndex = 83;
            ImageBox.TabStop = false;
            // 
            // BrandBox
            // 
            BrandBox.Location = new Point(92, 70);
            BrandBox.Name = "BrandBox";
            BrandBox.Size = new Size(100, 23);
            BrandBox.TabIndex = 84;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(139, 29);
            label2.Name = "label2";
            label2.Size = new Size(53, 22);
            label2.TabIndex = 85;
            label2.Text = "Filter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(61, 22);
            label1.TabIndex = 86;
            label1.Text = "Brand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(198, 67);
            label3.Name = "label3";
            label3.Size = new Size(61, 22);
            label3.TabIndex = 87;
            label3.Text = "Model";
            // 
            // ModelBox
            // 
            ModelBox.Location = new Point(277, 66);
            ModelBox.Name = "ModelBox";
            ModelBox.Size = new Size(100, 23);
            ModelBox.TabIndex = 88;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(402, 63);
            label4.Name = "label4";
            label4.Size = new Size(54, 22);
            label4.TabIndex = 89;
            label4.Text = "Color";
            // 
            // ColorBox
            // 
            ColorBox.Location = new Point(479, 62);
            ColorBox.Name = "ColorBox";
            ColorBox.Size = new Size(100, 23);
            ColorBox.TabIndex = 90;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(590, 62);
            label5.Name = "label5";
            label5.Size = new Size(57, 22);
            label5.TabIndex = 91;
            label5.Text = "Sit No";
            // 
            // SitBox
            // 
            SitBox.Location = new Point(665, 61);
            SitBox.Name = "SitBox";
            SitBox.Size = new Size(100, 23);
            SitBox.TabIndex = 92;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(530, 150);
            label6.Name = "label6";
            label6.Size = new Size(117, 22);
            label6.TabIndex = 93;
            label6.Text = "Renting Days";
            // 
            // Days
            // 
            Days.Location = new Point(665, 150);
            Days.Name = "Days";
            Days.Size = new Size(100, 23);
            Days.TabIndex = 94;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(558, 114);
            label7.Name = "label7";
            label7.Size = new Size(89, 22);
            label7.TabIndex = 95;
            label7.Text = "Start Date";
            // 
            // StartDate
            // 
            StartDate.Location = new Point(665, 113);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(100, 23);
            StartDate.TabIndex = 96;
            // 
            // Renter_browse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(StartDate);
            Controls.Add(label7);
            Controls.Add(Days);
            Controls.Add(label6);
            Controls.Add(SitBox);
            Controls.Add(label5);
            Controls.Add(ColorBox);
            Controls.Add(label4);
            Controls.Add(ModelBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(BrandBox);
            Controls.Add(ImageBox);
            Controls.Add(close_button);
            Controls.Add(back_button);
            Controls.Add(button2);
            Controls.Add(Rent_Car);
            Controls.Add(Car_Show);
            Controls.Add(Car_Details);
            Name = "Renter_browse";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)Car_Details).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Car_Details;
        private Button Car_Show;
        private Button Rent_Car;
        private Button button2;
        private Button back_button;
        private Button close_button;
        private PictureBox ImageBox;
        private TextBox BrandBox;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox ModelBox;
        private Label label4;
        private TextBox ColorBox;
        private Label label5;
        private TextBox SitBox;
        private Label label6;
        private TextBox Days;
        private Label label7;
        private TextBox StartDate;
    }
}