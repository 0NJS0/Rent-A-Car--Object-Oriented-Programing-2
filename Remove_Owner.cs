using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rental_Car
{
    public partial class Remove_Owner : Form

    {
        string connectionString = @"Data Source=NJS\SQLEXPRESS;Initial Catalog=""Rental Car"";Integrated Security=True;";
        public Remove_Owner()
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

                    string query = "SELECT * FROM Owner";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        Owner_Detail.DataSource = dataTable;
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Owner_Detail.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM Owner WHERE Owner_Id = @Owner_Id";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Get the primary key value from the selected row
                            int customerId = Convert.ToInt32(Owner_Detail.SelectedRows[0].Cells["Owner_Id"].Value);

                            command.Parameters.AddWithValue("@Owner_Id", customerId);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Owner removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Please select a owner selecting the arrow on the left to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Remove_Owner_Load(object sender, EventArgs e)
        {

        }
    }
}

