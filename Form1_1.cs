using Microsoft.IdentityModel.Tokens;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("server = (localdb)\\MSSQLLocalDB; integrated security = false;");
            string databasen = "AllContinents";
            SqlCommand sqlCommand = new SqlCommand("", connection);
            sqlCommand.CommandText = "CREATE DATABASE " + databasen;
            connection.ConnectionString = "server = (localdb)\\MSSQLLocalDB; integrated security = true; database = " + databasen;
            connection.Open();
            sqlCommand.ExecuteReader();
            sqlCommand.CommandText = "CREATE TABLE Continents([Id] INT NOT NULL PRIMARY KEY IDENTITY, [Name] NVARCHAR(100))";
            sqlCommand.ExecuteReader();
            sqlCommand.CommandText = "INSERT INTO Continents(Name) VALUES ('Africa')";
            sqlCommand.ExecuteReader();
            sqlCommand.CommandText = "INSERT INTO Continents(Name) VALUES ('Australia')";
            sqlCommand.ExecuteReader();
            sqlCommand.CommandText = "INSERT INTO Continents(Name) VALUES ('Asia')";
            sqlCommand.ExecuteReader();
            sqlCommand.CommandText = "INSERT INTO Continents(Name) VALUES ('North America')";
            sqlCommand.ExecuteReader();
            sqlCommand.CommandText = "INSERT INTO Continents(Name) VALUES ('South America')";
            sqlCommand.ExecuteReader();
            sqlCommand.CommandText = "INSERT INTO Continents(Name) VALUES ('Europe')";
            sqlCommand.ExecuteReader();
            connection.Close();
        }



        int index = 1;
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server = (localdb)\\MSSQLLocalDB; integrated security = false; database = 'Continents';");
            conn.Open();
            string data = "SELECT * FROM Continents";
            SqlCommand cm = new SqlCommand(data, conn);
            SqlDataReader dr = cm.ExecuteReader();
            while(dr.Read())
            {
              
                string name = $"{dr[1]}{index++}";
                Button btn = new Button() { Name = name, Text = name };
                    btn.Size = new System.Drawing.Size(100, 25);
                    btn.Location = new System.Drawing.Point(190, index * 35);
                    btn.Click += Btn_Click;
                    
                    this.Controls.Add(btn);
                //}
          
            }
            dr.Close();
            conn.Close();
        }

        private void Btn_Click(object sender, EventArgs e)
        {

           
                Button button = (sender as Button);
                //MessageBox.Show($"{button.Name} clicked.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                switch (button.Name)
                {
                case "Africa1":
                    Africa africa = new Africa();
                    africa.Show();
                    break;

                case "Australia2":
                    Australia australia = new Australia();
                    australia.Show();
                    break;

                case "Asia3":
                    Asia asia = new Asia();
                    asia.Show();
                    break;

                case "North America4":
                    NorthAmerica northAmerica = new NorthAmerica();
                    northAmerica.Show();
                    break;

                case "South America5":
                    SouthAmerica southAmerica = new SouthAmerica();
                    southAmerica.Show();
                    break; 

                case "Europe6":
                    Europe europe = new Europe();
                    europe.Show();
                    break;

                }          
        }
    }
}
#region Tries


////c# dynamic add button
//private void btnAddButton_Click(object sender, EventArgs e)
//{

//    //FlowLayoutPanel fl = new FlowLayoutPanel();
//    //fl.Name = "Myflowpanel";
//    //fl.Font = new Font("Calibri", 12);
//    //fl.FlowDirection = FlowDirection.RightToLeft;
//    //fl.Size = new Size(500, 200);

//    //fl.ForeColor = Color.BlueViolet;
//    //fl.Visible = true;
//    //fl.Controls.Add(btn);
//    ////Form form = new Form();
//}


//private void CreateButton(string buttonName)
//{

//    Color[] c = { Color.Red, Color.Teal, Color.Blue, Color.WhiteSmoke };

//    Button transbutton = new Button();
//    transbutton.BackColor = c[2];
//    transbutton.Text = buttonName;
//    transbutton.Name = buttonName + "Button";
//    transbutton.Width = 150;
//    transbutton.Height = 150;
//    transbutton.Font = new Font("Segoe UI", 13);
//    transbutton.ForeColor = Color.White;

//    transbutton.Click += new EventHandler(transbutton_Click);
//}

//private void transbutton_Click(object sender, EventArgs e)
//{


//}


//private void ButtonCreate_Click(object sender, EventArgs e)
//{
//    FlowLayoutPanel fl = new FlowLayoutPanel();
//    fl.Name = "Myflowpanel";
//    fl.Font = new Font("Calibri", 12);
//    fl.FlowDirection = FlowDirection.RightToLeft;
//    fl.Size = new Size(500, 200);
//    fl.Visible = true; 

//    ((Button)sender).Enabled = false;

//    Button buttonDynamic = new Button
//    {
//        Text = "Dynamic",
//        Visible = true,
//    };

//    buttonDynamic.Click += ButtonDynamic_Click;
//    buttonDynamic.Location = new Point(12, 12);

//    fl.Controls.Add(buttonDynamic); 
//    this.Controls.Add(buttonDynamic);
//}

//private void ButtonDynamic_Click(object sender, EventArgs e)
//{
//    MessageBox.Show("Click event handler!", "Message Box", MessageBoxButtons.OK);
//}



////object sender

//SqlConnection conn = new SqlConnection("server = (localdb)\\MSSQLLocalDB; integrated security = true; database = 'Continents';");
//conn.Open();

//FlowLayoutPanel fl = new FlowLayoutPanel();
//fl.Name = "Myflowpanel";
//fl.Font = new Font("Calibri", 12);
//fl.FlowDirection = FlowDirection.RightToLeft;
//fl.Size = new Size(500, 200);

//fl.ForeColor = Color.BlueViolet;
//fl.Visible = true;

//this.Controls.Add(fl);
//string data = "SELECT * FROM Lug";
//SqlCommand cm = new SqlCommand(data, conn);
//SqlDataReader dr = cm.ExecuteReader();
//while (dr.Read())
//{   
//    int h = 3;
//    Button[] buttonArray = new Button[8];
//    for (int i = 0; i <= h - 1; i++)
//    {
//        //string name = dr[1].ToString();
//        //string name1 = "btn" + dr[1].ToString();
//        //Button f1 = new Button ();
//        //f1.Size = new Size(200, 50);
//        //f1.Name = name1;

//        //f1.Text = name;
//        //fl.Controls.Add(f1);
//        //Form form = new Form();


//        buttonArray[i] = new Button();
//        buttonArray[i].Size = new Size(20, 43);
//        buttonArray[i].Name = "btn" + dr[1].ToString();
//        buttonArray[i].Name = "" + i + "";
//        buttonArray[i].Location = new Point(40, 20 + (i * 20));
//        if(i == 0)
//        {
//            buttonArray[i].Click += europa_click; 
//        }
//        if (i == 1)
//        {
//            buttonArray[i].Click += asia_click;
//        }
//        fl.Controls.Add(buttonArray[i]);

//    }
//}


//private void europa_click(object sender, EventArgs e)
//{
//    Console.Write("Europe");
//}
//private void asia_click(object sender, EventArgs e)
//{
//    Console.Write("Asia");
//}

//private void btnEuropeContinent_Click(object sender, EventArgs e)
//{
//    Europe europa = new Europe();
//    europa.Show(); 
//}

//string name = $"Button_{index++}";

//for(int i= 0; i < 3; i++)
//  {

//string name = Convert.ToString(dr[1]);
//}
#endregion

