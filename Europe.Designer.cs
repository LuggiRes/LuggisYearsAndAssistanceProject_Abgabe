namespace YearsProjectResch
{
    partial class Europe
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
            this.flp_Europe = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBackToContinents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp_Europe
            // 
            this.flp_Europe.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.flp_Europe.Location = new System.Drawing.Point(14, 75);
            this.flp_Europe.Margin = new System.Windows.Forms.Padding(5);
            this.flp_Europe.Name = "flp_Europe";
            this.flp_Europe.Size = new System.Drawing.Size(1227, 523);
            this.flp_Europe.TabIndex = 2;
            // 
            // btnBackToContinents
            // 
            this.btnBackToContinents.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.btnBackToContinents.Location = new System.Drawing.Point(477, 11);
            this.btnBackToContinents.Margin = new System.Windows.Forms.Padding(5);
            this.btnBackToContinents.Name = "btnBackToContinents";
            this.btnBackToContinents.Size = new System.Drawing.Size(286, 42);
            this.btnBackToContinents.TabIndex = 3;
            this.btnBackToContinents.Text = "Zurück zur Kontinentauswahl";
            this.btnBackToContinents.UseVisualStyleBackColor = true;
            this.btnBackToContinents.Click += new System.EventHandler(this.btnBackToContinents_Click);
            // 
            // Europe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 612);
            this.Controls.Add(this.btnBackToContinents);
            this.Controls.Add(this.flp_Europe);
            this.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Europe";
            this.Text = "Europe";
            this.Load += new System.EventHandler(this.Europe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_Europe;
        private System.Windows.Forms.Button btnBackToContinents;
    }
}