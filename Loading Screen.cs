using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Car
{
    public partial class Loading_Screen : Form
    {
        public Loading_Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(5);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Selection select = new Selection();
                select.Show();
                this.Hide();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
