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
    public partial class Renter_Register : Form
    {
        string connectionString = @"Data Source=NJS\SQLEXPRESS;Initial Catalog=""Rental Car"";Integrated Security=True;";
        public Renter_Register()
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
            NameBox.Clear();
            PassBox.Clear();
            ConfirmPassBox.Clear();
            AddressBox.Clear();
            EmailBox.Clear();
            PhoneBox.Clear();
            NID_no.Clear();
            OccupationBox.Clear();
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
                string occupation = OccupationBox.Text.Trim();
                string password = PassBox.Text;
                string confirmPassword = ConfirmPassBox.Text;

                // Check if any textbox is blank
                if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phoneNumber) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(nid) || string.IsNullOrEmpty(occupation) ||
                    string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }

                if (nid.Length == 10 && nid.All(char.IsDigit))
                {


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
                                        MessageBox.Show("Driving License number already exists in the database. Please use a different NID number.");
                                        return;
                                    }


                                    using (SqlCommand command = new SqlCommand("INSERT INTO Renter (Full_Name, Password, Address, Email, Phone_Number, Join_Date, NID_no, Occupation) VALUES(@Full_Name, @Password, @Address, @Email, @Phone_Number, GETDATE(), @NID_no, @Occupation)", connect))
                                    {
                                        command.Parameters.AddWithValue("@Full_Name", NameBox.Text);
                                        command.Parameters.AddWithValue("@Password", password);
                                        command.Parameters.AddWithValue("@Address", AddressBox.Text);
                                        command.Parameters.AddWithValue("@Email", email);
                                        command.Parameters.AddWithValue("@Phone_Number", phoneNumber);
                                        command.Parameters.AddWithValue("@NID_no", NID_no.Text);
                                        command.Parameters.AddWithValue("@Occupation", OccupationBox.Text);

                                        try
                                        {
                                            command.ExecuteNonQuery();
                                            MessageBox.Show("Registration Complete");

                                            Renter_selection select = new Renter_selection();
                                            select.Show();
                                            this.Close();
                                        }
                                        catch (Exception exa)
                                        {
                                            MessageBox.Show("Failed to Register in Database. Error: ");
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please use a stronger Password.");
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
                        MessageBox.Show("Invalid phone number. Please enter an 11-digit phone number.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Driving License. Please enter an 10-digit valid Driving license.");
                }

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to Database. Error: " + ex.Message);
            }


            bool IsEmailAlreadyExists(string email)
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Renter WHERE Email = @Email", connect))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    return (int)command.ExecuteScalar() > 0;
                }
            }


            bool IsPhoneNumberAlreadyExists(string phoneNumber)
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Renter WHERE Phone_Number = @Phone_Number", connect))
                {
                    command.Parameters.AddWithValue("@Phone_Number", phoneNumber);
                    return (int)command.ExecuteScalar() > 0;
                }
            }


            bool IsNIDAlreadyExists(string nid)
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Renter WHERE NID_no = @NID_no", connect))
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

        private void close_button_Click(object sender, EventArgs e)
        {
            Closing close = new Closing();
            close.Show();
            this.Hide();
        }
    }
}

