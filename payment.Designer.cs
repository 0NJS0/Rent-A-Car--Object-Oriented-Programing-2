namespace Rental_Car
{
    partial class payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment));
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            Payment_method = new Label();
            label3 = new Label();
            initial_payment = new TextBox();
            Pay = new Button();
            Cancel = new Button();
            label4 = new Label();
            Amount = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cash On Delivery", "Bkash", "Nagad" });
            comboBox1.Location = new Point(433, 126);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 14.25F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(183, 127);
            label1.Name = "label1";
            label1.Size = new Size(198, 22);
            label1.TabIndex = 2;
            label1.Text = "Select Payment Method";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 14.25F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(163, 195);
            label2.Name = "label2";
            label2.Size = new Size(218, 22);
            label2.TabIndex = 3;
            label2.Text = "Selected Payment Method";
            // 
            // Payment_method
            // 
            Payment_method.AutoSize = true;
            Payment_method.BackColor = Color.Transparent;
            Payment_method.Font = new Font("Cambria", 14.25F);
            Payment_method.Location = new Point(433, 195);
            Payment_method.Name = "Payment_method";
            Payment_method.Size = new Size(18, 22);
            Payment_method.TabIndex = 4;
            Payment_method.Text = "?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 14.25F);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(248, 295);
            label3.Name = "label3";
            label3.Size = new Size(133, 22);
            label3.TabIndex = 5;
            label3.Text = "Initial Payment";
            // 
            // initial_payment
            // 
            initial_payment.Location = new Point(433, 298);
            initial_payment.Name = "initial_payment";
            initial_payment.Size = new Size(129, 23);
            initial_payment.TabIndex = 6;
            // 
            // Pay
            // 
            Pay.BackColor = Color.Tomato;
            Pay.Cursor = Cursors.Hand;
            Pay.FlatAppearance.BorderSize = 0;
            Pay.FlatStyle = FlatStyle.Flat;
            Pay.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pay.ForeColor = Color.Honeydew;
            Pay.Location = new Point(598, 407);
            Pay.Name = "Pay";
            Pay.Size = new Size(190, 31);
            Pay.TabIndex = 68;
            Pay.Text = "Pay";
            Pay.UseVisualStyleBackColor = false;
            Pay.Click += Pay_Click;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.Tomato;
            Cancel.Cursor = Cursors.Hand;
            Cancel.FlatAppearance.BorderSize = 0;
            Cancel.FlatStyle = FlatStyle.Flat;
            Cancel.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cancel.ForeColor = Color.Honeydew;
            Cancel.Location = new Point(12, 407);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(190, 31);
            Cancel.TabIndex = 69;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cambria", 14.25F);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(262, 64);
            label4.Name = "label4";
            label4.Size = new Size(119, 22);
            label4.TabIndex = 70;
            label4.Text = "Total Amount";
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.BackColor = Color.Transparent;
            Amount.Font = new Font("Cambria", 14.25F);
            Amount.ForeColor = SystemColors.ControlText;
            Amount.Location = new Point(433, 64);
            Amount.Name = "Amount";
            Amount.Size = new Size(119, 22);
            Amount.TabIndex = 71;
            Amount.Text = "Total Amount";
            // 
            // payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(Amount);
            Controls.Add(label4);
            Controls.Add(Cancel);
            Controls.Add(Pay);
            Controls.Add(initial_payment);
            Controls.Add(label3);
            Controls.Add(Payment_method);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "payment";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label Payment_method;
        private Label label3;
        private TextBox initial_payment;
        private Button Pay;
        private Button Cancel;
        private Label label4;
        private Label Amount;
    }
}