using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Rental_Car
{
    public partial class Renter_browse : Form
    {
        private readonly int loggedInId;
        string connectionString = @"Data Source=NJS\SQLEXPRESS;Initial Catalog=""Rental Car"";Integrated Security=True;";
        public Renter_browse()
        {
            InitializeComponent();
        }
        public Renter_browse(int loggedinId)
        {
            InitializeComponent();
            this.loggedInId = loggedinId;

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Renter_Form form = new Renter_Form(loggedInId);
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void Car_Show_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
                try
                {

                    {
                        conn.Open();

                        string brandFilter = BrandBox.Text.Trim();
                        string modelFilter = ModelBox.Text.Trim();
                        string colorFilter = ColorBox.Text.Trim();
                        string sitNoFilter = SitBox.Text.Trim();

                        string query = "SELECT Brand_name, Car_model, Car_Year, Car_Id, Color FROM Car WHERE Car_Availability = 1";

                        if (!string.IsNullOrEmpty(brandFilter))
                        {
                            query += $" AND Brand_name LIKE '%{brandFilter}%'";
                        }

                        if (!string.IsNullOrEmpty(modelFilter))
                        {
                            query += $" AND Car_model LIKE '%{modelFilter}%'";
                        }

                        if (!string.IsNullOrEmpty(colorFilter))
                        {
                            query += $" AND Color LIKE '%{colorFilter}%'";
                        }

                        if (!string.IsNullOrEmpty(sitNoFilter))
                        {
                            query += $" AND Sit_Number LIKE '%{sitNoFilter}%'";
                        }


                        SqlDataAdapter data = new SqlDataAdapter(query, conn);
                        DataTable table = new DataTable();
                        data.Fill(table);

                        Car_Details.DataSource = table;


                    }
                    conn.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error showing data" + ex.Message);
                }
        }

        private void Rent_Car_Click(object sender, EventArgs e)
        {
            int active = 1;
            int selectedRowIndex = Car_Details.SelectedCells[0].RowIndex;
            int carId = Convert.ToInt32(Car_Details.Rows[selectedRowIndex].Cells["Car_Id"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand checkActiveRentalsCommand = new SqlCommand("SELECT COUNT(*) FROM Invoice WHERE Renter_Id = @Renter_Id AND Active = @Active", conn);
                    checkActiveRentalsCommand.Parameters.AddWithValue("@Renter_Id", loggedInId);
                    checkActiveRentalsCommand.Parameters.AddWithValue("@Active", active);

                    int activeRentalsCount = Convert.ToInt32(checkActiveRentalsCommand.ExecuteScalar());

                    if (activeRentalsCount > 0)
                    {

                        MessageBox.Show("You already have an ongoing rental. Return the current car before renting another one.");

                    }
                    else
                    {
                        SqlCommand checkAvailabilityCommand = new SqlCommand("SELECT Car_Availability, Sit_Number, Brand_name, Car_model FROM Car WHERE Car_Id = @Car_Id", conn);
                        checkAvailabilityCommand.Parameters.AddWithValue("@Car_Id", carId);



                        SqlDataReader reader = checkAvailabilityCommand.ExecuteReader();

                        if (reader.Read())
                        {
                            int carAvailability = Convert.ToInt32(reader["Car_Availability"]);
                            int sitNumber = Convert.ToInt32(reader["Sit_Number"]);
                            string brandName = reader["Brand_name"].ToString();
                            string carModel = reader["Car_model"].ToString();

                            reader.Close();

                            if (carAvailability == 1)
                            {
                                if (DateTime.TryParse(StartDate.Text, out DateTime startDate) && startDate >= DateTime.Now)
                                {
                                    if (int.TryParse(Days.Text, out int numOfDays))
                                    {
                                        decimal payment = CalculatePayment(sitNumber, numOfDays);

                                        DialogResult result = MessageBox.Show($"Total Payment Amount : {payment}TK\n\nDo you want to proceed with this rental?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                        if (result == DialogResult.Yes)
                                        {
                                            DateTime endDate = startDate.AddDays(numOfDays);

                                            payment p = new payment(carId, brandName, carModel, loggedInId, startDate, endDate, payment);
                                            p.Show();
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Rental canceled by user.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please enter a valid number of days.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please enter a valid start date in the format MM/dd/yyyy.");
                                }
                            }

                            else
                            {
                                MessageBox.Show("Car is not available for rent.");
                            }

                            

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error renting car: " + ex.Message);
                }

                finally
                {
                    conn.Close();
                }
            }

        }

        private void Car_Details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Car_Details.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        int selectedCarId = Convert.ToInt32(Car_Details.SelectedRows[0].Cells["Car_Id"].Value);

                        string query = "SELECT Image FROM Car WHERE Car_Id = @CarId";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@CarId", selectedCarId);

                            byte[] imageData = (byte[])command.ExecuteScalar();

                            if (imageData != null && imageData.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    Image carImage = Image.FromStream(ms);
                                    ImageBox.Image = carImage;
                                }
                            }

                        }

                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Showing Image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private decimal CalculatePayment(int sitNumber, int numOfDays)
        {

            decimal baseRatePerDay = 2000; 
            decimal seatRate = 400; 

            decimal basePayment = numOfDays * baseRatePerDay;
            decimal seatPayment = sitNumber * seatRate;

            decimal totalPayment = basePayment + seatPayment;

            return totalPayment;
        }

 

    }
}


