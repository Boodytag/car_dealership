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
    public partial class Brand_Types : Form
    {
        public Brand_Types()
        {
            InitializeComponent();
        }

        private string Brand;

        private void bmw_Click(object sender, EventArgs e)
        {
            Brand = "BMW";

            MessageBox.Show("Brand: " + Brand);
        }

        private void Mercedes_Click(object sender, EventArgs e)
        {
            Brand = "Mercedes";

            MessageBox.Show("Brand: " + Brand);
        }

        private void audi_Click(object sender, EventArgs e)
        {
            Brand = "Audi";

            MessageBox.Show("Brand: " + Brand);
        }

        private void porsche_Click(object sender, EventArgs e)
        {
            Brand = "Porsche";

            MessageBox.Show("Brand: " + Brand);
        }

        private void chevy_Click(object sender, EventArgs e)
        {
            Brand = "Chevrolet";

            MessageBox.Show("Brand: " + Brand);
        }

        private void toyota_Click(object sender, EventArgs e)
        {
            Brand = "Toyota";

            MessageBox.Show("Brand: " + Brand);
        }

        private void honda_Click(object sender, EventArgs e)
        {
            Brand = "Honda";

            MessageBox.Show("Brand: " + Brand);
        }

        private void hayundai_Click(object sender, EventArgs e)
        {
            Brand = "Hayundai";

            MessageBox.Show("Brand: " + Brand);
        }

        private void volks_Click(object sender, EventArgs e)
        {
            Brand = "Volksvagen";

            MessageBox.Show("Brand: " + Brand);
        }

        private void opel_Click(object sender, EventArgs e)
        {
            Brand = "Opel";

            MessageBox.Show("Brand: " + Brand);
        }

        private void jeep_Click(object sender, EventArgs e)
        {
            Brand = "Jeep";

            MessageBox.Show("Brand: " + Brand);
        }

        private void renault_Click(object sender, EventArgs e)
        {
            Brand = "Renault";

            MessageBox.Show("Brand: " + Brand);
        }

        private void buttonBack_click_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin form1 = new Admin();
            form1.Show();
        }
    }
}
