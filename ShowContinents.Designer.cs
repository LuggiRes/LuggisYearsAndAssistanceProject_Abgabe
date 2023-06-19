namespace YearsProjectResch
{
    partial class ShowContinents
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.flp_Continents = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp_Continents
            // 
            this.flp_Continents.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.flp_Continents.Location = new System.Drawing.Point(22, 4);
            this.flp_Continents.Margin = new System.Windows.Forms.Padding(6);
            this.flp_Continents.Name = "flp_Continents";
            this.flp_Continents.Size = new System.Drawing.Size(775, 143);
            this.flp_Continents.TabIndex = 6;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.btnShowAll.Location = new System.Drawing.Point(22, 159);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(252, 50);
            this.btnShowAll.TabIndex = 8;
            this.btnShowAll.Text = "Kontinente bearbeiten";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.btnExit.Location = new System.Drawing.Point(545, 159);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(252, 50);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Programm beenden";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ShowContinents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 225);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.flp_Continents);
            this.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Italic);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ShowContinents";
            this.Text = "ShowContinents";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.FlowLayoutPanel flp_Continents;
    }
}

