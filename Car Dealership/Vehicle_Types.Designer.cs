namespace Vehicles
{
    partial class Vehicle_Types
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicle_Types));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxtype = new System.Windows.Forms.TextBox();
            this.AddDisplay = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.buttonBack_click = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(770, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 609);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(283, 143);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(291, 22);
            this.textBoxID.TabIndex = 17;
            // 
            // textBoxtype
            // 
            this.textBoxtype.Location = new System.Drawing.Point(283, 244);
            this.textBoxtype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxtype.Name = "textBoxtype";
            this.textBoxtype.Size = new System.Drawing.Size(291, 22);
            this.textBoxtype.TabIndex = 18;
            // 
            // AddDisplay
            // 
            this.AddDisplay.Location = new System.Drawing.Point(167, 373);
            this.AddDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddDisplay.Name = "AddDisplay";
            this.AddDisplay.Size = new System.Drawing.Size(120, 62);
            this.AddDisplay.TabIndex = 19;
            this.AddDisplay.Text = "Add ";
            this.AddDisplay.UseVisualStyleBackColor = true;
            this.AddDisplay.Click += new System.EventHandler(this.AddDisplay_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(324, 373);
            this.Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(120, 62);
            this.Reset.TabIndex = 20;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(492, 373);
            this.Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(120, 62);
            this.Edit.TabIndex = 21;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // buttonBack_click
            // 
            this.buttonBack_click.Location = new System.Drawing.Point(421, 496);
            this.buttonBack_click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack_click.Name = "buttonBack_click";
            this.buttonBack_click.Size = new System.Drawing.Size(120, 62);
            this.buttonBack_click.TabIndex = 22;
            this.buttonBack_click.Text = "Back";
            this.buttonBack_click.UseVisualStyleBackColor = true;
            this.buttonBack_click.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(244, 496);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(120, 62);
            this.Delete.TabIndex = 23;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Vehicle_Types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1802, 664);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.buttonBack_click);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.AddDisplay);
            this.Controls.Add(this.textBoxtype);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vehicle_Types";
            this.Text = "Vehicle Types";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxtype;
        private System.Windows.Forms.Button AddDisplay;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button buttonBack_click;
        private System.Windows.Forms.Button Delete;
    }
}
