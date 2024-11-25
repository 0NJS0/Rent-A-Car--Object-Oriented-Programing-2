namespace Rental_Car
{
    partial class Remove_Renter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove_Renter));
            Customer_Detail = new DataGridView();
            Remove = new Button();
            Renter_Show = new Button();
            back_button = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)Customer_Detail).BeginInit();
            SuspendLayout();
            // 
            // Customer_Detail
            // 
            Customer_Detail.BackgroundColor = Color.White;
            Customer_Detail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Customer_Detail.Location = new Point(1, 85);
            Customer_Detail.Name = "Customer_Detail";
            Customer_Detail.Size = new Size(798, 280);
            Customer_Detail.TabIndex = 1;
            Customer_Detail.CellContentClick += Customer_Detail_CellContentClick;
            // 
            // Remove
            // 
            Remove.BackColor = Color.Tomato;
            Remove.Cursor = Cursors.Hand;
            Remove.FlatAppearance.BorderSize = 0;
            Remove.FlatStyle = FlatStyle.Flat;
            Remove.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Remove.ForeColor = Color.Honeydew;
            Remove.Location = new Point(585, 407);
            Remove.Name = "Remove";
            Remove.Size = new Size(190, 31);
            Remove.TabIndex = 68;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = false;
            Remove.Click += Remove_Click;
            // 
            // Renter_Show
            // 
            Renter_Show.BackColor = Color.Tomato;
            Renter_Show.Cursor = Cursors.Hand;
            Renter_Show.FlatAppearance.BorderSize = 0;
            Renter_Show.FlatStyle = FlatStyle.Flat;
            Renter_Show.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Renter_Show.ForeColor = Color.Honeydew;
            Renter_Show.Location = new Point(28, 407);
            Renter_Show.Name = "Renter_Show";
            Renter_Show.Size = new Size(190, 31);
            Renter_Show.TabIndex = 69;
            Renter_Show.Text = "Show Details";
            Renter_Show.UseVisualStyleBackColor = false;
            Renter_Show.Click += Renter_Show_Click;
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
            back_button.Location = new Point(738, 12);
            back_button.Name = "back_button";
            back_button.Size = new Size(37, 39);
            back_button.TabIndex = 70;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(37, 39);
            button1.TabIndex = 71;
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
            button2.Location = new Point(66, 16);
            button2.Name = "button2";
            button2.Size = new Size(40, 35);
            button2.TabIndex = 72;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Remove_Renter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(back_button);
            Controls.Add(Renter_Show);
            Controls.Add(Remove);
            Controls.Add(Customer_Detail);
            Name = "Remove_Renter";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Remove_Renter_Load;
            ((System.ComponentModel.ISupportInitialize)Customer_Detail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Customer_Detail;
        private Button Remove;
        private Button Renter_Show;
        private Button back_button;
        private Button button1;
        private Button button2;
    }
}