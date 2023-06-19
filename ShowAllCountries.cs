using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YearsProjectResch
{
    public partial class ShowAllCountries : Form
    {
        public static string query = ""; 

        public ShowAllCountries()
        {
            InitializeComponent();
        }

        private void FormCountryEditing_Load(object sender, EventArgs e)
        {
            try
            {
                //here I add my Continents to the Combobox, I do that manually without a List, since I feel like there isn't any way at the moment that the continents will change
                cbChooseContinent.Items.Add("Australia");
                cbChooseContinent.Items.Add("Europe");
                cbChooseContinent.Items.Add("South_America");
                cbChooseContinent.Items.Add("North_America");
                cbChooseContinent.Items.Add("Asia");
                cbChooseContinent.Items.Add("Africa");
            }
            catch
            {
                MessageBox.Show("Wir wissen leider nicht was falsch gelaufen ist. Bitte machen Sie das was Sie gerade gemacht haben nicht mehr!");
            }
        }

        private void cbChooseContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //I have done this in the selectedindexchanged method, because it automaticly takes the data then without clicking an button
                //here I select my Continent and with Select I can get the hole data of it, and I will give it to my Datagridview with the .DataSource command
                //I select my chosen continent with the select statement and the selected item of my Combobox
                //then I will read the data with my SqlReader and put it into my datatable 
                query = "SELECT * FROM " + cbChooseContinent.SelectedItem;
                SQL_Communication.ChoosingTable(query);
                dgvShowAllCountries.DataSource = SQL_Communication.table;
                dgvShowAllCountries.Columns[1].Frozen= true;
                SQL_Communication.conn.Close();
            }
            catch
            {
                MessageBox.Show("Wir wissen leider nicht was falsch gelaufen ist. Bitte machen Sie das was Sie gerade gemacht haben nicht mehr!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //With SqlBulk you can add, edit, delete ... data from your datagridview and it copies the items to your datatable
                //All of this is in the SQL-Communication class: truncate makes it so that I can't type the same id twice 
                //Destination Table is the table where it should add the stuff too, writetoserver means the server so in this case the table
                //because the table is the server for the bulkcopy
                string chhtable = (string)cbChooseContinent.SelectedItem;
                SQL_Communication.SaveCountries(chhtable);
            }
            catch(System.ArgumentException)
            {
                MessageBox.Show("Geben Sie etwas anderes ein, dies kann keine Sprache sein, oder haben Sie evt. zu viele Zeichen eingetippt? Wahrscheinlich haben Sie einfach zu viel Text eingegeben!");
            }
            catch
            {
                MessageBox.Show("Wir wissen leider nicht was falsch gelaufen ist. Bitte machen Sie das was Sie gerade gemacht haben nicht mehr!");
            }
        }

        private void btnBackToContinents_Click(object sender, EventArgs e)
        {
            try
            { 
                //here I can get back to my Continents
                this.Visible = false;
                ShowContinents showContinents = new ShowContinents();
                showContinents.ShowDialog();
                this.Close();  
            }
            catch
            {
                MessageBox.Show("Wir wissen leider nicht was falsch gelaufen ist. Bitte machen Sie das was Sie gerade gemacht haben nicht mehr!");
            }
        }
    }
}
