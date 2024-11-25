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
    public partial class Owner_selection : Form
    {
        public Owner_selection()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Page1 page = new Page1();
            page.Visible = true;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            User_Selection user = new User_Selection();
            user.Visible = true;
            this.Hide();
        }


        private void close_button_Click(object sender, EventArgs e)
        {
            Closing close = new Closing();
            close.Show();
            this.Hide();
        }

        private void Registration_Button_Click_1(object sender, EventArgs e)
        {
            Owner_regitration renter = new Owner_regitration();
            renter.Show();
            this.Hide();

        }

        private void LogIn_Click_1(object sender, EventArgs e)
        {
            Owner_Log_In Rin = new Owner_Log_In();
            Rin.Show();
            this.Hide();
        }
    }
}
