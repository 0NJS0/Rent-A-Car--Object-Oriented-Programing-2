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
    public partial class User_Selection : Form
    {
        public User_Selection()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Selection selection = new Selection();
            selection.Visible = true;
            this.Hide();
        }


        private void Renter_Button_Click(object sender, EventArgs e)
        {
            Owner_selection renter_Selection = new Owner_selection();
            renter_Selection.Show();
            this.Hide();
        }

        private void User_Button_Click(object sender, EventArgs e)
        {
            Renter_selection customer = new Renter_selection();
            customer.Show();
            this.Hide();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Closing close = new Closing();
            close.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page1 page = new Page1();
            page.Visible = true;
            this.Hide();
        }
    }
}
