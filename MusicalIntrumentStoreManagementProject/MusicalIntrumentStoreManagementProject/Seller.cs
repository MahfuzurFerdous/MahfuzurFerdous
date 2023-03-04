using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MusicalIntrumentStoreManagementProject
{
    public partial class Seller : Form
    {
        private static string currentUid;
        private static string currentName;
        
        public Seller(string uid, string name)
        {
            currentUid = uid;
            currentName = name;            
            InitializeComponent();
            label8.Text = "Welcome back, " + currentName;

            loadInstruments();
        }
        private void loadInstruments(string searchTerm = null)
        {
            string connection = @"Data Source=localhost\sqlexpress;Integrated Security=True";
            string query;
            
            if (string.IsNullOrEmpty(searchTerm))
            {
                query = "select instId AS 'Item ID', InstName AS 'Item Name', InstBrand AS 'Brand', InstPrice AS 'Price', InstQuantity AS 'Quantity' from InstTable1";
            } 
            else 
            {
                //MessageBox.Show(searchTerm);
                query = "select instId AS 'Item ID', InstName AS 'Item Name', InstBrand AS 'Brand', InstPrice AS 'Price', InstQuantity AS 'Quantity' from InstTable1 Where name LIKE '%" + searchTerm + "%'";
                //MessageBox.Show(query);
            }
            SqlConnection con = new SqlConnection(connection);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            items.DataSource = dt;
        }
        private void PopulateGridView()
        {
            
           
        }

        private void priceSeller_TextChanged(object sender, EventArgs e)
        {

        }

        private void instrumentQuantitySeller_TextChanged(object sender, EventArgs e)
        {

        }

        private void addSeller_Click(object sender, EventArgs e)
        {
            if (
                !string.IsNullOrEmpty(this.instId.Text.ToString().Trim()) &&
                !string.IsNullOrEmpty(this.instName.Text.ToString().Trim()) &&
                !string.IsNullOrEmpty(this.instPrice.Text.ToString().Trim()) &&
                !string.IsNullOrEmpty(this.instQnty.Text.ToString().Trim())

            )
            {
                this.clientBill.Rows.Add(
                    this.instId.Text.ToString().Trim(),
                    this.instName.Text.ToString().Trim(),
                    this.instPrice.Text.ToString().Trim(),
                    this.instQnty.Text.ToString().Trim(),
                    Convert.ToDouble(this.instQnty.Text.ToString().Trim()) * Convert.ToDouble(this.instPrice.Text.ToString().Trim())
                );

                calculateTotal(Convert.ToDouble(this.instQnty.Text.ToString().Trim()) * Convert.ToDouble(this.instPrice.Text.ToString().Trim()));
                
                instId.Text = "";
                instName.Text = "";
                instPrice.Text = "";
                instQnty.Text = "";
            }
            else
            {
                MessageBox.Show("No instrument is selected.");
            }
            
        }

        private void calculateTotal(double amount)
        {
            double totalAmount = Convert.ToDouble(label10.Text.ToString());
            label10.Text = (totalAmount + amount).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void instrumentNameSeller_TextChanged(object sender, EventArgs e)
        {

        }

        private void tk_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void profile_Click(object sender, EventArgs e)
        {
            Profile pro = new Profile(currentUid, currentName);
            pro.Visible = true;
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();

            login ad = new login();
            
            ad.ShowDialog();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            label10.Text = "0";
            clientBill.Rows.Clear();
            clientBill.Refresh();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void print_Click(object sender, EventArgs e)
        {
            /*printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("a4", 1000, 1500);
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }*/
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
             
        }

        private void search_Click(object sender, EventArgs e)
        {

            loadInstruments(this.txtSearch.Text.ToString().Trim());
        }

        private void items_DoubleClick(object sender, EventArgs e)
        {
            this.instId.Text = this.items.CurrentRow.Cells["Item ID"].Value.ToString();
            this.instName.Text = this.items.CurrentRow.Cells["Item Name"].Value.ToString();
            this.instPrice.Text = this.items.CurrentRow.Cells["Price"].Value.ToString();
            this.instQnty.Text = "1";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void instName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
