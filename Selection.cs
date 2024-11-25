using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Car
{
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void Admin_Button_Click(object sender, EventArgs e)
        {
            Admin_Selection selection = new Admin_Selection();
            selection.Show();
            this.Hide();
        }

        private void User_Button_Click(object sender, EventArgs e)
        {
            User_Selection selection = new User_Selection();
            selection.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page1 homepage = new Page1();
            homepage.Visible = true;
            this.Hide();

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Closing close = new Closing();
            close.Show();
            this.Hide();
        }
    }
}
