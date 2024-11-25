using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Rental_Car
{
    public partial class Owner_Form : Form
    {
        private readonly string loggedInUsername;
        private readonly int owner_Id;
        public Owner_Form(string username, int User_id)
        {
            InitializeComponent();
            this.loggedInUsername = username;
            Welcome.Text = loggedInUsername;
            this.owner_Id = User_id;
        }
        public Owner_Form( int User_id)
        {
            InitializeComponent();
            this.owner_Id = User_id;
        }
        public Owner_Form()
        {
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Closing close = new Closing();
            close.Show();
            this.Hide();
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Selection select = new Selection();
            select.Visible = true;
            this.Close();
        }

        private void Add_Car_Click(object sender, EventArgs e)
        {
            Owner_Add_Car add_Car = new Owner_Add_Car(owner_Id);
            add_Car.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Renter_Listing add_Car = new Renter_Listing(owner_Id);
            add_Car.Show();
            this.Close();
        }

        private void Renting_History_Click(object sender, EventArgs e)
        {
            Renter_Renting_History add_Car = new Renter_Renting_History(owner_Id);
            add_Car.Show();
            this.Close();
        }
    }
}
