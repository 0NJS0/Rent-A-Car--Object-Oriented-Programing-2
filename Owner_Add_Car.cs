using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rental_Car
{
    public partial class Owner_Add_Car : Form
    {
        private readonly int Renter_Id;
        private string ImageFilePath;

        string connectionString = @"Data Source=NJS\SQLEXPRESS;Initial Catalog=""Rental Car"";Integrated Security=True;";
        public Owner_Add_Car()
        {
            InitializeComponent();
        }

        public Owner_Add_Car(int username)
        {
            InitializeComponent();
            Renter_Id = username;
        }

        private void Addcar_Button_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);


            try
            {
                connect.Open();

                if (IsLicenseAlreadyExists(License_Box.Text, connect))
                {
                    MessageBox.Show("License number already exists in the database.");
                    return;
                }

                using (SqlCommand command = new SqlCommand("INSERT INTO Car (Brand_name, Car_model, Car_Year, Color, Sit_Number, License_plate, Add_Date, Owner_Id, Car_Availability, Image) VALUES(@Brand_name, @Car_model, @Car_Year, @Color, @Sit_Number, @License_plate, GETDATE(), @Owner_Id, @Car_Availability, @Image)", connect))
                {
                    command.Parameters.AddWithValue("@Brand_name", Car_Brand.Text);
                    command.Parameters.AddWithValue("@Car_model", Model_Box.Text);
                    command.Parameters.AddWithValue("@Car_Year", Car_Year.Text);
                    command.Parameters.AddWithValue("@Color", Add.Text);
                    command.Parameters.AddWithValue("@Sit_Number", Sit_Number.Text);
                    command.Parameters.AddWithValue("@License_plate", License_Box.Text);
                    command.Parameters.AddWithValue("@Owner_Id", Renter_Id);
                    command.Parameters.AddWithValue("@Car_Availability", 1);

                    if (!string.IsNullOrEmpty(ImageFilePath))
                    {
                        byte[] imageData = File.ReadAllBytes(ImageFilePath);
                        command.Parameters.AddWithValue("@Image", imageData);
                    }
                    else
                    {
                        // If no image is selected, set it to null or provide a default image
                        command.Parameters.AddWithValue("@Image", DBNull.Value);
                    }


                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Car Added");

                        Owner_Form owner_Form = new Owner_Form(Renter_Id);
                        owner_Form.Show();
                        this.Close();
                    }
                    catch (Exception exa)
                    {
                        MessageBox.Show("Failed to Register in Database. Error: " + exa.Message);
                    }
                }

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to Database. Error: " + ex.Message);
            }
        }

        private bool IsLicenseAlreadyExists(string license, SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Car WHERE License_plate = @License_plate", connection))
            {
                command.Parameters.AddWithValue("@License_plate", license);
                return (int)command.ExecuteScalar() > 0;
            }
        }

        private void Clear_Button_Click_1(object sender, EventArgs e)
        {
            Model_Box.Clear();
            Car_Year.Clear();
            Car_Brand.Clear();
            Sit_Number.Clear();
            Add.Clear();
            License_Box.Clear();
        }

        private void Renter_Add_Car_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Owner_Form form = new Owner_Form(Renter_Id);
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.png;*.gif)|*.bmp;*.jpg;*.png;*.gif|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageFilePath = openFileDialog.FileName;
                ImageBox.Image = Image.FromFile(ImageFilePath);
            }
        }
    }
}