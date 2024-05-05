namespace Vehicles
{
    partial class Vehicle_Cat
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
            this.buttonBack_click = new System.Windows.Forms.Button();
            this.coupe = new System.Windows.Forms.PictureBox();
            this.sedan = new System.Windows.Forms.PictureBox();
            this.hatch_bacl = new System.Windows.Forms.PictureBox();
            this.suv = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.coupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hatch_bacl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suv)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack_click
            // 
            this.buttonBack_click.Location = new System.Drawing.Point(475, 525);
            this.buttonBack_click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack_click.Name = "buttonBack_click";
            this.buttonBack_click.Size = new System.Drawing.Size(120, 62);
            this.buttonBack_click.TabIndex = 26;
            this.buttonBack_click.Text = "Back";
            this.buttonBack_click.UseVisualStyleBackColor = true;
            this.buttonBack_click.Click += new System.EventHandler(this.buttonBack_click_Click);
            // 
            // coupe
            // 
            this.coupe.Image = global::Vehicles.Properties.Resources.merc__1_;
            this.coupe.InitialImage = null;
            this.coupe.Location = new System.Drawing.Point(539, 309);
            this.coupe.Name = "coupe";
            this.coupe.Size = new System.Drawing.Size(512, 291);
            this.coupe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.coupe.TabIndex = 10;
            this.coupe.TabStop = false;
            this.coupe.Click += new System.EventHandler(this.coupe_Click);
            // 
            // sedan
            // 
            this.sedan.Image = global::Vehicles.Properties.Resources.camry__1_;
            this.sedan.InitialImage = null;
            this.sedan.Location = new System.Drawing.Point(-1, 309);
            this.sedan.Name = "sedan";
            this.sedan.Size = new System.Drawing.Size(534, 291);
            this.sedan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.sedan.TabIndex = 9;
            this.sedan.TabStop = false;
            this.sedan.Click += new System.EventHandler(this.sedan_Click);
            // 
            // hatch_bacl
            // 
            this.hatch_bacl.Image = global::Vehicles.Properties.Resources.mini__1_;
            this.hatch_bacl.InitialImage = null;
            this.hatch_bacl.Location = new System.Drawing.Point(539, 29);
            this.hatch_bacl.Name = "hatch_bacl";
            this.hatch_bacl.Size = new System.Drawing.Size(512, 274);
            this.hatch_bacl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hatch_bacl.TabIndex = 8;
            this.hatch_bacl.TabStop = false;
            this.hatch_bacl.Click += new System.EventHandler(this.hatch_bacl_Click);
            // 
            // suv
            // 
            this.suv.Image = global::Vehicles.Properties.Resources.bmwx5;
            this.suv.InitialImage = null;
            this.suv.Location = new System.Drawing.Point(-1, -4);
            this.suv.Name = "suv";
            this.suv.Size = new System.Drawing.Size(534, 307);
            this.suv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.suv.TabIndex = 7;
            this.suv.TabStop = false;
            this.suv.Click += new System.EventHandler(this.suv_Click);
            // 
            // Vehicle_Cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 598);
            this.Controls.Add(this.buttonBack_click);
            this.Controls.Add(this.coupe);
            this.Controls.Add(this.sedan);
            this.Controls.Add(this.hatch_bacl);
            this.Controls.Add(this.suv);
            this.Name = "Vehicle_Cat";
            this.Text = "Vehicle_Cat";
            ((System.ComponentModel.ISupportInitialize)(this.coupe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hatch_bacl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox coupe;
        private System.Windows.Forms.PictureBox sedan;
        private System.Windows.Forms.PictureBox hatch_bacl;
        private System.Windows.Forms.PictureBox suv;
        private System.Windows.Forms.Button buttonBack_click;
    }
}