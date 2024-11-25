namespace Rental_Car
{
    partial class admin_invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_invoice));
            close_button = new Button();
            button2 = new Button();
            back_button = new Button();
            Invoice_Detail = new DataGridView();
            Rent_Car = new Button();
            Show_Invoice = new Button();
            ((System.ComponentModel.ISupportInitialize)Invoice_Detail).BeginInit();
            SuspendLayout();
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
            close_button.TabIndex = 74;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
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
            button2.Size = new Size(37, 35);
            button2.TabIndex = 75;
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
            back_button.TabIndex = 76;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // Invoice_Detail
            // 
            Invoice_Detail.BackgroundColor = Color.White;
            Invoice_Detail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Invoice_Detail.Location = new Point(1, 91);
            Invoice_Detail.Name = "Invoice_Detail";
            Invoice_Detail.Size = new Size(798, 268);
            Invoice_Detail.TabIndex = 77;
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
            Rent_Car.TabIndex = 78;
            Rent_Car.Text = "Print Transcactions";
            Rent_Car.UseVisualStyleBackColor = false;
            Rent_Car.Click += Rent_Car_Click;
            // 
            // Show_Invoice
            // 
            Show_Invoice.BackColor = Color.Tomato;
            Show_Invoice.Cursor = Cursors.Hand;
            Show_Invoice.FlatAppearance.BorderSize = 0;
            Show_Invoice.FlatStyle = FlatStyle.Flat;
            Show_Invoice.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Show_Invoice.ForeColor = Color.Honeydew;
            Show_Invoice.Location = new Point(12, 407);
            Show_Invoice.Name = "Show_Invoice";
            Show_Invoice.Size = new Size(190, 31);
            Show_Invoice.TabIndex = 79;
            Show_Invoice.Text = "Show Transcactions";
            Show_Invoice.UseVisualStyleBackColor = false;
            Show_Invoice.Click += button1_Click;
            // 
            // admin_invoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(Show_Invoice);
            Controls.Add(Rent_Car);
            Controls.Add(Invoice_Detail);
            Controls.Add(back_button);
            Controls.Add(button2);
            Controls.Add(close_button);
            Name = "admin_invoice";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)Invoice_Detail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button close_button;
        private Button button2;
        private Button back_button;
        private DataGridView Invoice_Detail;
        private Button Rent_Car;
        private Button Show_Invoice;
    }
}