using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;

namespace YearsProjectResch
{
    public partial class ShowContinentInfo : Form
    {
        public ShowContinentInfo()
        {
            InitializeComponent();
        }

        private void btnBackToCountries_Click(object sender, EventArgs e)
        {
            //here I simply just get back to the Continents and the Countries, I also just close it, because I think thats just 
            //an other way then hide it. And it was the simplier thing for me and so I just done it like that. 
            try
            {
                if (cbContinents.SelectedItem.Equals("Australien")) 
                {
                    this.Visible= false;
                    Australia australia = new Australia();
                    australia.ShowDialog();
                    this.Close();
                }
                else if (cbContinents.SelectedItem.Equals("Asien"))
                {
                    this.Visible = false;
                    Asia asia = new Asia();
                    asia.ShowDialog();
                    this.Close();
                }
                else if (cbContinents.SelectedItem.Equals("Afrika"))
                {
                    this.Visible = false;
                    Africa africa = new Africa();
                    africa.ShowDialog();
                    this.Close();
                }
                else if (cbContinents.SelectedItem.Equals("Europa"))
                {
                    this.Visible = false;
                    Europe europe = new Europe();
                    europe.ShowDialog();
                    this.Close();
                }
                else if (cbContinents.SelectedItem.Equals("Südamerika"))
                {
                    this.Visible = false;
                    South_America south_America = new South_America();
                    south_America.ShowDialog();
                    this.Close();
                }
                else if (cbContinents.SelectedItem.Equals("Nordamerika"))
                {
                    this.Visible = false;
                    North_America north_America = new North_America();
                    north_America.ShowDialog();
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Kein Objekt ausgewählt! Wählen Sie nächstes Mal etwas aus der ComboBox (Dropdown-Feld) aus.");
                }
            }
            catch (System.NullReferenceException) 
            {
                MessageBox.Show("Wählen Sie einen richtigen Kontinent aus!");
            }
            catch
            {
                MessageBox.Show("Wir wissen leider nicht was falsch gelaufen ist. Bitte machen Sie das was Sie gerade gemacht haben nicht mehr!");
            }
        }

        private void ShowContinentInfo_Load(object sender, EventArgs e)
        {
            try 
            {
                //here I load my data into my Datagridview, and for this I have to know the continentname and bTag which I have out of my other class, named
                //CountryNameHelp. And so I just can get the right infos all the time. And with .DataSource it just loads the stuff into my DGV. 
                SQL_Communication.button_Click(CountryNameHelp.continentname, Int32.Parse(CountryNameHelp.bTag));
                dgvShowData.DataSource = SQL_Communication.table;
            }
            catch
            {
                MessageBox.Show("Wir wissen leider nicht was falsch gelaufen ist. Bitte machen Sie das was Sie gerade gemacht haben nicht mehr!");
            }
        }
    }
}
