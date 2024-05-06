using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace POSSYSTEMFINAL
{
    public partial class ShoppingCart : Form
    {
        public List<Vehicle> cartItems = new List<Vehicle>();

        public ShoppingCart()
        {
            InitializeComponent();
        }

        // Method to add an item to the cart
        public void AddToCart(Vehicle vehicle)
        {
            cartItems.Add(vehicle);
            DisplayCartItems();
        }

        // Method to display cart items
        public void DisplayCartItems()
        {
            // Clear existing items
            flowLayoutPanel.Controls.Clear();

            // Display each item in the cart
            foreach (var vehicle in cartItems)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(vehicle.ImagePath);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 100;
                pictureBox.Height = 70;

                Button btnRemove = new Button();
                btnRemove.Text = "Remove";
                btnRemove.Tag = vehicle; // Store the associated vehicle object
                btnRemove.Click += BtnRemove_Click;

                Label label = new Label();
                label.Text = $"{vehicle.Make} {vehicle.Model} ({vehicle.Year}) - ${vehicle.Price}";

                // Add controls to the flow layout panel
                flowLayoutPanel.Controls.Add(pictureBox);
                flowLayoutPanel.Controls.Add(label);
                flowLayoutPanel.Controls.Add(btnRemove);
            }
        }

        // Event handler for removing an item from the cart
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Button btnRemove = (Button)sender;
            Vehicle vehicleToRemove = (Vehicle)btnRemove.Tag; // Retrieve the associated vehicle object

            // Remove the item from the cart
            cartItems.Remove(vehicleToRemove);

            // Refresh the cart display
            DisplayCartItems();
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
