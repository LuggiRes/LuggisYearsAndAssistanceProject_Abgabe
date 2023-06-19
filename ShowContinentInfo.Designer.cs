namespace YearsProjectResch
{
    partial class ShowContinentInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.flpCountryInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnBackToCountries = new System.Windows.Forms.Button();
            this.cbContinents = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowData
            // 
            this.dgvShowData.AllowUserToAddRows = false;
            this.dgvShowData.AllowUserToDeleteRows = false;
            this.dgvShowData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShowData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowData.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvShowData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowData.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowData.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowData.Location = new System.Drawing.Point(12, 20);
            this.dgvShowData.Margin = new System.Windows.Forms.Padding(5);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvShowData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvShowData.Size = new System.Drawing.Size(1355, 177);
            this.dgvShowData.TabIndex = 0;
            // 
            // flpCountryInfo
            // 
            this.flpCountryInfo.Location = new System.Drawing.Point(63, 238);
            this.flpCountryInfo.Margin = new System.Windows.Forms.Padding(5);
            this.flpCountryInfo.Name = "flpCountryInfo";
            this.flpCountryInfo.Size = new System.Drawing.Size(27, 39);
            this.flpCountryInfo.TabIndex = 1;
            // 
            // btnBackToCountries
            // 
            this.btnBackToCountries.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.btnBackToCountries.Location = new System.Drawing.Point(683, 237);
            this.btnBackToCountries.Margin = new System.Windows.Forms.Padding(5);
            this.btnBackToCountries.Name = "btnBackToCountries";
            this.btnBackToCountries.Size = new System.Drawing.Size(207, 40);
            this.btnBackToCountries.TabIndex = 2;
            this.btnBackToCountries.Text = "Zurück zu den Ländern";
            this.btnBackToCountries.UseVisualStyleBackColor = true;
            this.btnBackToCountries.Click += new System.EventHandler(this.btnBackToCountries_Click);
            // 
            // cbContinents
            // 
            this.cbContinents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContinents.FormattingEnabled = true;
            this.cbContinents.Items.AddRange(new object[] {
            "Afrika",
            "Asien",
            "Australien",
            "Nordamerika",
            "Südamerika",
            "Europa"});
            this.cbContinents.Location = new System.Drawing.Point(407, 245);
            this.cbContinents.Margin = new System.Windows.Forms.Padding(2);
            this.cbContinents.Name = "cbContinents";
            this.cbContinents.Size = new System.Drawing.Size(240, 27);
            this.cbContinents.TabIndex = 3;
            // 
            // ShowContinentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 298);
            this.Controls.Add(this.cbContinents);
            this.Controls.Add(this.btnBackToCountries);
            this.Controls.Add(this.flpCountryInfo);
            this.Controls.Add(this.dgvShowData);
            this.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ShowContinentInfo";
            this.Text = "ShowContinentInfo";
            this.Load += new System.EventHandler(this.ShowContinentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvShowData;
        public System.Windows.Forms.FlowLayoutPanel flpCountryInfo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnBackToCountries;
        public System.Windows.Forms.ComboBox cbContinents;
    }
}