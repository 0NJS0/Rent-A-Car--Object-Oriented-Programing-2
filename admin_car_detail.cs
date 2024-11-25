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
using System.IO;

namespace Rental_Car
{
    public partial class admin_car_detail : Form
    {
        string connectionString = @"Data Source=NJS\SQLEXPRESS;Initial Catalog=""Rental Car"";Integrated Security=True;";
        public admin_car_detail()
        {
            InitializeComponent();
        }

        private void Car_Show_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
                try
                {

                    {
                        conn.Open();
                        SqlDataAdapter data = new SqlDataAdapter("Select * FROM Car", conn);
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

        private void Print_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; 
            saveFileDialog.Title = "Save Data to Text File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath, false))
                    {
                        for (int i = 0; i < Car_Details.Columns.Count; i++)
                        {
                            writer.Write(Car_Details.Columns[i].HeaderText);
                            if (i < Car_Details.Columns.Count - 1)
                                writer.Write("\t");
                        }
                        writer.WriteLine();

                        // Write data
                        for (int i = 0; i < Car_Details.Rows.Count; i++)
                        {
                            for (int j = 0; j < Car_Details.Columns.Count; j++)
                            {
                                writer.Write(Car_Details.Rows[i].Cells[j].Value);
                                if (j < Car_Details.Columns.Count - 1)
                                    writer.Write("\t");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_form form = new Admin_form();
            form.Show();
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
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

        private void Car_Details_Click(object sender, EventArgs e)
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
    }
}
