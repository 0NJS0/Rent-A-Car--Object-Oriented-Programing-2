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
    public partial class Page1 : Form
    {
        string connectionString = @"Data Source=NJS\SQLEXPRESS;Initial Catalog=""Rental Car"";Integrated Security=True;";
        public Page1()
        {
            InitializeComponent();
        }
        public void MarkInactiveRentalsAndUpdateAvailability()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand updateInactiveCommand = new SqlCommand("UPDATE Invoice SET Active = 0 WHERE Active = 1 AND EndDate < GETDATE()", conn);
                    updateInactiveCommand.ExecuteNonQuery();

                    SqlCommand updateCarAvailabilityCommand = new SqlCommand("UPDATE Car SET Car_Availability = 1 FROM Car INNER JOIN Invoice ON Car.Car_Id = Invoice.Car_Id WHERE Invoice.Active = 0", conn);
                    updateCarAvailabilityCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error marking inactive rentals and updating car availability: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void Proceed_Click_2(object sender, EventArgs e)
        {
            MarkInactiveRentalsAndUpdateAvailability();
            Loading_Screen load = new Loading_Screen();
            load.Show();
            this.Hide();

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Closing close = new Closing();
            close.Show();
            this.Hide();
        }

    }
}
