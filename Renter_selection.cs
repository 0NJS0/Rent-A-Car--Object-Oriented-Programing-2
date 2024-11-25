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
    public partial class Renter_selection : Form
    {
        public Renter_selection()
        {
            InitializeComponent();
        }

        private void Registration_Button_Click(object sender, EventArgs e)
        {
            Renter_Register regi = new Renter_Register();
            regi.Show();
            this.Hide();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            Renter_Login logi = new Renter_Login();
            logi.Show();
            this.Hide();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            User_Selection user = new User_Selection();
            user.Visible = true;
            this.Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Page1 page = new Page1();
            page.Visible = true;
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
