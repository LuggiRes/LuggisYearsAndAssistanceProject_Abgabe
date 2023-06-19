namespace YearsProjectResch
{
    partial class Africa
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
            this.flp_Africa = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBackToContinents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp_Africa
            // 
            this.flp_Africa.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.flp_Africa.Location = new System.Drawing.Point(12, 68);
            this.flp_Africa.Margin = new System.Windows.Forms.Padding(5);
            this.flp_Africa.Name = "flp_Africa";
            this.flp_Africa.Size = new System.Drawing.Size(1714, 743);
            this.flp_Africa.TabIndex = 2;
            // 
            // btnBackToContinents
            // 
            this.btnBackToContinents.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.btnBackToContinents.Location = new System.Drawing.Point(773, 14);
            this.btnBackToContinents.Margin = new System.Windows.Forms.Padding(5);
            this.btnBackToContinents.Name = "btnBackToContinents";
            this.btnBackToContinents.Size = new System.Drawing.Size(253, 44);
            this.btnBackToContinents.TabIndex = 3;
            this.btnBackToContinents.Text = "Zurück zur Kontinentübersicht";
            this.btnBackToContinents.UseVisualStyleBackColor = true;
            this.btnBackToContinents.Click += new System.EventHandler(this.btnBackToContinents_Click);
            // 
            // Africa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1740, 829);
            this.Controls.Add(this.btnBackToContinents);
            this.Controls.Add(this.flp_Africa);
            this.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Africa";
            this.Text = "Africa";
            this.Load += new System.EventHandler(this.Africa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_Africa;
        private System.Windows.Forms.Button btnBackToContinents;
    }
}