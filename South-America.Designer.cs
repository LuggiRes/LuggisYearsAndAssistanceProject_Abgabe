namespace YearsProjectResch
{
    partial class South_America
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
            this.flp_SouthAmerica = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBackToContinents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp_SouthAmerica
            // 
            this.flp_SouthAmerica.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.flp_SouthAmerica.Location = new System.Drawing.Point(3, 58);
            this.flp_SouthAmerica.Margin = new System.Windows.Forms.Padding(5);
            this.flp_SouthAmerica.Name = "flp_SouthAmerica";
            this.flp_SouthAmerica.Size = new System.Drawing.Size(1182, 201);
            this.flp_SouthAmerica.TabIndex = 2;
            // 
            // btnBackToContinents
            // 
            this.btnBackToContinents.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.btnBackToContinents.Location = new System.Drawing.Point(505, 18);
            this.btnBackToContinents.Margin = new System.Windows.Forms.Padding(5);
            this.btnBackToContinents.Name = "btnBackToContinents";
            this.btnBackToContinents.Size = new System.Drawing.Size(229, 30);
            this.btnBackToContinents.TabIndex = 3;
            this.btnBackToContinents.Text = "Zurück zur Kontinentauswahl";
            this.btnBackToContinents.UseVisualStyleBackColor = true;
            this.btnBackToContinents.Click += new System.EventHandler(this.btnBackToContinents_Click);
            // 
            // South_America
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 283);
            this.Controls.Add(this.btnBackToContinents);
            this.Controls.Add(this.flp_SouthAmerica);
            this.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "South_America";
            this.Text = "South-America";
            this.Load += new System.EventHandler(this.South_America_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_SouthAmerica;
        private System.Windows.Forms.Button btnBackToContinents;
    }
}