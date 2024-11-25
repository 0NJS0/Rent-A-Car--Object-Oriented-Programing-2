using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Rental_Car
{
    public partial class Remove_Car : Form
    {
        string connectionString = @"Data Source=NJS\SQLEXPRESS;Initial Catalog=Rental Car;Integrated Security=True;";

        public Remove_Car()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Admin_form form = new Admin_form();
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

        private void Renter_Show_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM CAR";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        Car_Detail.DataSource = dataTable;
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading car data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Car_Detail.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM Car WHERE Car_Id = @Car_ID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            int carId = Convert.ToInt32(Car_Detail.SelectedRows[0].Cells["Car_Id"].Value);

                            command.Parameters.AddWithValue("@Car_ID", carId);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Car removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Reload the car data after removal
                            Renter_Show_Click(sender, e);
                        }

                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing car: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a car by clicking the arrow on the left to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Car_Detail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Car_Detail.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        int selectedCarId = Convert.ToInt32(Car_Detail.SelectedRows[0].Cells["Car_Id"].Value);

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
    }
}