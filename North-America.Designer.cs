namespace YearsProjectResch
{
    partial class North_America
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
            this.flp_NorthAmerica = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBackToContinents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp_NorthAmerica
            // 
            this.flp_NorthAmerica.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.flp_NorthAmerica.Location = new System.Drawing.Point(14, 78);
            this.flp_NorthAmerica.Margin = new System.Windows.Forms.Padding(5);
            this.flp_NorthAmerica.Name = "flp_NorthAmerica";
            this.flp_NorthAmerica.Size = new System.Drawing.Size(1227, 380);
            this.flp_NorthAmerica.TabIndex = 2;
            // 
            // btnBackToContinents
            // 
            this.btnBackToContinents.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.btnBackToContinents.Location = new System.Drawing.Point(454, 14);
            this.btnBackToContinents.Margin = new System.Windows.Forms.Padding(5);
            this.btnBackToContinents.Name = "btnBackToContinents";
            this.btnBackToContinents.Size = new System.Drawing.Size(238, 43);
            this.btnBackToContinents.TabIndex = 3;
            this.btnBackToContinents.Text = "Zurück zur Kontinentübersicht";
            this.btnBackToContinents.UseVisualStyleBackColor = true;
            this.btnBackToContinents.Click += new System.EventHandler(this.btnBackToContinents_Click);
            // 
            // North_America
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 494);
            this.Controls.Add(this.btnBackToContinents);
            this.Controls.Add(this.flp_NorthAmerica);
            this.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "North_America";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "North-America";
            this.Load += new System.EventHandler(this.North_America_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_NorthAmerica;
        private System.Windows.Forms.Button btnBackToContinents;
    }
}