namespace Rental_Car
{
    partial class Admin_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Registration));
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            close_button = new Button();
            label5 = new Label();
            ConfirmPassBox = new TextBox();
            NID_no = new TextBox();
            NID = new Label();
            Save_Button = new Button();
            Clear_Button = new Button();
            button4 = new Button();
            homeButton = new Button();
            PhoneBox = new TextBox();
            EmailBox = new TextBox();
            AddressBox = new TextBox();
            PassBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            NameBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(36, 35);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(66, 12);
            button2.Name = "button2";
            button2.Size = new Size(30, 35);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(152, 203);
            label2.Name = "label2";
            label2.Size = new Size(0, 45);
            label2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-13, -12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(829, 470);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // close_button
            // 
            close_button.BackColor = Color.Gainsboro;
            close_button.BackgroundImage = (Image)resources.GetObject("close_button.BackgroundImage");
            close_button.BackgroundImageLayout = ImageLayout.Stretch;
            close_button.Cursor = Cursors.Hand;
            close_button.FlatAppearance.BorderSize = 0;
            close_button.FlatStyle = FlatStyle.Flat;
            close_button.ForeColor = Color.Transparent;
            close_button.Location = new Point(754, 10);
            close_button.Name = "close_button";
            close_button.Size = new Size(34, 37);
            close_button.TabIndex = 74;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 167);
            label5.Name = "label5";
            label5.Size = new Size(161, 22);
            label5.TabIndex = 73;
            label5.Text = "Confirm Password";
            // 
            // ConfirmPassBox
            // 
            ConfirmPassBox.Location = new Point(173, 166);
            ConfirmPassBox.Name = "ConfirmPassBox";
            ConfirmPassBox.Size = new Size(182, 23);
            ConfirmPassBox.TabIndex = 72;
            ConfirmPassBox.TextAlign = HorizontalAlignment.Center;
            // 
            // NID_no
            // 
            NID_no.Location = new Point(173, 361);
            NID_no.Name = "NID_no";
            NID_no.Size = new Size(182, 23);
            NID_no.TabIndex = 71;
            NID_no.TextAlign = HorizontalAlignment.Center;
            // 
            // NID
            // 
            NID.AutoSize = true;
            NID.BackColor = Color.WhiteSmoke;
            NID.FlatStyle = FlatStyle.Flat;
            NID.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NID.Location = new Point(123, 362);
            NID.Name = "NID";
            NID.Size = new Size(42, 22);
            NID.TabIndex = 70;
            NID.Text = "NID";
            // 
            // Save_Button
            // 
            Save_Button.BackColor = Color.LightGray;
            Save_Button.Cursor = Cursors.Hand;
            Save_Button.FlatAppearance.BorderSize = 0;
            Save_Button.FlatStyle = FlatStyle.Flat;
            Save_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Save_Button.ForeColor = Color.Black;
            Save_Button.Location = new Point(661, 407);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(127, 31);
            Save_Button.TabIndex = 69;
            Save_Button.Text = "Save";
            Save_Button.UseVisualStyleBackColor = false;
            Save_Button.Click += Save_Button_Click_1;
            // 
            // Clear_Button
            // 
            Clear_Button.BackColor = Color.LightGray;
            Clear_Button.Cursor = Cursors.Hand;
            Clear_Button.FlatAppearance.BorderSize = 0;
            Clear_Button.FlatStyle = FlatStyle.Flat;
            Clear_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clear_Button.ForeColor = Color.Black;
            Clear_Button.Location = new Point(496, 407);
            Clear_Button.Name = "Clear_Button";
            Clear_Button.Size = new Size(127, 31);
            Clear_Button.TabIndex = 68;
            Clear_Button.Text = "CLR";
            Clear_Button.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGray;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(11, 8);
            button4.Name = "button4";
            button4.Size = new Size(37, 39);
            button4.TabIndex = 67;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.DarkGray;
            homeButton.BackgroundImage = (Image)resources.GetObject("homeButton.BackgroundImage");
            homeButton.BackgroundImageLayout = ImageLayout.Stretch;
            homeButton.Cursor = Cursors.Hand;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.ForeColor = Color.Transparent;
            homeButton.Location = new Point(75, 12);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(32, 31);
            homeButton.TabIndex = 66;
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(173, 311);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(182, 23);
            PhoneBox.TabIndex = 65;
            PhoneBox.TextAlign = HorizontalAlignment.Center;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(173, 261);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(182, 23);
            EmailBox.TabIndex = 64;
            EmailBox.TextAlign = HorizontalAlignment.Center;
            // 
            // AddressBox
            // 
            AddressBox.Location = new Point(173, 207);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(182, 23);
            AddressBox.TabIndex = 63;
            AddressBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PassBox
            // 
            PassBox.Location = new Point(173, 119);
            PassBox.Name = "PassBox";
            PassBox.Size = new Size(182, 23);
            PassBox.TabIndex = 62;
            PassBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.WhiteSmoke;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 312);
            label7.Name = "label7";
            label7.Size = new Size(132, 22);
            label7.TabIndex = 61;
            label7.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(109, 261);
            label6.Name = "label6";
            label6.Size = new Size(56, 22);
            label6.TabIndex = 60;
            label6.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(88, 208);
            label4.Name = "label4";
            label4.Size = new Size(77, 22);
            label4.TabIndex = 59;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 120);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 58;
            label3.Text = "Password";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(173, 79);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(182, 23);
            NameBox.TabIndex = 57;
            NameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(60, 79);
            label1.Name = "label1";
            label1.Size = new Size(92, 22);
            label1.TabIndex = 56;
            label1.Text = "Full Name";
            // 
            // Admin_Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(close_button);
            Controls.Add(label5);
            Controls.Add(ConfirmPassBox);
            Controls.Add(NID_no);
            Controls.Add(NID);
            Controls.Add(Save_Button);
            Controls.Add(Clear_Button);
            Controls.Add(button4);
            Controls.Add(homeButton);
            Controls.Add(PhoneBox);
            Controls.Add(EmailBox);
            Controls.Add(AddressBox);
            Controls.Add(PassBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(NameBox);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_Registration";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label2;
        private PictureBox pictureBox2;
        private Button close_button;
        private Label label5;
        private TextBox ConfirmPassBox;
        private TextBox NID_no;
        private Label NID;
        private Button Save_Button;
        private Button Clear_Button;
        private Button button4;
        private Button homeButton;
        private TextBox PhoneBox;
        private TextBox EmailBox;
        private TextBox AddressBox;
        private TextBox PassBox;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox NameBox;
        private Label label1;
    }
}