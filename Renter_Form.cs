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
    public partial class Renter_Form : Form
    {
        private readonly string loggedInUsername;
        private readonly int ID;
        public Renter_Form(string username, int loggedInId)
        {
            InitializeComponent();
            this.loggedInUsername = username;
            Welcome.Text = loggedInUsername;
            ID = loggedInId;
        }

        public Renter_Form(int loggedInId)
        {
            InitializeComponent();
            ID = loggedInId;
        }

        public Renter_Form()
        {
            InitializeComponent();
        }

        private void Customer_Form_Load(object sender, EventArgs e)
        {

        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Selection select = new Selection();
            select.Visible = true;
            this.Close();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Closing close = new Closing();
            close.Show();
            this.Hide();
        }

        private void Browse_Car_Click(object sender, EventArgs e)
        {
            Renter_browse browse = new Renter_browse(ID);
            browse.Show();
            this.Close();
        }

        private void Customer_History_Click(object sender, EventArgs e)
        {
            Renter_history browse = new Renter_history(ID);
            browse.Show();
            this.Close();
        }
    }
}
