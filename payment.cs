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
    public partial class payment : Form
    {
        private readonly int carId;
        private readonly string brandName;
        private readonly string carModel;
        private readonly int loggedInId;
        private readonly DateTime startDate;
        private readonly DateTime endDate;
        private decimal Payment;

        string connectionString = @"Data Source=NJS\SQLEXPRESS;Initial Catalog=""Rental Car"";Integrated Security=True;";
        public payment()
        {
            InitializeComponent();
        }

        public payment(int carId, string brandName, string carModel, int loggedInId, DateTime startDate, DateTime endDate, decimal payment)
        {
            InitializeComponent();
            
            this.carId=carId;
            this.brandName=brandName;
            this.carModel = carModel;
            this.loggedInId =loggedInId;
            this.startDate=startDate;
            this.endDate=endDate;
            this.Payment=payment;
            Amount.Text = Payment.ToString();

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Payment_method.Text = comboBox1.Text;
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            int active = 1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand updateAvailabilityCommand = new SqlCommand("UPDATE Car SET Car_Availability = 0 WHERE Car_Id = @Car_Id", conn);
                    updateAvailabilityCommand.Parameters.AddWithValue("@Car_Id", carId);
                    updateAvailabilityCommand.ExecuteNonQuery();

                    if (decimal.TryParse(initial_payment.Text, out decimal initial_pay))
                    {
                        decimal remain = Payment - initial_pay;


                        SqlCommand rentCommand = new SqlCommand("INSERT INTO Invoice (Invoice_Date, Car_Id, Brand_name, Car_model, Renter_Id, StartDate, EndDate, Active, Amount, Payment_method, Initial_payment,Remaining_amount) VALUES (GETDATE(), @Car_Id,@Brand_name,@Car_model, @Renter_Id,@Startdate, @End_Date, @Active, @Amount,@Payment_method, @Initial_payment,@Remaining_amount)", conn);
                        rentCommand.Parameters.AddWithValue("@Car_Id", carId);
                        rentCommand.Parameters.AddWithValue("@Brand_name", brandName);
                        rentCommand.Parameters.AddWithValue("@Car_model", carModel);
                        rentCommand.Parameters.AddWithValue("@Renter_Id", loggedInId);
                        rentCommand.Parameters.AddWithValue("@Startdate", startDate);
                        rentCommand.Parameters.AddWithValue("@End_Date", endDate);
                        rentCommand.Parameters.AddWithValue("@Active", active);
                        rentCommand.Parameters.AddWithValue("@Amount", Payment);
                        rentCommand.Parameters.AddWithValue("@Payment_method", Payment_method.Text);
                        rentCommand.Parameters.AddWithValue("@Initial_payment", initial_pay);
                        rentCommand.Parameters.AddWithValue("@Remaining_amount", remain);
                        rentCommand.ExecuteNonQuery();

                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "Text Files|*.txt";
                        saveFileDialog.Title = "Save Invoice";
                        saveFileDialog.FileName = $"Invoice_{DateTime.Now.ToString("yyyyMMddHHmmss")}.txt";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            SaveInvoice(saveFileDialog.FileName, brandName, carModel, startDate, endDate, Payment,initial_pay,remain, carId);
                            MessageBox.Show($"Invoice saved successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Invoice not saved. Rental canceled by user.");
                        }
                        MessageBox.Show($"Car rented successfully.");

                        Renter_Form rent = new Renter_Form(loggedInId);
                        rent.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid decimal value");
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            Renter_browse renter_Browse = new Renter_browse(loggedInId);
            renter_Browse.Show();
            this.Close();
        }

        private void SaveInvoice(string filePath, string brandName, string carModel, DateTime startdate, DateTime enddate, decimal payment, decimal initial, decimal remaining, int carId)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Invoice for Car Rental");
                writer.WriteLine($"Customer: {loggedInId}");
                writer.WriteLine($"Car: {brandName} {carModel}");
                writer.WriteLine($"Start Date: {startdate}");
                writer.WriteLine($"End Date: {enddate}");
                writer.WriteLine($"End Date: {enddate}");

                string ownerQuery = "SELECT Full_Name, Phone_Number FROM Owner WHERE Owner_Id = (SELECT Owner_Id FROM Car WHERE Car_Id = @Car_Id)";
                using (SqlConnection connection = new SqlConnection(connectionString))

                using (SqlCommand ownerCommand = new SqlCommand(ownerQuery, connection))
                {
                    connection.Open();

                    ownerCommand.Parameters.AddWithValue("@Car_Id", carId);

                    SqlDataReader ownerReader = ownerCommand.ExecuteReader();

                    if (ownerReader.Read())
                    {
                        string ownerName = ownerReader["Full_Name"].ToString();
                        string ownerContact = ownerReader["Phone_Number"].ToString();

                        writer.WriteLine($"Owner: {ownerName} (Contact: {ownerContact})");
                    }

                    ownerReader.Close();
                }
                writer.WriteLine($"Total Payment: {payment}TK");
                writer.WriteLine($"Initially Paid: {initial}TK");
                writer.WriteLine($"Remaining: {remaining}TK");
            }
        }
    }
}
