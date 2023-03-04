using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MusicalIntrumentStoreManagementProject
{
   
    public partial class Profile : Form
    {


        private static string currentUid;
        private static string currentName;
        private static string currentPhone;
        private static string currentEmail;
        private static string currentPass;
        public Profile(string uid, string name)
        {
            currentUid = uid;
            currentName = name;
            InitializeComponent();
            usr.Text = "Hello, " + currentName;

            loadProfileData();
        }

        private void loadProfileData()
        {
            try
            {

                string connection = @"Data Source=localhost\sqlexpress;Integrated Security=True";

                SqlConnection cn = new SqlConnection(connection);
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE id = @uid", cn);
                cmd.Parameters.Add(new SqlParameter("uid", currentUid));
                SqlDataReader dr = cmd.ExecuteReader();
                try
                {
                    dr.Read();
                    string name = dr["name"].ToString();
                    string uid = dr["id"].ToString();
                    if (dr["id"].ToString().Trim() == currentUid)
                    {
                        usrId.Text = dr["id"].ToString().Trim();
                        usrName.Text = dr["name"].ToString().Trim();
                        usrPhn.Text = dr["phone_number"].ToString().Trim();
                        usrPass.Text = dr["password"].ToString().Trim();
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Username or Password");
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Database Connection Failed!");
            }
        }


        private void usr_TextChanged(object sender, EventArgs e)
        {

        }

        private void okPass_Click(object sender, EventArgs e)
        {
            string changedPassword = chngUsrPass.Text.ToString().Trim();
            if(string.IsNullOrEmpty(changedPassword)) {
                MessageBox.Show("Password can not be empty");
            } else
            {
                try
                {
                    string connection = @"Data Source=localhost\sqlexpress;Integrated Security=True";
                    SqlConnection cn = new SqlConnection(connection);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE users SET password = @newPass Where id = @uid", cn);
                    cmd.Parameters.Add(new SqlParameter("newPass", changedPassword));
                    cmd.Parameters.Add(new SqlParameter("uid", currentUid));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cn.Close();
                    MessageBox.Show("Password changed successfully!!");
                    loadProfileData();
                    chngUsrPass.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Database Connection Failed!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Seller ad = new Seller(currentUid, currentName);
            //Seller ad = new Seller();
            ad.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usrId_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
