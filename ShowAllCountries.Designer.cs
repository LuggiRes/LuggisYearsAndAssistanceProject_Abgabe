namespace YearsProjectResch
{
    partial class ShowAllCountries
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
            this.dgvShowAllCountries = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbChooseContinent = new System.Windows.Forms.ComboBox();
            this.btnBackToContinents = new System.Windows.Forms.Button();
            this.laContinents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllCountries)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowAllCountries
            // 
            this.dgvShowAllCountries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShowAllCountries.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowAllCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowAllCountries.Location = new System.Drawing.Point(24, 65);
            this.dgvShowAllCountries.Margin = new System.Windows.Forms.Padding(5);
            this.dgvShowAllCountries.Name = "dgvShowAllCountries";
            this.dgvShowAllCountries.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvShowAllCountries.Size = new System.Drawing.Size(1766, 804);
            this.dgvShowAllCountries.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.btnSave.Location = new System.Drawing.Point(582, 11);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(192, 43);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Sichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbChooseContinent
            // 
            this.cbChooseContinent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChooseContinent.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.cbChooseContinent.FormattingEnabled = true;
            this.cbChooseContinent.Location = new System.Drawing.Point(47, 11);
            this.cbChooseContinent.Margin = new System.Windows.Forms.Padding(5);
            this.cbChooseContinent.Name = "cbChooseContinent";
            this.cbChooseContinent.Size = new System.Drawing.Size(339, 27);
            this.cbChooseContinent.TabIndex = 2;
            this.cbChooseContinent.SelectedIndexChanged += new System.EventHandler(this.cbChooseContinent_SelectedIndexChanged);
            // 
            // btnBackToContinents
            // 
            this.btnBackToContinents.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.btnBackToContinents.Location = new System.Drawing.Point(1486, 14);
            this.btnBackToContinents.Margin = new System.Windows.Forms.Padding(5);
            this.btnBackToContinents.Name = "btnBackToContinents";
            this.btnBackToContinents.Size = new System.Drawing.Size(304, 41);
            this.btnBackToContinents.TabIndex = 3;
            this.btnBackToContinents.Text = "Zurück zur Kontinentübersicht";
            this.btnBackToContinents.UseVisualStyleBackColor = true;
            this.btnBackToContinents.Click += new System.EventHandler(this.btnBackToContinents_Click);
            // 
            // laContinents
            // 
            this.laContinents.AutoSize = true;
            this.laContinents.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.laContinents.Location = new System.Drawing.Point(412, 13);
            this.laContinents.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.laContinents.Name = "laContinents";
            this.laContinents.Size = new System.Drawing.Size(137, 19);
            this.laContinents.TabIndex = 4;
            this.laContinents.Text = "Kontinentauswahl";
            // 
            // ShowAllCountries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 901);
            this.Controls.Add(this.laContinents);
            this.Controls.Add(this.btnBackToContinents);
            this.Controls.Add(this.cbChooseContinent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvShowAllCountries);
            this.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ShowAllCountries";
            this.Text = "Country Editing";
            this.Load += new System.EventHandler(this.FormCountryEditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllCountries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.DataGridView dgvShowAllCountries;
        private System.Windows.Forms.ComboBox cbChooseContinent;
        private System.Windows.Forms.Button btnBackToContinents;
        private System.Windows.Forms.Label laContinents;
    }
}