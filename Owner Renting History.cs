using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Rental_Car
{
    public partial class Renter_Renting_History : Form
    {
        private readonly int loggeduserId;
        private readonly string connectionString = @"Data Source=NJS\SQLEXPRESS;Initial Catalog=Rental Car;Integrated Security=True;";
        public Renter_Renting_History()
        {
            InitializeComponent();
        }
        public Renter_Renting_History(int loggeduser)
        {
            InitializeComponent();
            loggeduserId = loggeduser;
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            string ownerQuery = "SELECT Invoice_Date, Car_Id, Brand_name, Car_model, Renter_Id, EndDate, Amount " +
                        "FROM Invoice " +
                        "WHERE Car_Id IN (SELECT Car_Id FROM Car WHERE Owner_Id = @Owner_Id)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(ownerQuery, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Owner_Id", loggeduserId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                HistoryGrid.DataSource = table;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
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
    }
}
