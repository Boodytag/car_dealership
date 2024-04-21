using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Vehicles
{
    public partial class Vehicles : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SHAMSLAPTOP\SQLEXPRESS;Initial Catalog=Vehicles;Integrated Security=True");
        Dictionary<string, int> typeDictionary = new Dictionary<string, int>();
        private ComboBox comboBoxColumn; // Declare comboBoxColumn here

        private List<string> columnNames = new List<string>() { "ID", "brand", "type_name", "model", "year", "color", "mileage" };
        private Dictionary<string, Type> inputTypes = new Dictionary<string, Type>()
        {
            { "ID", null },
            { "brand", typeof(TextBox) },
            { "type_name", typeof(ComboBox) },
            { "model", typeof(TextBox) },
            { "year", typeof(TextBox) },
            { "color", typeof(TextBox) },
            { "mileage", typeof(TextBox) },
        };

        public Vehicles()
        {
            InitializeComponent();
            Load += Form2_Load; // Subscribe to the Load event

            // Set the connection string
            conn.ConnectionString = @"Data Source=SHAMSLAPTOP\SQLEXPRESS;Initial Catalog=Vehicles;Integrated Security=True";

            // Add comboBoxType to the form's Controls collection
            Controls.Add(comboBoxType);

            // Load vehicle types into the combobox
            LoadVehicleTypesFromDatabase();

            // Instantiate dataGridView1
            
            dataGridView1.Name = "dataGridView1"; // Set the name if necessary
            

            // Subscribe to the CellValueChanged event
            if (dataGridView1 != null)
            {
                dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            }

            // Load data initially
            LoadData();
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData(); // Call LoadData to fill the DataGridView with data
        }

        private void LoadData()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT vd.id, vd.brand, t.type_name AS type, vd.model, vd.year, vd.color, vd.mileage FROM vehicle_details vd INNER JOIN type t ON vd.type_id = t.id", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Vehicles");
                dataGridView1.DataSource = ds.Tables["Vehicles"]; // Set the DataSource directly to the DataTable
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void LoadVehicleTypesFromDatabase()
        {
            try
            {
                // Clear existing items in comboBoxType
                comboBoxType.Items.Clear();

                // Clear existing items in typeDictionary
                typeDictionary.Clear();

                // Connect to the database and retrieve data from the type table
                using (SqlConnection connection = new SqlConnection(@"Data Source=SHAMSLAPTOP\SQLEXPRESS;Initial Catalog=Vehicles;Integrated Security=True"))
                {
                    connection.Open();
                    string query = "SELECT id, type_name FROM type";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Populate the comboBoxType with type names from the database
                    while (reader.Read())
                    {
                        int typeId = reader.GetInt32(0); // Assuming the type_id is stored as an int
                        string typeName = reader.GetString(1); // Assuming the type_name is stored as a string
                        comboBoxType.Items.Add(typeName);

                        // Add the type name and ID to the typeDictionary
                        typeDictionary.Add(typeName, typeId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading type data: " + ex.Message);
            }
        }

        private void AddDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure the connection string is initialized
                if (string.IsNullOrEmpty(conn.ConnectionString))
                {
                    conn.ConnectionString = @"Data Source=SHAMSLAPTOP\SQLEXPRESS;Initial Catalog=Vehicles;Integrated Security=True";
                }

                // Open the connection
                conn.Open();

                // Check if the ID already exists in the database
                string checkQuery = "SELECT COUNT(*) FROM vehicle_details WHERE id = @ID";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@ID", textBoxID.Text);
                    int existingCount = (int)checkCmd.ExecuteScalar();
                    if (existingCount > 0)
                    {
                        MessageBox.Show("Error: This ID already exists for another vehicle.");
                        return; // Exit the method without proceeding further
                    }
                }

                // Proceed with insertion if the ID is unique
                string insertQuery = "INSERT INTO vehicle_details (id, brand, type_id, model, year, color, mileage) VALUES (@ID, @Brand, @TypeId, @Model, @Year, @Color, @Mileage)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    // Set parameter values
                    insertCmd.Parameters.AddWithValue("@ID", textBoxID.Text);
                    insertCmd.Parameters.AddWithValue("@Brand", textBoxBrand.Text);

                    // Check if a type is selected
                    if (comboBoxType.SelectedItem != null)
                    {
                        // Retrieve the selected type ID
                        string selectedTypeName = comboBoxType.SelectedItem.ToString();

                        // Get the type ID from the dictionary
                        int typeId = typeDictionary[selectedTypeName];

                        // Set the type ID parameter
                        insertCmd.Parameters.AddWithValue("@TypeId", typeId);
                    }
                    else
                    {
                        MessageBox.Show("Error: Please select a vehicle type.");
                        return; // Exit the method without proceeding further
                    }

                    insertCmd.Parameters.AddWithValue("@Model", textBoxModel.Text);
                    insertCmd.Parameters.AddWithValue("@Year", textBoxYear.Text);
                    insertCmd.Parameters.AddWithValue("@Color", textBoxColor.Text);
                    insertCmd.Parameters.AddWithValue("@Mileage", textBoxMileage.Text);

                    // Execute the command
                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Vehicle details added successfully");

                        // Clear the entry fields
                        ResetFields();

                        // Refresh the data in dataGridView1 after adding
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add vehicle details");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding vehicle details: " + ex.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }



        private void ResetFields()
        {
            textBoxID.Text = "";
            textBoxBrand.Text = "";
            comboBoxType.SelectedIndex = -1; // Reset combobox selection
            textBoxModel.Text = "";
            textBoxYear.Text = "";
            textBoxColor.Text = "";
            textBoxMileage.Text = "";
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin form1 = new Admin();
            form1.Show();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in a valid column and row
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the clicked cell
                DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Check if the cell is not in the header row and it's editable
                if (!clickedCell.OwningColumn.ReadOnly && clickedCell is DataGridViewTextBoxCell)
                {
                    // Begin edit mode
                    dataGridView1.BeginEdit(true);
                }
            }
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null && dataGridView1.Rows.Count > 0)
            {
                // Populate the dropdown menu with vehicle IDs
                List<string> vehicleIDs = new List<string>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["ID"].Value != null)
                    {
                        vehicleIDs.Add(row.Cells["ID"].Value.ToString());
                    }
                }
                if (vehicleIDs.Count > 0)
                {
                    // Create and display a form for ID, column, new value input
                    Form prompt = new Form();
                    prompt.Width = 300;
                    prompt.Height = 200;
                    prompt.Text = "Edit Vehicle Details";
                    Label labelID = new Label() { Text = "Select Vehicle ID:", Left = 10, Top = 20, Width = 100 };
                    ComboBox comboBoxVehicleID = new ComboBox();
                    comboBoxVehicleID.DataSource = vehicleIDs;
                    comboBoxVehicleID.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxVehicleID.Location = new System.Drawing.Point(120, 20);
                    Label labelColumn = new Label() { Text = "Select Column:", Left = 10, Top = 50, Width = 100 };
                    ComboBox comboBoxColumn = new ComboBox();
                    comboBoxColumn.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxColumn.Location = new System.Drawing.Point(120, 50);
                    Label labelNewValue = new Label() { Text = "New Value:", Left = 10, Top = 80, Width = 100 };
                    Control newValueControl = null; // Declare a control variable to hold the input control
                    TextBox textBoxNewValue = new TextBox(); // Default to TextBox for other columns
                    textBoxNewValue.Location = new System.Drawing.Point(120, 80);
                    Button confirmation = new Button() { Text = "Ok", Left = 100, Width = 100, Top = 120 };
                    confirmation.Click += (sender2, e2) =>
                    {
                        string selectedVehicleID = comboBoxVehicleID.SelectedItem.ToString();
                        string selectedColumn = comboBoxColumn.SelectedItem.ToString();
                        string newValue;
                        if (newValueControl is TextBox)
                        {
                            newValue = ((TextBox)newValueControl).Text;
                        }
                        else if (newValueControl is ComboBox)
                        {
                            newValue = ((ComboBox)newValueControl).SelectedItem.ToString();
                        }
                        else
                        {
                            newValue = textBoxNewValue.Text; // Fallback to TextBox
                        }

                        // Update DataGridView and database with the new value
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["ID"].Value != null && row.Cells["ID"].Value.ToString() == selectedVehicleID)
                            {
                                try
                                {
                                    using (SqlConnection connection = new SqlConnection(@"Data Source=SHAMSLAPTOP\SQLEXPRESS;Initial Catalog=Vehicles;Integrated Security=True"))
                                    {
                                        connection.Open();
                                        string qur = $"UPDATE vehicle_details SET {selectedColumn} = @Value WHERE id = @ID";
                                        SqlCommand cmd = new SqlCommand(qur, connection);
                                        cmd.Parameters.AddWithValue("@Value", newValue);
                                        cmd.Parameters.AddWithValue("@ID", selectedVehicleID);
                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Vehicle details updated successfully");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error updating vehicle details: " + ex.Message);
                                }
                                break;
                            }
                        }
                        prompt.Close();
                    };

                    // Add columns as dropdown items
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        comboBoxColumn.Items.Add(column.HeaderText);
                    }

                    // Add controls to the form
                    prompt.Controls.Add(labelID);
                    prompt.Controls.Add(comboBoxVehicleID);
                    prompt.Controls.Add(labelColumn);
                    prompt.Controls.Add(comboBoxColumn);
                    prompt.Controls.Add(labelNewValue);

                    // Check if the selected column is "type" to create a ComboBox instead of a TextBox
                    if (comboBoxColumn.SelectedItem != null && comboBoxColumn.SelectedItem.ToString() == "type")
                    {
                        ComboBox comboBoxType = new ComboBox();
                        LoadVehicleTypesFromDatabase(); // Call without arguments
                        comboBoxType.Location = new System.Drawing.Point(120, 80);
                        newValueControl = comboBoxType; // Assign the ComboBox as the input control
                        prompt.Controls.Add(comboBoxType);

                        // Add label for "type" column indicating it's for types only
                        Label labelForTypesOnly = new Label() { Text = "For Types Only", Left = 230, Top = 83, Width = 100 };
                        prompt.Controls.Add(labelForTypesOnly);
                    }

                    else
                    {
                        textBoxNewValue.Location = new System.Drawing.Point(120, 80);
                        newValueControl = textBoxNewValue; // Assign the TextBox as the input control
                        prompt.Controls.Add(textBoxNewValue);
                    }

                    prompt.Controls.Add(confirmation);
                    prompt.ShowDialog();

                    if (dataGridView1 != null && dataGridView1.Rows.Count > 0)
                    {
                        // Your existing code for editing the data...

                        // Refresh the data in dataGridView1 after editing
                        LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("There are no vehicles to edit.");
                }
            }
            else
            {
                MessageBox.Show("There are no vehicles to edit.");
            }
        }


        // Add an event handler for cell value changes to commit changes
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if editing has stopped
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow editedRow = dataGridView1.Rows[e.RowIndex];
                string editedID = editedRow.Cells["ID"].Value.ToString();
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
                object newValue = editedRow.Cells[e.ColumnIndex].Value;

                // Update the database with the new value
                try
                {
                    using (conn)
                    {
                        conn.Open();
                        string qur = $"UPDATE vehicle_details SET {columnName} = @Value WHERE id = @ID";
                        SqlCommand cmd = new SqlCommand(qur, conn);
                        cmd.Parameters.AddWithValue("@Value", newValue);
                        cmd.Parameters.AddWithValue("@ID", editedID);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Vehicle details updated successfully");

                        // Refresh the data in dataGridView1 after updating
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating vehicle details: " + ex.Message);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Populate the dropdown menu with vehicle IDs
            List<string> vehicleIDs = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ID"].Value != null)
                {
                    vehicleIDs.Add(row.Cells["ID"].Value.ToString());
                }
            }
            if (vehicleIDs.Count > 0)
            {
                // Create and display a form for ID selection
                Form prompt = new Form();
                prompt.Width = 300;
                prompt.Height = 150;
                prompt.Text = "Delete Vehicle";
                Label labelID = new Label() { Text = "Select Vehicle ID:", Left = 10, Top = 20, Width = 100 };
                ComboBox comboBoxVehicleID = new ComboBox();
                comboBoxVehicleID.DataSource = vehicleIDs;
                comboBoxVehicleID.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxVehicleID.Location = new System.Drawing.Point(120, 20);
                Button confirmation = new Button() { Text = "Ok", Left = 100, Width = 100, Top = 80 };
                confirmation.Click += (sender2, e2) =>
                {
                    string selectedVehicleID = comboBoxVehicleID.SelectedItem.ToString();

                    // Delete the vehicle from the database
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(@"Data Source=SHAMSLAPTOP\SQLEXPRESS;Initial Catalog=Vehicles;Integrated Security=True"))
                        {
                            connection.Open();
                            string query = $"DELETE FROM vehicle_details WHERE id = @ID";
                            SqlCommand cmd = new SqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@ID", selectedVehicleID);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Vehicle deleted successfully");
                            }
                            else
                            {
                                MessageBox.Show("Vehicle with specified ID not found");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting vehicle: " + ex.Message);
                    }

                    prompt.Close();

                    // Refresh the data in dataGridView1 after deleting
                    LoadData();
                };

                // Add controls to the form
                prompt.Controls.Add(labelID);
                prompt.Controls.Add(comboBoxVehicleID);
                prompt.Controls.Add(confirmation);
                prompt.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are no vehicles to delete.");
            }
        }
    }
}