namespace Vehicles
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.DisplayVehicles = new System.Windows.Forms.Button();
            this.Vehicle_types = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Employees = new System.Windows.Forms.Button();
            this.Customers = new System.Windows.Forms.Button();
            this.Purchase_History = new System.Windows.Forms.Button();
            this.brand_types = new System.Windows.Forms.Button();
            this.vehicle_cat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayVehicles
            // 
            this.DisplayVehicles.Location = new System.Drawing.Point(43, 35);
            this.DisplayVehicles.Name = "DisplayVehicles";
            this.DisplayVehicles.Size = new System.Drawing.Size(121, 55);
            this.DisplayVehicles.TabIndex = 0;
            this.DisplayVehicles.Text = "Vehicles";
            this.DisplayVehicles.UseVisualStyleBackColor = true;
            this.DisplayVehicles.Click += new System.EventHandler(this.DisplayVehicles_Click);
            // 
            // Vehicle_types
            // 
            this.Vehicle_types.Location = new System.Drawing.Point(227, 35);
            this.Vehicle_types.Name = "Vehicle_types";
            this.Vehicle_types.Size = new System.Drawing.Size(121, 55);
            this.Vehicle_types.TabIndex = 1;
            this.Vehicle_types.Text = "Vehicle Types";
            this.Vehicle_types.UseVisualStyleBackColor = true;
            this.Vehicle_types.Click += new System.EventHandler(this.Vehicle_types_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(667, 383);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(121, 55);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Employees
            // 
            this.Employees.Location = new System.Drawing.Point(421, 35);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(121, 55);
            this.Employees.TabIndex = 3;
            this.Employees.Text = "Employees";
            this.Employees.UseVisualStyleBackColor = true;
            this.Employees.Click += new System.EventHandler(this.Employees_Click);
            // 
            // Customers
            // 
            this.Customers.Location = new System.Drawing.Point(604, 35);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(121, 55);
            this.Customers.TabIndex = 4;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            this.Customers.Click += new System.EventHandler(this.Customers_Click);
            // 
            // Purchase_History
            // 
            this.Purchase_History.Location = new System.Drawing.Point(43, 155);
            this.Purchase_History.Name = "Purchase_History";
            this.Purchase_History.Size = new System.Drawing.Size(121, 55);
            this.Purchase_History.TabIndex = 5;
            this.Purchase_History.Text = "Purchase History";
            this.Purchase_History.UseVisualStyleBackColor = true;
            this.Purchase_History.Click += new System.EventHandler(this.Purchase_History_Click);
            // 
            // brand_types
            // 
            this.brand_types.Location = new System.Drawing.Point(227, 155);
            this.brand_types.Name = "brand_types";
            this.brand_types.Size = new System.Drawing.Size(121, 55);
            this.brand_types.TabIndex = 6;
            this.brand_types.Text = "Brand Types";
            this.brand_types.UseVisualStyleBackColor = true;
            this.brand_types.Click += new System.EventHandler(this.brand_types_Click);
            // 
            // vehicle_cat
            // 
            this.vehicle_cat.Location = new System.Drawing.Point(421, 155);
            this.vehicle_cat.Name = "vehicle_cat";
            this.vehicle_cat.Size = new System.Drawing.Size(121, 55);
            this.vehicle_cat.TabIndex = 7;
            this.vehicle_cat.Text = "Vehicle Categories";
            this.vehicle_cat.UseVisualStyleBackColor = true;
            this.vehicle_cat.Click += new System.EventHandler(this.vehicle_cat_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vehicle_cat);
            this.Controls.Add(this.brand_types);
            this.Controls.Add(this.Purchase_History);
            this.Controls.Add(this.Customers);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Vehicle_types);
            this.Controls.Add(this.DisplayVehicles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DisplayVehicles;
        private System.Windows.Forms.Button Vehicle_types;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Employees;
        private System.Windows.Forms.Button Customers;
        private System.Windows.Forms.Button Purchase_History;
        private System.Windows.Forms.Button brand_types;
        private System.Windows.Forms.Button vehicle_cat;
    }
}

