namespace Vehicles
{
    partial class Purchase_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase_History));
            this.buttonBack_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack_click
            // 
            this.buttonBack_click.Location = new System.Drawing.Point(605, 296);
            this.buttonBack_click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack_click.Name = "buttonBack_click";
            this.buttonBack_click.Size = new System.Drawing.Size(120, 62);
            this.buttonBack_click.TabIndex = 20;
            this.buttonBack_click.Text = "Back";
            this.buttonBack_click.UseVisualStyleBackColor = true;
            this.buttonBack_click.Click += new System.EventHandler(this.buttonBack_click_Click);
            // 
            // Purchase_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 654);
            this.Controls.Add(this.buttonBack_click);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Purchase_History";
            this.Text = "Purchase History";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack_click;
    }
}