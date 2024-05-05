using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicles
{
    public partial class Vehicle_Cat : Form
    {
        public Vehicle_Cat()
        {
            InitializeComponent();
        }

        private string Type;

        private void suv_Click(object sender, EventArgs e)
        {
            Type = "SUV";

            MessageBox.Show("Type: " + Type);
        }

        private void hatch_bacl_Click(object sender, EventArgs e)
        {
            Type = "Hatchback";

            MessageBox.Show("Type: " + Type);
        }

        private void sedan_Click(object sender, EventArgs e)
        {
            Type = "Sedan";

            MessageBox.Show("Type: " + Type);
        }

        private void coupe_Click(object sender, EventArgs e)
        {
            Type = "Coupe";

            MessageBox.Show("Type: " + Type);
        }

        private void buttonBack_click_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin form1 = new Admin();
            form1.Show();
        }
    }
}
