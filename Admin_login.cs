using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Car
{
    public partial class Admin_login : Form
    {
        string connectionString = @"Data Source=NJS\SQLEXPRESS;Initial Catalog=""Rental Car"";Integrated Security=True;";
        public Admin_login()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Selection selection = new Admin_Selection();
            selection.Visible = true;
            this.Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Page1 page = new Page1();
            page.Visible = true;
            this.Hide();
        }


        private void Login_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string email = Emailbox.Text;
                string password = PassBox.Text;

                string loggedInUsername = IsValidUser(email, password);

                if (!string.IsNullOrEmpty(loggedInUsername))
                {
                    Admin_form mainForm = new Admin_form(loggedInUsername);
                    mainForm.Show();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }

            catch (Exception exa)
            {
                MessageBox.Show("Failed to Login. Error: " + exa.Message);
            }
        }
        string IsValidUser(string email, string password)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                using (SqlCommand command = new SqlCommand("SELECT Full_Name FROM Admin WHERE Email = @Email AND Password = @Password", connect))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader["Full_Name"].ToString();
                    }
                }
            }

            return null;
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Emailbox.Clear();
            PassBox.Clear();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Closing close = new Closing();
            close.Show();
            this.Hide();
        }

    }


}
