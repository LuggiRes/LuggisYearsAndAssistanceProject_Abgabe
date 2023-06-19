using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace YearsProjectResch
{
    public partial class ShowContinents : Form
    {
        public ShowContinents()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            //with my if function, I just check if the database was already created or if it has to get created first.
            if (SQL_Communication.CheckForDatabase(SQL_Communication.conn, SQL_Communication.databasen))
            {
                try
                {  
                    //So if the database actualy already exists, I create some automatic buttons with the CreateContinentButtons method
                    //of my SQL-Class. So I just Read my data and then create buttons. 
                    SQL_Communication.CreateContinentButtons();
                    while (SQL_Communication.dr.Read())
                    {
                        for (int i = 1; i < 2; i++) //10 New Buttons, because I like the number 10!
                        {
                            Button b = new Button();
                            b.Width = 180;
                            b.Height = 50;
                            b.Name = SQL_Communication.dr[1].ToString();
                            b.Text = b.Name;
                            b.Tag = SQL_Communication.dr[0].ToString(); //here I use the ID of my Table and use the datareader to get it, because I need that later on
                            b.Click += Btn_Click; //here I get to my button click event
                            flp_Continents.Controls.Add(b);  //here I add the button to my FlowLayoutPanel which I have manually created
                        }
                    }
                    SQL_Communication.conn.Close();
                }
                catch
                {
                    MessageBox.Show("Wir wissen leider nicht was falsch gelaufen ist. Bitte machen Sie das was Sie gerade gemacht haben nicht mehr!");
                }
            }
            else
            {
                try
                {
                    //If the database doesn't already exist, I quickly create the database and the tables + I am creating my Continent Buttons too.
                    SQL_Communication.CreateDatabase(SQL_Communication.conn, SQL_Communication.cmmd, SQL_Communication.databasen);
                    SQL_Communication.CreateTables(SQL_Communication.conn, SQL_Communication.cmmd, SQL_Communication.databasen);

                    SQL_Communication.CreateContinentButtons();
                    while (SQL_Communication.dr.Read())
                    {
                        for (int i = 1; i < 2; i++) //10 New Buttons, because I like the number 10!
                        {
                            Button b = new Button();
                            b.Width = 150;
                            b.Height = 30;
                            b.Name = SQL_Communication.dr[1].ToString();
                            b.Text = b.Name;
                            b.Tag = SQL_Communication.dr[0].ToString(); //here I use the ID of my Table and use the datareader to get it, because I need that later on
                            b.Click += Btn_Click; //here I get to my button click event
                            flp_Continents.Controls.Add(b);  //here I add the button to my FlowLayoutPanel which I have manually created
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

        private void Btn_Click(object sender, EventArgs e)
        {
            try
            {
                //here I just look at the button the user clicked, with a switch function, and then I am linking the user to the selected Form
                Button button = (sender as Button);

                switch (button.Name)
                {
                case "Africa":
                        this.Visible = false;
                        Africa africa = new Africa();
                        africa.ShowDialog();
                        this.Close();
                        break;

                case "Australia":
                        this.Visible = false;
                        Australia australia = new Australia();
                        australia.ShowDialog();
                        this.Close();
                        break;

                case "Asia":
                        this.Visible = false;
                        Asia asia = new Asia();
                        asia.ShowDialog();
                        this.Close();
                        break;

                case "North-America":
                        this.Visible = false;
                        North_America northAmerica = new North_America();
                        northAmerica.ShowDialog();
                        this.Close();
                        break;

                case "South-America":
                        this.Visible = false;
                        South_America southAmerica = new South_America();
                        southAmerica.ShowDialog();  
                        this.Close();
                        break; 

                case "Europe":
                        this.Visible = false;
                        Europe europe = new Europe();
                        europe.ShowDialog();
                        this.Close();
                        break;
                }   
            }
            catch
            {
                MessageBox.Show("Wir wissen leider nicht was falsch gelaufen ist. Bitte machen Sie das was Sie gerade gemacht haben nicht mehr!");
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                //here I can get to my Form ShowAllCountries, which shows me the hole countries of an selected Continent
                this.Visible = false;
                ShowAllCountries showAllCountries = new ShowAllCountries();
                showAllCountries.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Wir wissen leider nicht was falsch gelaufen ist. Bitte machen Sie das was Sie gerade gemacht haben nicht mehr!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
            //normal Exit method.
            Application.Exit();
            }
            catch
            {
                MessageBox.Show("Wir wissen leider nicht was falsch gelaufen ist. Bitte machen Sie das was Sie gerade gemacht haben nicht mehr!");
            }
        }
    }
}