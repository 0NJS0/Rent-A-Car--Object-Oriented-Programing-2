namespace Rental_Car
{
    partial class Page1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
            pictureBox1 = new PictureBox();
            Proceed = new Button();
            Close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-12, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(820, 467);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // Proceed
            // 
            Proceed.BackColor = Color.Black;
            Proceed.Location = new Point(617, 372);
            Proceed.Name = "Proceed";
            Proceed.Size = new Size(128, 35);
            Proceed.TabIndex = 41;
            Proceed.Text = "Proceed";
            Proceed.UseVisualStyleBackColor = false;
            Proceed.Click += Proceed_Click_2;
            // 
            // Close
            // 
            Close.BackColor = Color.Black;
            Close.BackgroundImage = (Image)resources.GetObject("Close.BackgroundImage");
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Cursor = Cursors.Hand;
            Close.FlatStyle = FlatStyle.Flat;
            Close.ForeColor = Color.Transparent;
            Close.Location = new Point(754, 12);
            Close.Name = "Close";
            Close.Size = new Size(34, 34);
            Close.TabIndex = 42;
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // Page1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(Close);
            Controls.Add(Proceed);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.Menu;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Page1";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Proceed;
        private Button Close;
    }
}
