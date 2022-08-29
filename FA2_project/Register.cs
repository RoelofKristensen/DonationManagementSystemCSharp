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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-7T1OO8Q4\SQLEXPRESS;
            Initial Catalog=FA2_Database;Integrated Security=True");        //Establish connection globally


        private void btnRegister_Click(object sender, EventArgs e)
        {
            //User name Validation
            /*=======================================================================================================================*/
            bool pass = true;
            if (txtUsername.Text.Equals(""))
            {
                MessageBox.Show("Username Required");               //print if field is empty
                pass = false;
            }

            
            connect.Open();
            SqlDataAdapter adapter1 = new SqlDataAdapter("Select * from Users where UserName = '"+txtUsername.Text+"';",connect);
            DataTable data = new DataTable();
            adapter1.Fill(data);

            if (data.Rows.Count >= 1)
            {
                MessageBox.Show("User already excists");            //User already excists
                pass = false;
            }
            connect.Close();

            /*=======================================================================================================================*/

            //Phone number validation
            /*=======================================================================================================================*/
            int phoneNumber;
            if (txtPhoneNumber.Text.Equals(""))
            {
                MessageBox.Show("Phone Number Required");           //print if field is empty
                pass = false;
            }
            if(txtPhoneNumber.Text.Length > 10)
            {
                MessageBox.Show("Number can't be longer than 10 numbers");
                pass = false;
            }
            else
            {
                try
                {
                    phoneNumber = int.Parse(txtPhoneNumber.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid Phone Number");
                    pass = false;
                }
            }
            /*=======================================================================================================================*/

            //role validation
            /*=======================================================================================================================*/
            if (lbxRole.Text.Equals(""))
            {
                MessageBox.Show("Role Required");                   //print if field is empty
                pass = false;
            }
            /*=======================================================================================================================*/

            //password validation
            /*=======================================================================================================================*/
            if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("password Required");               //print if field is empty
                pass = false;
            }
            if (txtCPassword.Text.Equals(""))
            {
                MessageBox.Show("Confirmation Password Required");  //print if field is empty
                pass = false;
            }
            if(txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long"); //password length >8
                pass = false;
            }

            if(txtCPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Passwords do not match");          //Password != CPassword
                pass = false;
            }
            /*=======================================================================================================================*/

            //Save info to database if all criterias passed
            /*=======================================================================================================================*/
            if (pass==true)
            {
                connect.Open();
                SqlDataAdapter adapter2 = new SqlDataAdapter();
                adapter2.InsertCommand = new SqlCommand("INSERT INTO Users(uRole, UserName, ContactNumer, uPassword)" +
                    "VALUES('"+ lbxRole.Text + "', '"+ txtUsername.Text + "', "+ txtPhoneNumber.Text + ", '"+ txtPassword.Text + "');",
                    connect);

                adapter2.InsertCommand.ExecuteNonQuery();
                connect.Close();
                new LoginForm().Show();
                this.Close();
  
            }
            /*=======================================================================================================================*/
        }

        //Cancel button closes window and opens login
        /*=======================================================================================================================*/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close(); 
        }
        /*=======================================================================================================================*/
    }



}
