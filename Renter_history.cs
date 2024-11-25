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
    public partial class Renter_history : Form
    {
        private readonly int loggedInId;
        string connectionString = @"Data Source=NJS\SQLEXPRESS;Initial Catalog=""Rental Car"";Integrated Security=True;";
        public Renter_history()
        {
            InitializeComponent();
        }

        public Renter_history(int loggedinId)
        {
            InitializeComponent();
            this.loggedInId = loggedinId;

        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to retrieve rental history for the current renter
                    string query = "SELECT Invoice_Id, Invoice_Date, Brand_name, Car_model, EndDate, Amount " +
                                   "FROM Invoice " +
                                   "WHERE Renter_Id = @Renter_Id " +
                                   "ORDER BY Invoice_Date DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Renter_Id", loggedInId);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        HistoryGrid.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading rental history: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; //only to save it in text file or all files
            saveFileDialog.Title = "Save Data to Text File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath, false))// false to overwrite the file if exists
                    {
                        for (int i = 0; i < HistoryGrid.Columns.Count; i++)
                        {
                            writer.Write(HistoryGrid.Columns[i].HeaderText);
                            if (i < HistoryGrid.Columns.Count - 1)
                                writer.Write("\t \t \t");
                        }
                        writer.WriteLine();

                        // Write data
                        for (int i = 0; i < HistoryGrid.Rows.Count; i++)
                        {
                            for (int j = 0; j < HistoryGrid.Columns.Count; j++)
                            {
                                writer.Write(HistoryGrid.Rows[i].Cells[j].Value);
                                if (j < HistoryGrid.Columns.Count - 1)
                                    writer.Write("\t \t");
                            }
                            writer.WriteLine();
                        }

                        MessageBox.Show("Data saved to file successfully.", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving data: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Closing close = new Closing();
            close.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Page1 page = new Page1();
            page.Visible = true;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Renter_Form form = new Renter_Form(loggedInId);
            form.Show();
            this.Close();
        }
    }
}
