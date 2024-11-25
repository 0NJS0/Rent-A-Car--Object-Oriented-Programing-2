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
    public partial class Admin_Selection : Form
    {
        public Admin_Selection()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Selection selection = new Selection();
            selection.Visible = true;
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Page1 page = new Page1();
            page.Visible = true;
            this.Hide();

        }

        private void close_button_Click_1(object sender, EventArgs e)
        {
            Closing close = new Closing();
            close.Show();
            this.Hide();

        }

        private void Admin_Register_Button_Click(object sender, EventArgs e)
        {
            Admin_Registration regi = new Admin_Registration();
            regi.Show();
            this.Hide();

        }

        private void Admin_LogIn_Button_Click_1(object sender, EventArgs e)
        {
            Admin_login login = new Admin_login();
            login.Show();
            this.Hide();

        }
    }
}
