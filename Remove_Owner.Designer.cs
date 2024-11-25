namespace Rental_Car
{
    partial class Remove_Owner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove_Owner));
            Renter_Show = new Button();
            Remove = new Button();
            back_button = new Button();
            button2 = new Button();
            close_button = new Button();
            Owner_Detail = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Owner_Detail).BeginInit();
            SuspendLayout();
            // 
            // Renter_Show
            // 
            Renter_Show.BackColor = Color.Tomato;
            Renter_Show.Cursor = Cursors.Hand;
            Renter_Show.FlatAppearance.BorderSize = 0;
            Renter_Show.FlatStyle = FlatStyle.Flat;
            Renter_Show.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Renter_Show.ForeColor = Color.Honeydew;
            Renter_Show.Location = new Point(27, 407);
            Renter_Show.Name = "Renter_Show";
            Renter_Show.Size = new Size(190, 31);
            Renter_Show.TabIndex = 70;
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
            Remove.Location = new Point(589, 407);
            Remove.Name = "Remove";
            Remove.Size = new Size(190, 31);
            Remove.TabIndex = 71;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = false;
            Remove.Click += Remove_Click;
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
            back_button.Location = new Point(12, 14);
            back_button.Name = "back_button";
            back_button.Size = new Size(37, 39);
            back_button.TabIndex = 72;
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
            button2.Location = new Point(68, 16);
            button2.Name = "button2";
            button2.Size = new Size(38, 35);
            button2.TabIndex = 73;
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
            close_button.Location = new Point(742, 20);
            close_button.Name = "close_button";
            close_button.Size = new Size(37, 39);
            close_button.TabIndex = 74;
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // Owner_Detail
            // 
            Owner_Detail.BackgroundColor = Color.White;
            Owner_Detail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Owner_Detail.Location = new Point(1, 85);
            Owner_Detail.Name = "Owner_Detail";
            Owner_Detail.Size = new Size(798, 280);
            Owner_Detail.TabIndex = 75;
            // 
            // Remove_Owner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(Owner_Detail);
            Controls.Add(close_button);
            Controls.Add(button2);
            Controls.Add(back_button);
            Controls.Add(Remove);
            Controls.Add(Renter_Show);
            Name = "Remove_Owner";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Remove_Owner_Load;
            ((System.ComponentModel.ISupportInitialize)Owner_Detail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Renter_Show;
        private Button Remove;
        private Button back_button;
        private Button button2;
        private Button close_button;
        private DataGridView Owner_Detail;
    }
}