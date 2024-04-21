using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Vehicles
{
    public partial class Vehicle_Types : Form
    {
        public Vehicle_Types()
        {
            InitializeComponent();
        }

        private void AddDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null; // Declare the SqlConnection variable outside the try block

            try
            {
                conn = new SqlConnection(@"Data Source=SHAMSLAPTOP\SQLEXPRESS;Initial Catalog=Vehicles;Integrated Security=True");
                conn.Open();

                // Check if the ID already exists
                string checkQuery = "SELECT COUNT(*) FROM type WHERE id = @ID";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@ID", textBoxID.Text);
                int existingCount = (int)checkCmd.ExecuteScalar();
                if (existingCount > 0)
                {
                    MessageBox.Show("Error: This ID already exists in the database.");
                    return; // Exit the method without proceeding further
                }

                // Proceed with insertion if the ID is unique
                string query = "INSERT INTO type (id, type_name) VALUES (@ID, @TypeName)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", textBoxID.Text);
                cmd.Parameters.AddWithValue("@TypeName", textBoxtype.Text); // Replace textBoxTypeName with textBoxtype
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted successfully");
                textBoxID.Text = "";
                textBoxtype.Text = "";

                // Refresh DataGridView
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding type: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close(); // Close the connection if it's open
                }
            }
        }


        private void RefreshDataGridView()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=SHAMSLAPTOP\SQLEXPRESS;Initial Catalog=Vehicles;Integrated Security=True");
                string query = "SELECT * FROM type";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Type");
                dataGridView1.DataSource = ds.Tables["Type"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


        private void Reset_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxtype.Text = "";
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            // Populate the dropdown menu with type IDs
            List<string> typeIDs = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ID"].Value != null)
                {
                    typeIDs.Add(row.Cells["ID"].Value.ToString());
                }
            }
            if (typeIDs.Count > 0)
            {
                // Create and display a form for ID, column, new value input
                Form prompt = new Form();
                prompt.Width = 300;
                prompt.Height = 200;
                prompt.Text = "Edit Type Details";
                Label labelID = new Label() { Text = "Select Type ID:", Left = 10, Top = 20, Width = 100 };
                ComboBox comboBoxTypeID = new ComboBox();
                comboBoxTypeID.DataSource = typeIDs;
                comboBoxTypeID.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxTypeID.Location = new System.Drawing.Point(120, 20);
                Label labelNewValue = new Label() { Text = "New Value:", Left = 10, Top = 80, Width = 100 };
                TextBox textBoxNewValue = new TextBox();
                textBoxNewValue.Location = new System.Drawing.Point(120, 80);
                Button confirmation = new Button() { Text = "Ok", Left = 100, Width = 100, Top = 120 };
                confirmation.Click += (sender2, e2) =>
                {
                    string selectedTypeID = comboBoxTypeID.SelectedItem.ToString();
                    string newValue = textBoxNewValue.Text;

                    // Update DataGridView and database with the new value
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(@"Data Source=SHAMSLAPTOP\SQLEXPRESS;Initial Catalog=Vehicles;Integrated Security=True"))
                        {
                            connection.Open();
                            string query = $"UPDATE [type] SET type_name = @Value WHERE id = @ID";
                            SqlCommand cmd = new SqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@Value", newValue);
                            cmd.Parameters.AddWithValue("@ID", selectedTypeID);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Type details updated successfully");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating type details: " + ex.Message);
                    }

                    prompt.Close();
                };

                // Add controls to the form
                prompt.Controls.Add(labelID);
                prompt.Controls.Add(comboBoxTypeID);
                prompt.Controls.Add(labelNewValue);
                prompt.Controls.Add(textBoxNewValue);
                prompt.Controls.Add(confirmation);
                prompt.ShowDialog();

                // Refresh the data in dataGridView1 after editing
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("There are no types to edit.");
            }
        }




        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin form1 = new Admin();
            form1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Load data into DataGridView when the form is loaded
            RefreshDataGridView();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Populate the dropdown menu with type IDs
            List<string> typeIDs = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ID"].Value != null)
                {
                    typeIDs.Add(row.Cells["ID"].Value.ToString());
                }
            }
            if (typeIDs.Count > 0)
            {
                // Create and display a form for ID selection
                Form prompt = new Form();
                prompt.Width = 300;
                prompt.Height = 150;
                prompt.Text = "Delete Type";
                Label labelID = new Label() { Text = "Select Type ID:", Left = 10, Top = 20, Width = 100 };
                ComboBox comboBoxTypeID = new ComboBox();
                comboBoxTypeID.DataSource = typeIDs;
                comboBoxTypeID.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxTypeID.Location = new System.Drawing.Point(120, 20);
                Button confirmation = new Button() { Text = "Ok", Left = 100, Width = 100, Top = 80 };
                confirmation.Click += (sender2, e2) =>
                {
                    string selectedTypeID = comboBoxTypeID.SelectedItem.ToString();

                    // Delete the type from the database
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(@"Data Source=SHAMSLAPTOP\SQLEXPRESS;Initial Catalog=Vehicles;Integrated Security=True"))
                        {
                            connection.Open();
                            string query = $"DELETE FROM [type] WHERE id = @ID";
                            SqlCommand cmd = new SqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@ID", selectedTypeID);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Type deleted successfully");
                            }
                            else
                            {
                                MessageBox.Show("Type with specified ID not found");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting type: " + ex.Message);
                    }

                    prompt.Close();

                    // Refresh the data in dataGridView1 after deleting
                    RefreshDataGridView();
                };

                // Add controls to the form
                prompt.Controls.Add(labelID);
                prompt.Controls.Add(comboBoxTypeID);
                prompt.Controls.Add(confirmation);
                prompt.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are no types to delete.");
            }
        }
    }
}
