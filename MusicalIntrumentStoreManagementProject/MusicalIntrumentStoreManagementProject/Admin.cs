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

namespace MusicalIntrumentStoreManagementProject
{
    public partial class Admin : Form
    {
        private static string adUid;
        private static string adName;
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=localhost\sqlexpress;Integrated Security=True");
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtInstname.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "" )
            {
                MessageBox.Show("Complete All The Fields");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into InstTable1 values('" + txtInstname.Text + "','" + cmboBrand.SelectedItem.ToString() + "','" + cmboStatus.SelectedItem.ToString() + "','" + txtQuantity.Text + "','" + txtPrice.Text + "','" + cmboCategory.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                    MessageBox.Show("Instrument Added Successfully");
                        Con.Close();
                    populate();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
       
        private void populate()
        {
            Con.Open();
            String query = "select * from InstTable1";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            AdminDGV.DataSource = ds.Tables[0];
            Con.Close();
             
        }
        private void filterBrand()
        {
            Con.Open();
            String query = "select * from InstTable1 where InstBrand='"+cmboFilterbrand.SelectedItem.ToString()+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            AdminDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void filterCategory()
        {
            Con.Open();
            String query = "select * from InstTable1 where InstCategory='" + cmboFiltercategory.SelectedItem.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            AdminDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void searchInstrument()
        {
            Con.Open();
            String query = "select * from InstTable1 where InstName='" + txtSearch.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            AdminDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int InstKey;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtInstname.Text ==  "")
            {
                MessageBox.Show("Select The Instrument To Delete");
            }
            else
            {
                
                try
                {
                    Con.Open();
                    String query = "delete from InstTable1 where InstId="+InstKey+"";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Instrument Deleted");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void AdminDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InstKey = Convert.ToInt32(AdminDGV.SelectedRows[0].Cells[0].Value.ToString());
            txtInstname.Text = AdminDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtQuantity.Text = AdminDGV.SelectedRows[0].Cells[4].Value.ToString();
            txtPrice.Text = AdminDGV.SelectedRows[0].Cells[5].Value.ToString();
            cmboBrand.SelectedItem = AdminDGV.SelectedRows[0].Cells[2].Value.ToString();     
            cmboCategory.SelectedItem = AdminDGV.SelectedRows[0].Cells[6].Value.ToString();
            cmboStatus.SelectedItem = AdminDGV.SelectedRows[0].Cells[3].Value.ToString();   

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtInstname.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Missing Imformation");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update InstTable1 set InstName='" + txtInstname.Text + "',InstBrand='" + cmboBrand.SelectedItem.ToString() + "',InstStatus='" + cmboStatus.SelectedItem.ToString() + "',InstQuantity='" + txtQuantity.Text + "',InstPrice='" + txtPrice.Text + "',InstCategory='" + cmboCategory.SelectedItem.ToString()+ "' where InstId="+InstKey+";";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                    Con.Close();
                    populate();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void cmboFilterbrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterBrand();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void cmboFiltercategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterCategory();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchInstrument();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            login lg = new login();
            
            lg.ShowDialog();
        }

        private void btnSellers_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void cmboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    
}
