using System;
using System.IO;
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
    public partial class NGO_Profile : Form
    {
      
        public NGO_Profile()
        {
            InitializeComponent();
            show();
        }

        static SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-7T1OO8Q4\SQLEXPRESS;Initial Catalog=FA2_Database;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable data = new DataTable();
        OpenFileDialog openFileDialog1 = new OpenFileDialog() ;
        string UserID;
        

        string filter = "Select * from Requests;";
        public void Profile_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome";

            
        }

        public void btnBrowse_Click(object sender, EventArgs e)
        {
            
                //To where your opendialog box get starting location. My initial directory location is desktop.
                openFileDialog1.InitialDirectory = "C://Desktop";
                //Your opendialog box title name.
                openFileDialog1.Title = "Select file to be uploaded.";
                //which type file format you want to upload in database. just add them.
                openFileDialog1.Filter = "Select Valid Document(*.pdf)|*.pdf;";
                //FilterIndex property represents the index of the filter currently selected in the file dialog box.
                openFileDialog1.FilterIndex = 1;
                try
                {
                    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (openFileDialog1.CheckFileExists)
                        {
                            string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                            txtFilePath.Text = path;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Upload document.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                

                if (filename == null)
                {
                    MessageBox.Show("Please select a valid document.");
                }
                else
                {

                    //we already define our connection globaly. We are just calling the object of connection.

                    connect.Open();
                    SqlCommand cmd = new SqlCommand("select ID from Users where UserName = '" + lblUserName.Text + "';", connect);
                    SqlDataReader Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        UserID = Reader[0].ToString();
                    }
                    connect.Close();


                    connect.Open();
                    SqlCommand cmd1 = new SqlCommand("insert into Requests (RequestersID , Document)values('" + UserID +"','\\PDF_Documents\\" + filename + "');", connect);
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(openFileDialog1.FileName, path + @"\PDF_Documents\" + filename);
                    cmd1.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Document uploaded.");
                    txtFilePath.Text = "";
                    show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        void show()
        {
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(filter, connect);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGdRequestHistory.DataSource = data;
            connect.Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            filter = "Select * from Requests;";
            show();
        }

        private void btnYour_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select ID from Users where UserName = '" + lblUserName.Text + "';", connect);
            SqlDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                UserID = Reader[0].ToString();
            }
            connect.Close();
            filter = "Select * from Requests where RequestersID = '" + UserID + "';";
            show();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm loginpage = new LoginForm();
            loginpage.Show();
            this.Close();
        }
    }
}
