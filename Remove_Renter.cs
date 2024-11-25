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

namespace Rental_Car
{
    public partial class Remove_Renter : Form
    {
        string connectionString = @"Data Source=NJS\SQLEXPRESS;Initial Catalog=""Rental Car"";Integrated Security=True;";
        public Remove_Renter()
        {
            InitializeComponent();

        }

        private void Remove_Renter_Load(object sender, EventArgs e)
        {

        }


        private void Customer_Detail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Customer_Detail.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM Renter WHERE Renter_Id = @Renter_Id";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Get the primary key value from the selected row
                            int customerId = Convert.ToInt32(Customer_Detail.SelectedRows[0].Cells["Renter_Id"].Value);

                            command.Parameters.AddWithValue("@Renter_Id", customerId);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Renter removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Renter_Show_Click(sender, e);
                        }

                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a Renter selecting the arrow on the left to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Renter_Show_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Renter";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        Customer_Detail.DataSource = dataTable;
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Closing close = new Closing();
            close.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}

