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
    public partial class admin_invoice : Form
    {
        string connectionString = @"Data Source=NJS\SQLEXPRESS;Initial Catalog=""Rental Car"";Integrated Security=True;";
        public admin_invoice()
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
                try
                {

                    {
                        conn.Open();
                        SqlDataAdapter data = new SqlDataAdapter("Select * FROM Invoice", conn);
                        DataTable table = new DataTable();
                        data.Fill(table);

                        Invoice_Detail.DataSource = table;


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
                        for (int i = 0; i < Invoice_Detail.Columns.Count; i++)
                        {
                            writer.Write(Invoice_Detail.Columns[i].HeaderText);
                            if (i < Invoice_Detail.Columns.Count - 1)
                                writer.Write("\t \t \t");
                        }
                        writer.WriteLine();

                        // Write data
                        for (int i = 0; i < Invoice_Detail.Rows.Count; i++)
                        {
                            for (int j = 0; j < Invoice_Detail.Columns.Count; j++)
                            {
                                writer.Write(Invoice_Detail.Rows[i].Cells[j].Value);
                                if (j < Invoice_Detail.Columns.Count - 1)
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
    }
}
