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

namespace FA2_project
{
    public partial class LoginForm : Form
    {
        /*IMPORTANT!!!!
            * Due to us recieving the rubrick late I already made my databases and my program works
            * so i din't make 3 tables for each type of user i just made a columb that saves what role 
            * the user plays in the program wether it be Admin, NGO or Donor*/

        private Admin_Profile AdminPage;
        private NGO_Profile NGOPage;
        private Donor_Profile DonorPage;

        public LoginForm()
        {
            InitializeComponent();
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            


            //Establish connection and filter database to find the username and password that the user specified
            /*=======================================================================================================================*/
            SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-7T1OO8Q4\SQLEXPRESS;Initial Catalog=FA2_Database;Integrated Security=True");
            connect.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Users where UserName = '" + txtUsername.Text + "' and uPassword = '" + txtPassword.Text + "';", connect);
            DataTable data = new DataTable();
            adapter.Fill(data);
            /*=======================================================================================================================*/


            if (data.Rows.Count == 1)
            {
                //Depending on what role the user plays the corresponding page will open
                /*=======================================================================================================================*/
                string Role;        
                SqlCommand cmd = new SqlCommand("Select uRole from Users where UserName = '" + txtUsername.Text + "' and uPassword = '" + txtPassword.Text + "';", connect);
                SqlDataReader Reader = cmd.ExecuteReader();
                Reader.Read();                                  //Reading the Role from database
                Role = Reader[0].ToString();
                

                if (Role == "Admin")
                {
                    var AdminPage = new Admin_Profile();
                    AdminPage.Show();                                   //Opening Admin page if user is an Admin
                    AdminPage.lblUserName.Text = txtUsername.Text;      //Store username in hidden text on page to customise page
                }
                else if(Role == "NGO")
                {
                    var NGOPage = new NGO_Profile();
                    NGOPage.Show();                                     //Opening NGO page if user is a NGO
                    NGOPage.lblUserName.Text = txtUsername.Text;        //Store username in hidden text on page to customise page
                }
                else if (Role == "Donor")
                {
                    var DonorPage = new Donor_Profile();
                    DonorPage.Show();                                   //Opening Donor page if user is a Donor
                    DonorPage.lblUserName.Text = txtUsername.Text;      //Store username in hidden text on page to customise page
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
                /*=======================================================================================================================*/
                connect.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("UserName or Password is incorrect");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Register button takes you to register page
            var newUser = new Register();
            newUser.Show();
            this.Hide();
        }
        
    }
}
