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
    public partial class Owner_regitration : Form
    {
        string connectionString = @"Data Source=NJS\SQLEXPRESS;Initial Catalog=""Rental Car"";Integrated Security=True;";
        public Owner_regitration()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Page1 homepage = new Page1();
            homepage.Visible = true;
            this.Hide();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Owner_selection rent = new Owner_selection();
            rent.Visible = true;
            this.Hide();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            try
            {
                connect.Open();

                string fullName = NameBox.Text.Trim();
                string address = AddressBox.Text.Trim();
                string phoneNumber = PhoneBox.Text.Trim();
                string email = EmailBox.Text.Trim().ToLower();
                string nid = NID_no.Text.Trim();
                string password = PassBox.Text;
                string confirmPassword = ConfirmPassBox.Text;

                // Check if any textbox is blank
                if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phoneNumber) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(nid) || string.IsNullOrEmpty(password) ||
                    string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }

                if (phoneNumber.Length == 11 && phoneNumber.All(char.IsDigit))
                {
                    

                    if (email.EndsWith("@gmail.com") || email.EndsWith("@hotmail.com") || email.EndsWith("@outlook.com"))
                    {
                        if (PassBox.Text == ConfirmPassBox.Text)
                        {
                           
                            if (IsStrongPassword(password))
                            {
                                if (IsEmailAlreadyExists(email))
                                {
                                    MessageBox.Show("Email already exists in the database. Please use a different email.");
                                    return;
                                }

                                if (IsPhoneNumberAlreadyExists(phoneNumber))
                                {
                                    MessageBox.Show("Phone number already exists in the database. Please use a different phone number.");
                                    return;
                                }

                                if (IsNIDAlreadyExists(NID_no.Text))
                                {
                                    MessageBox.Show("NID number already exists in the database. Please use a Valid NID number.");
                                    return;
                                }


                                using (SqlCommand command = new SqlCommand("INSERT INTO Owner (Full_Name, Password, Address, Email, Phone_Number, Join_Date, NID_no) VALUES(@Full_Name, @Password, @Address, @Email, @Phone_Number, GETDATE(), @NID_no)", connect))
                                {
                                    command.Parameters.AddWithValue("@Full_Name", NameBox.Text);
                                    command.Parameters.AddWithValue("@Password", password);
                                    command.Parameters.AddWithValue("@Address", AddressBox.Text);
                                    command.Parameters.AddWithValue("@Email", email);
                                    command.Parameters.AddWithValue("@Phone_Number", phoneNumber);
                                    command.Parameters.AddWithValue("@NID_no", NID_no.Text);

                                    try
                                    {
                                        command.ExecuteNonQuery();
                                        MessageBox.Show("Registration Complete");
                                        Owner_selection select = new Owner_selection();
                                        select.Show();
                                        this.Close();
                                    }
                                    catch (Exception exa)
                                    {
                                        MessageBox.Show("Failed to Register in Database. Error: " + exa.Message);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Use a Stronger Password.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password and confirmation password do not match. Please try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email address. Please use a valid email domain (@gmail.com, @hotmail.com, or @outlook.com).");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid phone number. Please enter a 11-digit phone number.");
                }

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to Database. Error: " + ex.Message);
            }

            bool IsEmailAlreadyExists(string email)
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Owner WHERE Email = @Email", connect))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    return (int)command.ExecuteScalar() > 0;
                }
            }

            bool IsPhoneNumberAlreadyExists(string phoneNumber)
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Owner WHERE Phone_Number = @Phone_Number", connect))
                {
                    command.Parameters.AddWithValue("@Phone_Number", phoneNumber);
                    return (int)command.ExecuteScalar() > 0;
                }
            }

            bool IsNIDAlreadyExists(string nid)
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Owner WHERE NID_no = @NID_no", connect))
                {
                    command.Parameters.AddWithValue("@NID_no", nid);
                    return (int)command.ExecuteScalar() > 0;
                }
            }


            bool IsStrongPassword(string password)
            {

                return password.Length >= 8 &&
                       password.Any(char.IsUpper) &&
                       password.Any(char.IsLower) &&
                       password.Any(char.IsDigit);

            }

        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            NameBox.Clear();
            PassBox.Clear();
            ConfirmPassBox.Clear();
            AddressBox.Clear();
            EmailBox.Clear();
            PhoneBox.Clear();
            NID_no.Clear();

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Closing close = new Closing();
            close.Show();
            this.Hide();
        }


    }
}
