using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicalIntrumentStoreManagementProject

{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=localhost\sqlexpress;Integrated Security=True";

            string sql = "select * from users where name = '" + this.textBox1.Text + "' and password = '" + this.textBox2.Text + "';";
            SqlConnection sqlcon = new SqlConnection(connection);
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            if (ds.Tables[0].Rows.Count == 1)
            {
                
                this.Hide();
                MessageBox.Show("Login Valid");
                string uid = ds.Tables[0].Rows[0][0].ToString();
                string name = ds.Tables[0].Rows[0][1].ToString();

                if (ds.Tables[0].Rows[0][6].ToString() == "Admin")
                {
                    Admin admin = new Admin();
                    admin.Show();
                }
                else if (ds.Tables[0].Rows[0][6].ToString() == "Seller")
                {
                    Seller member = new Seller(uid, name);
                    member.Show();
                }

            }
            else
            {
                MessageBox.Show("Login Invalid");
                this.textBox1.Clear();
                this.textBox2.Clear();
            }

            sqlcon.Close();

            //
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
                panel1.Invalidate();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
         
        }

        private void Login_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
