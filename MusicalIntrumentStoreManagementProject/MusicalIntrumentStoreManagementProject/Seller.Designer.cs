namespace MusicalIntrumentStoreManagementProject
{
    partial class Seller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seller));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.profile = new System.Windows.Forms.Button();
            this.clientBill = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.items = new System.Windows.Forms.DataGridView();
            this.addSeller = new System.Windows.Forms.Button();
            this.instPrice = new System.Windows.Forms.TextBox();
            this.instQnty = new System.Windows.Forms.TextBox();
            this.instId = new System.Windows.Forms.TextBox();
            this.instName = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 678);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.profile);
            this.panel2.Controls.Add(this.clientBill);
            this.panel2.Controls.Add(this.back);
            this.panel2.Controls.Add(this.reset);
            this.panel2.Controls.Add(this.items);
            this.panel2.Controls.Add(this.addSeller);
            this.panel2.Controls.Add(this.instPrice);
            this.panel2.Controls.Add(this.instQnty);
            this.panel2.Controls.Add(this.instId);
            this.panel2.Controls.Add(this.instName);
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 598);
            this.panel2.TabIndex = 0;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.DarkSlateGray;
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(960, 87);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(72, 34);
            this.search.TabIndex = 35;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(814, 93);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(134, 28);
            this.txtSearch.TabIndex = 34;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(754, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Welcome, YourName";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 35);
            this.label3.TabIndex = 30;
            this.label3.Text = "Client Bill";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Quantity";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(872, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 33);
            this.label10.TabIndex = 26;
            this.label10.Text = "0";
            this.label10.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(775, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 33);
            this.label4.TabIndex = 26;
            this.label4.Text = "Total:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Instrument ID";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Instrument Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 38);
            this.label1.TabIndex = 23;
            this.label1.Text = "Instrument Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.DarkSlateGray;
            this.profile.ForeColor = System.Drawing.Color.White;
            this.profile.Location = new System.Drawing.Point(950, 12);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(91, 40);
            this.profile.TabIndex = 22;
            this.profile.Text = "Profile";
            this.profile.UseVisualStyleBackColor = false;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // clientBill
            // 
            this.clientBill.AllowUserToAddRows = false;
            this.clientBill.AllowUserToDeleteRows = false;
            this.clientBill.AllowUserToResizeColumns = false;
            this.clientBill.AllowUserToResizeRows = false;
            this.clientBill.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.clientBill.ColumnHeadersHeight = 29;
            this.clientBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.clientBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.clientBill.GridColor = System.Drawing.SystemColors.WindowText;
            this.clientBill.Location = new System.Drawing.Point(3, 341);
            this.clientBill.Name = "clientBill";
            this.clientBill.ReadOnly = true;
            this.clientBill.RowHeadersWidth = 51;
            this.clientBill.RowTemplate.Height = 24;
            this.clientBill.Size = new System.Drawing.Size(740, 257);
            this.clientBill.TabIndex = 20;
            this.clientBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientBill_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkRed;
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(921, 546);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(120, 40);
            this.back.TabIndex = 19;
            this.back.Text = "Quit";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.DarkSlateGray;
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(921, 501);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(120, 39);
            this.reset.TabIndex = 18;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // items
            // 
            this.items.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.items.GridColor = System.Drawing.Color.White;
            this.items.Location = new System.Drawing.Point(422, 133);
            this.items.Name = "items";
            this.items.ReadOnly = true;
            this.items.RowHeadersWidth = 51;
            this.items.RowTemplate.Height = 24;
            this.items.Size = new System.Drawing.Size(610, 193);
            this.items.TabIndex = 14;
            this.items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.items.DoubleClick += new System.EventHandler(this.items_DoubleClick);
            // 
            // addSeller
            // 
            this.addSeller.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addSeller.ForeColor = System.Drawing.Color.White;
            this.addSeller.Location = new System.Drawing.Point(12, 226);
            this.addSeller.Name = "addSeller";
            this.addSeller.Size = new System.Drawing.Size(142, 47);
            this.addSeller.TabIndex = 8;
            this.addSeller.Text = "Add";
            this.addSeller.UseVisualStyleBackColor = false;
            this.addSeller.Click += new System.EventHandler(this.addSeller_Click);
            // 
            // instPrice
            // 
            this.instPrice.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instPrice.Location = new System.Drawing.Point(16, 167);
            this.instPrice.Multiline = true;
            this.instPrice.Name = "instPrice";
            this.instPrice.ReadOnly = true;
            this.instPrice.Size = new System.Drawing.Size(142, 41);
            this.instPrice.TabIndex = 7;
            this.instPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // instQnty
            // 
            this.instQnty.BackColor = System.Drawing.SystemColors.Menu;
            this.instQnty.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instQnty.Location = new System.Drawing.Point(203, 175);
            this.instQnty.Multiline = true;
            this.instQnty.Name = "instQnty";
            this.instQnty.Size = new System.Drawing.Size(164, 33);
            this.instQnty.TabIndex = 6;
            this.instQnty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // instId
            // 
            this.instId.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instId.Location = new System.Drawing.Point(12, 87);
            this.instId.Multiline = true;
            this.instId.Name = "instId";
            this.instId.ReadOnly = true;
            this.instId.Size = new System.Drawing.Size(164, 41);
            this.instId.TabIndex = 5;
            this.instId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // instName
            // 
            this.instName.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instName.Location = new System.Drawing.Point(199, 87);
            this.instName.Multiline = true;
            this.instName.Name = "instName";
            this.instName.ReadOnly = true;
            this.instName.Size = new System.Drawing.Size(164, 41);
            this.instName.TabIndex = 5;
            this.instName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.instName.TextChanged += new System.EventHandler(this.instName_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 678);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Seller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox instPrice;
        private System.Windows.Forms.TextBox instQnty;
        private System.Windows.Forms.TextBox instName;
        private System.Windows.Forms.Button addSeller;
        private System.Windows.Forms.DataGridView items;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.DataGridView clientBill;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox instId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

