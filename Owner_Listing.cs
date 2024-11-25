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
    public partial class Renter_Listing : Form
    {
        private readonly int loggeduserId;
        private readonly string connectionString = @"Data Source=NJS\SQLEXPRESS;Initial Catalog=Rental Car;Integrated Security=True;";
        public Renter_Listing()
        {
            InitializeComponent();
        }

        public Renter_Listing(int loggeduserID)
        {
            InitializeComponent();
            this.loggeduserId = loggeduserID;
        }
        private void Logout_Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    string query = "SELECT Car_Id, Brand_name, Car_model, Car_Year, Color, Sit_Number,Image " +
                                   "FROM Car " +
                                   "WHERE Owner_Id = @Owner_Id " +
                                   "ORDER BY Car_Id DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Owner_Id", loggeduserId);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        Listing.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Owner listings: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

        }

        private void Listing_Click(object sender, EventArgs e)
        {
            if (Listing.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        int selectedCarId = Convert.ToInt32(Listing.SelectedRows[0].Cells["Car_Id"].Value);

                        string query = "SELECT Image FROM Car WHERE Car_Id = @CarId";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@CarId", selectedCarId);

                            byte[] imageData = (byte[])command.ExecuteScalar();

                            if (imageData != null && imageData.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    Image carImage = System.Drawing.Image.FromStream(ms);
                                    Image.Image = carImage;
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

        private void button4_Click(object sender, EventArgs e)
        {
            Owner_Form form = new Owner_Form(loggeduserId);
            form.Show();
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
