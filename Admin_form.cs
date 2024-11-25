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
    public partial class Admin_form : Form
    {
        private readonly string loggedInUsername;
        public Admin_form(string username)
        {
            InitializeComponent();
            this.loggedInUsername = username;
            Welcome.Text = loggedInUsername;
        }

        public Admin_form()
        {
            InitializeComponent();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            admin_invoice invoice = new admin_invoice();
            invoice.Show();
            this.Close();
        }

        private void Renter_Details_Click(object sender, EventArgs e)
        {
            admin_Owner_details details = new admin_Owner_details();
            details.Show();
            this.Close();
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Selection select = new Selection();
            select.Visible = true;
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Closing close = new Closing();
            close.Show();
            this.Hide();
        }

        private void Car_Detail_Click(object sender, EventArgs e)
        {
            admin_car_detail detail = new admin_car_detail();
            detail.Show();
            this.Close();
        }

        private void Customer_Details_Click(object sender, EventArgs e)
        {
            admin_customer_details detail = new admin_customer_details();
            detail.Show();
            this.Close();
        }

        private void Remove_Renter_Click(object sender, EventArgs e)
        {
            Remove_Renter remove = new Remove_Renter();
            remove.Show();
            this.Close();
        }

        private void Remove_Customer_Click(object sender, EventArgs e)
        {
            Remove_Owner remove_Owner = new Remove_Owner();
            remove_Owner.Show();
            this.Close();
        }

        private void Remove_Car_Click(object sender, EventArgs e)
        {
            Remove_Car remove = new Remove_Car();
            remove.Show();
            this.Close();
        }
    }
}
