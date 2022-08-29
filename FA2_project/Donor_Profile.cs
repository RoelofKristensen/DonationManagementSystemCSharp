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
    public partial class Donor_Profile : Form
    {
        //Establishing connection and creating global vairables
        /*=======================================================================================================================*/
        static SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-7T1OO8Q4\SQLEXPRESS;Initial Catalog=FA2_Database;Integrated Security=True");
        int RequestID;
        string filename;
        /*=======================================================================================================================*/
        public Donor_Profile()
        {
            InitializeComponent();
            Show();
        }

        //Show function to display all nessassary data in data grid views
        /*=======================================================================================================================*/
        void Show()
        {

            connect.Open();
            SqlDataAdapter Rqstadpt = new SqlDataAdapter("Select R.Date_and_Time,R.RequestID,U.UserName,R.Document from Requests as R INNER JOIN Users AS U ON R.RequestersID = U.ID WHERE Status = 'Approved' and Completed = 'NO';", connect);
            DataTable Rqstdata = new DataTable();
            Rqstadpt.Fill(Rqstdata);                                //datagrid is for donar to see all available requests to donate to
            dataGdRqstDonations.DataSource = Rqstdata;

            SqlDataAdapter Donationadpt = new SqlDataAdapter("Select R.Date_and_Time, R.RequestID, U.UserName, R.Document, R.DonorID from Requests as R INNER JOIN Users AS U ON R.RequestersID = U.ID WHERE Status = 'Approved' and Completed = 'YES';", connect);
            DataTable Donationdata = new DataTable();
            Donationadpt.Fill(Donationdata);                        //datagrid if donation history
            dataGdDonationHistory.DataSource = Donationdata;

            connect.Close();
        }
        /*=======================================================================================================================*/

        private void btnDonate_Click(object sender, EventArgs e)
        {
            //when btn is clicked the donation gets changed to complete and the Donor's ID gets saved
            /*=======================================================================================================================*/
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-7T1OO8Q4\SQLEXPRESS;Initial Catalog=FA2_Database;Integrated Security=True"))
                {
                    int DonorID;
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 ID from Users WHERE UserName = '" + lblUserName.Text + "';", connection);
                    SqlDataReader Reader = cmd.ExecuteReader();
                    Reader.Read(); 
                   
                    DonorID = int.Parse(Reader[0].ToString());      //getting Donor ID in order to save it to the data base
                    
                    SqlCommand rejectcmd = new SqlCommand("UPDATE Requests SET Completed = 'YES', DonorID = '" + DonorID + "'WHERE RequestID = '" + RequestID + "';", connection);
                    connection.Close();
                    rejectcmd.Connection.Open();
                    rejectcmd.ExecuteNonQuery();            //saving donor to the database
                    rejectcmd.Connection.Close();
                    txtSelectedFile.Text = "";              //clearing text from textbox after btn ic clicked
                    txtSelectedFile.Text = "";              //clearing text from textbox after btn ic clicked
                }
                /*=======================================================================================================================*/
                Show();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void dataGdRqstDonations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //code that executes when users select a requests they wish to see
            /*=======================================================================================================================*/
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGdRqstDonations.Rows[e.RowIndex];
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));  //getting the file path to where the 

                txtSelectedUser.Text = row.Cells["UserName"].Value.ToString();          //displaying username to textbox
                txtSelectedFile.Text = path + row.Cells["Document"].Value.ToString();   //diplaying Document's file path
                RequestID = int.Parse(row.Cells["RequestID"].Value.ToString());         //storing username to global vairable
                filename = row.Cells["Document"].Value.ToString();                      //storing file path to global vairable
            }
            /*=======================================================================================================================*/
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            //Opening a SaveFile Dialog in order to save a file to a specified 
            /*=======================================================================================================================*/
            try
            {
                SaveFileDialog DownloadDocument = new SaveFileDialog();


                DownloadDocument.InitialDirectory = "C://Desktop";          //Default directory to start in
                DownloadDocument.Title = "Select save file location";       //Message that is going to display in the title
                DownloadDocument.FileName = "test";                         //defualt file name

                DownloadDocument.ShowDialog();
                string Locationfilename = DownloadDocument.FileName;        //getting file path to selected save destination
                connect.Close();

                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));  //Filepath to where document is currently stored

                System.IO.File.Copy(path + filename, Locationfilename + ".pdf", true);  //"Downloading" actually just coping file from where it is saved to where you 
            }
            catch
            {
                MessageBox.Show("Something Went Wrong");
            }
            /*=======================================================================================================================*/
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Back opens Login form 
            /*=======================================================================================================================*/
            LoginForm loginpage = new LoginForm();
            loginpage.Show();
            this.Close();
            /*=======================================================================================================================*/
        }
    }
}
