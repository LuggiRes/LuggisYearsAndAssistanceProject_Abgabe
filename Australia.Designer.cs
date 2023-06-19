namespace YearsProjectResch
{
    partial class Australia
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
            this.flp_Australia = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBackToContinents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp_Australia
            // 
            this.flp_Australia.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.flp_Australia.Location = new System.Drawing.Point(31, 68);
            this.flp_Australia.Margin = new System.Windows.Forms.Padding(5);
            this.flp_Australia.Name = "flp_Australia";
            this.flp_Australia.Size = new System.Drawing.Size(1190, 208);
            this.flp_Australia.TabIndex = 1;
            // 
            // btnBackToContinents
            // 
            this.btnBackToContinents.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.btnBackToContinents.Location = new System.Drawing.Point(422, 11);
            this.btnBackToContinents.Margin = new System.Windows.Forms.Padding(5);
            this.btnBackToContinents.Name = "btnBackToContinents";
            this.btnBackToContinents.Size = new System.Drawing.Size(287, 40);
            this.btnBackToContinents.TabIndex = 4;
            this.btnBackToContinents.Text = "Zurück zur Kontinentauswahl";
            this.btnBackToContinents.UseVisualStyleBackColor = true;
            this.btnBackToContinents.Click += new System.EventHandler(this.btnBackToContinents_Click);
            // 
            // Australia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 292);
            this.Controls.Add(this.btnBackToContinents);
            this.Controls.Add(this.flp_Australia);
            this.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Australia";
            this.Text = "Australia";
            this.Load += new System.EventHandler(this.Australia_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flp_Australia;
        private System.Windows.Forms.Button btnBackToContinents;
    }
}