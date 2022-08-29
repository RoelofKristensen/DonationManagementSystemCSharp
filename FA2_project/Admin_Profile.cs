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
    public partial class Admin_Profile : Form
    {
        static SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-7T1OO8Q4\SQLEXPRESS;Initial Catalog=FA2_Database;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable data = new DataTable();
        string filename = "";
        public Admin_Profile()
        {
            InitializeComponent();
            Show();
        }

        void Show()
        {
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT ID, UserName, ContactNumer from Users WHERE uRole = 'Admin';", connect);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGdAdminList.DataSource = data;

            SqlDataAdapter statusAdpt = new SqlDataAdapter("SELECT TOP 1 Date_and_Time,RequestID,RequestersID,Document,Status from Requests WHERE Status = 'Pending';", connect);
            DataTable statusData = new DataTable();
            statusAdpt.Fill(statusData); 
            dataGdStatus.DataSource = statusData;
            
            SqlDataAdapter RqstHistoryAdpt = new SqlDataAdapter("Select Date_and_Time,RequestID,RequestersID,Document,Status from Requests;", connect);
            DataTable RqstHistoryData = new DataTable();
            RqstHistoryAdpt.Fill(RqstHistoryData);
            dataGdRequestHistory.DataSource = RqstHistoryData;


            SqlDataAdapter DonorHistoryAdpt = new SqlDataAdapter("Select R.Date_and_Time, R.RequestID, U.UserName, R.Document, R.DonorID from Requests as R INNER JOIN Users AS U ON R.RequestersID = U.ID WHERE Status = 'Approved' and Completed = 'YES';", connect);
            DataTable DonorHistoryData = new DataTable();
            DonorHistoryAdpt.Fill(DonorHistoryData);
            dataGdDonorHistory.DataSource = DonorHistoryData;
            connect.Close();

        }

        private void Admin_Profile_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 Document from Requests WHERE Status = 'Pending';", connect);
            SqlDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                filename = Reader[0].ToString();
            }
            connect.Close();
            txtDownload.Text = filename;
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {

            string RequestID="";
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-7T1OO8Q4\SQLEXPRESS;Initial Catalog=FA2_Database;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 RequestID from Requests WHERE Status = 'Pending';", connection);
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    RequestID = Reader[0].ToString();
                }
                SqlCommand Approvecmd = new SqlCommand("UPDATE Requests SET Status = 'Approved' WHERE RequestID = '" + RequestID + "';", connection);
                connection.Close();
                Approvecmd.Connection.Open();
                Approvecmd.ExecuteNonQuery();
                Approvecmd.Connection.Close();

            }
            Show();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            string RequestID = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-7T1OO8Q4\SQLEXPRESS;Initial Catalog=FA2_Database;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 RequestID from Requests WHERE Status = 'Pending';", connection);
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    RequestID = Reader[0].ToString();
                }
                SqlCommand rejectcmd = new SqlCommand("UPDATE Requests SET Status = 'Rejected' WHERE RequestID = '" + RequestID + "';", connection);
                connection.Close();
                rejectcmd.Connection.Open();
                rejectcmd.ExecuteNonQuery();
                rejectcmd.Connection.Close();
            }
            Show();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog DownloadDocument = new SaveFileDialog();
            
            
            DownloadDocument.InitialDirectory = "C://Desktop";
            DownloadDocument.Title = "Select save file location";
            DownloadDocument.FileName = "test";

            DownloadDocument.ShowDialog();

            string Locationfilename = DownloadDocument.FileName;

            connect.Close();

            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            System.IO.File.Copy(path + filename,Locationfilename + ".pdf", true);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm Loginpage = new LoginForm();
            Loginpage.Show();
            this.Close();
        }

        private void btnAddAdmin_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("heh");
            bool pass = true;
            if (txtAddName.Text.Equals(""))
            {
                MessageBox.Show("Username Required");
                pass = false;
            }

            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Users where UserName = '" + txtAddName.Text + "';", connect);
            DataTable data = new DataTable();
            adapter.Fill(data);

            if (data.Rows.Count >= 1)
            {
                MessageBox.Show("User already excists");
                pass = false;
            }

            connect.Close();


            int phoneNumber;
            if (txtAddContact.Text.Equals(""))
            {
                MessageBox.Show("Phone Number Required");
                pass = false;
            }
            if (txtAddContact.Text.Length > 10)
            {
                MessageBox.Show("Number can't be longer than 10 numbers");
                pass = false;
            }
            else if (txtAddPassword.Text.Equals(""))
            {
                MessageBox.Show("password Required");
                pass = false;
            }
            else if (txtAddCPassword.Text.Equals(""))
            {
                MessageBox.Show("Confirmation Password Required");
                pass = false;
            }
            else if (txtAddPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long");
                pass = false;
            }
            else if (txtAddCPassword.Text != txtAddPassword.Text)
            {
                MessageBox.Show("Passwords do not match");
                pass = false;
            }
            else
            {
                try
                {
                    phoneNumber = int.Parse(txtAddContact.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid Phone Number");
                    pass = false;
                }
            }
            if (pass == true)
            {
                connect.Open();
                SqlDataAdapter adapter2 = new SqlDataAdapter();
                adapter2.InsertCommand = new SqlCommand("INSERT INTO Users(uRole, UserName, ContactNumer, uPassword)" +
                    "VALUES('Admin', '" + txtAddName.Text + "', " + txtAddContact.Text + ", '" + txtAddPassword.Text + "');",
                    connect);
                adapter2.InsertCommand.ExecuteNonQuery();
                connect.Close();
                Show();
            }
        }

        private void dataGdStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
