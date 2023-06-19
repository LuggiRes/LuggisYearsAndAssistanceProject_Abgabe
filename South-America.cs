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

namespace YearsProjectResch
{
    public partial class South_America : Form
    {
        public South_America()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                //here I created the button click event, so it will link me to the ShowContinentInfo Forms and then select the data from the ID I selected
                //and then I add it to the Datagridview with the .DataSource command. With the select Id statement, its in my SQL-class, it will get me my ID since I need it to get
                //the right data after all. Then I create an reader which reads my data and it puts it into an DataTable which then is giving to the DataGridview
                Button b = sender as Button; //we know that it is a button, since we only assigned this method to before created buttons.
                string bTag = b.Tag.ToString();
                int Tag = Int32.Parse(bTag);
                CountryNameHelp.bTag = Tag.ToString();
                CountryNameHelp.continentname = "South_America";
                ShowContinentInfo showContinentInfo = new ShowContinentInfo();
                showContinentInfo.cbContinents.SelectedItem = "Südamerika";
                showContinentInfo.ShowDialog();
                SQL_Communication.button_Click(CountryNameHelp.continentname, Tag);
                SQL_Communication.conn.Close();
                this.Close();
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
                //here i come back to my continents
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

        private void South_America_Load(object sender, EventArgs e)
        {
            try
            {
                //Here I select the Name of the countries and make it the name of our button with help of the datareader command
                //So I just use my select statement, which is in my own SQL-class, to get infos of Australia, then I will get the name of the countries I have here and make buttons
                //from it, also I am resizing my buttons. There is always only created one button since I don't want a name twice. Also I use an datareader to get my data
                CountryNameHelp.continentname = "South_America";
                SQL_Communication.CreateCountryButtons(CountryNameHelp.continentname);
                while (SQL_Communication.dr.Read())
                {
                    for (int i = 1; i < 2; i++)
                    {
                        Button b = new Button();
                        b.Name = SQL_Communication.dr[1].ToString();
                        b.Text = b.Name;
                        b.Width = 180;
                        b.Height = 50;
                        b.Tag = SQL_Communication.dr[0].ToString();//here I use the ID of my Table and use the datareader to get it, because I need that later on
                        b.Click += button_Click;  //here I get to my button click event
                        flp_SouthAmerica.Controls.Add(b); //here I add the button to my FlowLayoutPanel which I have manually created
                    }
                }
                SQL_Communication.conn.Close();
            }
            catch
            {
                MessageBox.Show("Wir wissen leider nicht was falsch gelaufen ist. Bitte machen Sie das was Sie gerade gemacht haben nicht mehr!");
            }
        }
    }
}
