using System;
using System.Windows.Forms;

namespace Vehicles
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void DisplayVehicles_Click(object sender, EventArgs e)
        {
            Vehicles form2 = new Vehicles();
            form2.Show();
            this.Hide();
        }

        private void Vehicle_types_Click(object sender, EventArgs e)
        {
            Vehicle_Types form3 = new Vehicle_Types();
            form3.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Close the form
                Application.Exit(); // End the application
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialization code when the form loads
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            Employees form4 = new Employees();
            form4.Show();
            this.Hide();
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            Customers form5 = new Customers();
            form5.Show();
            this.Hide();
        }

        private void Purchase_History_Click(object sender, EventArgs e)
        {
            Purchase_History form6 = new Purchase_History();
            form6.Show();
            this.Hide();
        }
    }
}
