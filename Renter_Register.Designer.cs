namespace Rental_Car
{
    partial class Renter_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renter_Register));
            back_button = new Button();
            homeButton = new Button();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            NID = new Label();
            label2 = new Label();
            NameBox = new TextBox();
            PassBox = new TextBox();
            ConfirmPassBox = new TextBox();
            AddressBox = new TextBox();
            EmailBox = new TextBox();
            PhoneBox = new TextBox();
            NID_no = new TextBox();
            OccupationBox = new TextBox();
            Clear_Button = new Button();
            Save_Button = new Button();
            close_button = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            back_button.Location = new Point(25, 12);
            back_button.Name = "back_button";
            back_button.Size = new Size(37, 39);
            back_button.TabIndex = 38;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
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
            homeButton.Location = new Point(86, 16);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(32, 31);
            homeButton.TabIndex = 39;
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(81, 65);
            label1.Name = "label1";
            label1.Size = new Size(92, 22);
            label1.TabIndex = 40;
            label1.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.AppWorkspace;
            label3.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(83, 115);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 41;
            label3.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.AppWorkspace;
            label5.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 162);
            label5.Name = "label5";
            label5.Size = new Size(161, 22);
            label5.TabIndex = 42;
            label5.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.AppWorkspace;
            label4.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(96, 216);
            label4.Name = "label4";
            label4.Size = new Size(77, 22);
            label4.TabIndex = 43;
            label4.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.AppWorkspace;
            label6.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(117, 261);
            label6.Name = "label6";
            label6.Size = new Size(56, 22);
            label6.TabIndex = 44;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.AppWorkspace;
            label7.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(41, 301);
            label7.Name = "label7";
            label7.Size = new Size(132, 22);
            label7.TabIndex = 45;
            label7.Text = "Phone Number";
            // 
            // NID
            // 
            NID.AutoSize = true;
            NID.BackColor = SystemColors.AppWorkspace;
            NID.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NID.Location = new Point(38, 343);
            NID.Name = "NID";
            NID.Size = new Size(135, 22);
            NID.TabIndex = 48;
            NID.Text = "Driving License";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 392);
            label2.Name = "label2";
            label2.Size = new Size(101, 22);
            label2.TabIndex = 49;
            label2.Text = "Occupation";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(208, 65);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(182, 23);
            NameBox.TabIndex = 50;
            NameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PassBox
            // 
            PassBox.Location = new Point(208, 114);
            PassBox.Name = "PassBox";
            PassBox.Size = new Size(182, 23);
            PassBox.TabIndex = 51;
            PassBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ConfirmPassBox
            // 
            ConfirmPassBox.Location = new Point(208, 165);
            ConfirmPassBox.Name = "ConfirmPassBox";
            ConfirmPassBox.Size = new Size(182, 23);
            ConfirmPassBox.TabIndex = 52;
            ConfirmPassBox.TextAlign = HorizontalAlignment.Center;
            // 
            // AddressBox
            // 
            AddressBox.Location = new Point(208, 215);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(182, 23);
            AddressBox.TabIndex = 53;
            AddressBox.TextAlign = HorizontalAlignment.Center;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(208, 260);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(182, 23);
            EmailBox.TabIndex = 54;
            EmailBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(208, 300);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(182, 23);
            PhoneBox.TabIndex = 55;
            PhoneBox.TextAlign = HorizontalAlignment.Center;
            // 
            // NID_no
            // 
            NID_no.Location = new Point(208, 342);
            NID_no.Name = "NID_no";
            NID_no.Size = new Size(182, 23);
            NID_no.TabIndex = 56;
            NID_no.TextAlign = HorizontalAlignment.Center;
            // 
            // OccupationBox
            // 
            OccupationBox.Location = new Point(208, 391);
            OccupationBox.Name = "OccupationBox";
            OccupationBox.Size = new Size(182, 23);
            OccupationBox.TabIndex = 57;
            OccupationBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Clear_Button
            // 
            Clear_Button.BackColor = Color.Gainsboro;
            Clear_Button.Cursor = Cursors.Hand;
            Clear_Button.FlatAppearance.BorderSize = 0;
            Clear_Button.FlatStyle = FlatStyle.Flat;
            Clear_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clear_Button.ForeColor = Color.Black;
            Clear_Button.Location = new Point(505, 407);
            Clear_Button.Name = "Clear_Button";
            Clear_Button.Size = new Size(127, 31);
            Clear_Button.TabIndex = 58;
            Clear_Button.Text = "CLR";
            Clear_Button.UseVisualStyleBackColor = false;
            Clear_Button.Click += Clear_Button_Click;
            // 
            // Save_Button
            // 
            Save_Button.BackColor = Color.Gainsboro;
            Save_Button.Cursor = Cursors.Hand;
            Save_Button.FlatAppearance.BorderSize = 0;
            Save_Button.FlatStyle = FlatStyle.Flat;
            Save_Button.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Save_Button.ForeColor = Color.Black;
            Save_Button.Location = new Point(672, 407);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(127, 31);
            Save_Button.TabIndex = 59;
            Save_Button.Text = "Save";
            Save_Button.UseVisualStyleBackColor = false;
            Save_Button.Click += Save_Button_Click;
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
            close_button.TabIndex = 60;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(451, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            // 
            // Renter_Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(close_button);
            Controls.Add(Save_Button);
            Controls.Add(Clear_Button);
            Controls.Add(OccupationBox);
            Controls.Add(NID_no);
            Controls.Add(PhoneBox);
            Controls.Add(EmailBox);
            Controls.Add(AddressBox);
            Controls.Add(ConfirmPassBox);
            Controls.Add(PassBox);
            Controls.Add(NameBox);
            Controls.Add(label2);
            Controls.Add(NID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(homeButton);
            Controls.Add(back_button);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Renter_Register";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button back_button;
        private Button homeButton;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label NID;
        private Label label2;
        private TextBox NameBox;
        private TextBox PassBox;
        private TextBox ConfirmPassBox;
        private TextBox AddressBox;
        private TextBox EmailBox;
        private TextBox PhoneBox;
        private TextBox NID_no;
        private TextBox OccupationBox;
        private Button Clear_Button;
        private Button Save_Button;
        private Button close_button;
        private PictureBox pictureBox1;
    }
}