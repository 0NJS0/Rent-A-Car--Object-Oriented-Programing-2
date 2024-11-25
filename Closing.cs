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
    public partial class Closing : Form
    {
        public Closing()
        {
            InitializeComponent();
            timer1.Interval = 3000;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
