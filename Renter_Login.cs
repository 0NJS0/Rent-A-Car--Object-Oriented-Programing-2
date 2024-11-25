using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Car
{
    public partial class Renter_Login : Form
    {
        string connectionString = @"Data Source=NJS\SQLEXPRESS;Initial Catalog=""Rental Car"";Integrated Security=True;";
        public Renter_Login()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Renter_selection selection = new Renter_selection();
            selection.Visible = true;
            this.Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Page1 page = new Page1();
            page.Visible = true;
            this.Hide();
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Emailbox.Clear();
            PassBox.Clear();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string email = Emailbox.Text;
                string password = PassBox.Text;

                Tuple<string, int> loggedInUser = IsValidUser(email, password);

                if (loggedInUser != null)
                {
                    string fullName = loggedInUser.Item1;
                    int customerID = loggedInUser.Item2;
                    Renter_Form form = new Renter_Form(fullName, customerID);
                    form.Show();
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
        Tuple<string, int> IsValidUser(string email, string password)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                using (SqlCommand command = new SqlCommand("SELECT Full_Name, Renter_Id FROM Renter WHERE Email = @Email AND Password = @Password", connect))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string fullName = reader["Full_Name"].ToString();
                        int renterID = Convert.ToInt32(reader["Renter_Id"]);

                        return Tuple.Create(fullName, renterID);
                    }
                }
            }
            return null;
        }



        private void close_button_Click(object sender, EventArgs e)
        {
            Closing close = new Closing();
            close.Show();
            this.Hide();

        }
    }
}
